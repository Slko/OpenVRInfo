using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Valve.VR;

namespace OpenVRInfo
{
    struct EVRApplicationTypeWrapper
    {
        public EVRApplicationType Type { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    struct OpenVRDeviceProperty
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    struct OpenVRDevice
    {
        public uint ID { get; set; }
        public string Name { get; set; }
        public ETrackedDeviceClass Class { get; set; }
        public ETrackedControllerRole Role { get; set; }
        public bool Connected { get; set; }
        public OpenVRDeviceProperty[] Properties { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public partial class MainForm : Form
    {
        private CVRSystem _system = null;

        public MainForm()
        {
            InitializeComponent();

            InitUI();
        }

        private void InitUI()
        {
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);

            initModeComboBox.Items.Clear();

            foreach (var value in Enum.GetValues(typeof(EVRApplicationType)))
            {
                if ((EVRApplicationType)value == EVRApplicationType.VRApplication_Max)
                {
                    continue;
                }

                initModeComboBox.Items.Add(new EVRApplicationTypeWrapper()
                {
                    Type = (EVRApplicationType)value,
                    Name = Utils.ExtractName(Enum.GetName(typeof(EVRApplicationType), value)),
                });
                if ((EVRApplicationType)value == EVRApplicationType.VRApplication_Scene)
                {
                    initModeComboBox.SelectedIndex = initModeComboBox.Items.Count - 1;
                }
            }

            UpdateUI();
            refreshGeneralButton_Click(this, EventArgs.Empty);
        }

        private void UpdateUI()
        {
            initButton.Text = _system == null ? "Init OpenVR" : "Shutdown OpenVR";
            initModeComboBox.Enabled = _system == null;
            refreshDevicesButton.Enabled = _system != null;
        }

        private void initButton_Click(object sender, EventArgs e)
        {
            if (_system == null)
            {

                EVRInitError error = EVRInitError.None;

                _system = OpenVR.Init(ref error, ((EVRApplicationTypeWrapper)initModeComboBox.SelectedItem).Type);

                if (_system == null)
                {
                    MessageBox.Show(this, $"Failed to init OpenVR ({error}):\n\n{OpenVR.GetStringForHmdError(error)}", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                OpenVR.Shutdown();
                _system = null;
            }

            UpdateUI();

            if (_system != null)
            {
                refreshDevicesButton_Click(this, EventArgs.Empty);
            }
        }

        private void refreshDevicesButton_Click(object sender, EventArgs e)
        {
            devicesListBox.SelectedItem = null;
            devicesListBox.Items.Clear();

            for (uint i = 0; i < OpenVR.k_unMaxTrackedDeviceCount; i++)
            {
                var cls = _system.GetTrackedDeviceClass(i);
                if (cls == ETrackedDeviceClass.Invalid)
                {
                    continue;
                }

                var properties = new List<OpenVRDeviceProperty>();

                foreach (var value in Enum.GetValues(typeof(ETrackedDeviceProperty)))
                {
                    var internalName = Enum.GetName(typeof(ETrackedDeviceProperty), value);

                    if ((ETrackedDeviceProperty)value == ETrackedDeviceProperty.Prop_Invalid || internalName.Count(x => x == '_') < 2 || internalName.EndsWith("Max") || internalName.EndsWith("Start") || internalName.EndsWith("End"))
                    {
                        continue;
                    }

                    var type = internalName.Split('_').Last();
                    string name;
                    string extractedValue;
                    string subtype = null;
                    if (type == "Array")
                    {
                        var noArrayName = internalName.Substring(0, internalName.Length - type.Length - 1);
                        name = Utils.ExtractName(noArrayName);
                        subtype = noArrayName.Split('_').Last();
                    }
                    else
                    {
                        name = Utils.ExtractName(internalName);
                    }
                    ETrackedPropertyError error = ETrackedPropertyError.TrackedProp_Success;
                    switch (type)
                    {
                        case "String":
                            var buffer = new StringBuilder((int)OpenVR.k_unMaxPropertyStringSize);
                            var actualSize = _system.GetStringTrackedDeviceProperty(i, (ETrackedDeviceProperty)value, buffer, (uint)buffer.Capacity, ref error);
                            if (error == ETrackedPropertyError.TrackedProp_Success)
                            {
                                if (actualSize == 0)
                                {
                                    extractedValue = $"Invalid return value (size == 0)";
                                }
                                else
                                {
                                    buffer.Length = (int)actualSize - 1;
                                    extractedValue = buffer.ToString();
                                }
                            }
                            else if (error == ETrackedPropertyError.TrackedProp_UnknownProperty)
                            {
                                continue;
                            }
                            else
                            {
                                extractedValue = $"Error ({Utils.ExtractName(error.ToString())}";
                            }
                            break;
                        case "Bool":
                            extractedValue = _system.GetBoolTrackedDeviceProperty(i, (ETrackedDeviceProperty)value, ref error) ? "true" : "false";
                            if (error == ETrackedPropertyError.TrackedProp_UnknownProperty)
                            {
                                continue;
                            }
                            else if (error != ETrackedPropertyError.TrackedProp_Success)
                            {
                                extractedValue = $"Error: {Utils.ExtractName(error.ToString())}";
                            }
                            break;
                        case "Int32":
                            extractedValue = _system.GetInt32TrackedDeviceProperty(i, (ETrackedDeviceProperty)value, ref error).ToString();
                            if (error == ETrackedPropertyError.TrackedProp_UnknownProperty)
                            {
                                continue;
                            }
                            else if (error != ETrackedPropertyError.TrackedProp_Success)
                            {
                                extractedValue = $"Error: {Utils.ExtractName(error.ToString())}";
                            }
                            break;
                        case "Uint64":
                            extractedValue = _system.GetUint64TrackedDeviceProperty(i, (ETrackedDeviceProperty)value, ref error).ToString();
                            if (error == ETrackedPropertyError.TrackedProp_UnknownProperty)
                            {
                                continue;
                            }
                            else if (error != ETrackedPropertyError.TrackedProp_Success)
                            {
                                extractedValue = $"Error: {Utils.ExtractName(error.ToString())}";
                            }
                            break;
                        case "Float":
                            extractedValue = _system.GetFloatTrackedDeviceProperty(i, (ETrackedDeviceProperty)value, ref error).ToString();
                            if (error == ETrackedPropertyError.TrackedProp_UnknownProperty)
                            {
                                continue;
                            }
                            else if (error != ETrackedPropertyError.TrackedProp_Success)
                            {
                                extractedValue = $"Error: {Utils.ExtractName(error.ToString())}";
                            }
                            break;
                        case "Matrix34":
                            var matrix = _system.GetMatrix34TrackedDeviceProperty(i, (ETrackedDeviceProperty)value, ref error);
                            extractedValue = $"Matrix34 {{ {string.Join(", ", matrix.m0, matrix.m1, matrix.m2, matrix.m3, matrix.m4, matrix.m5, matrix.m6, matrix.m7, matrix.m8, matrix.m9, matrix.m10, matrix.m11)} }}";
                            if (error == ETrackedPropertyError.TrackedProp_UnknownProperty)
                            {
                                continue;
                            }
                            else if (error != ETrackedPropertyError.TrackedProp_Success)
                            {
                                extractedValue = $"Error: {Utils.ExtractName(error.ToString())}";
                            }
                            break;
                        default:
                            if (subtype == null)
                            {
                                extractedValue = $"Unsupported property type: {type}";
                            }
                            else
                            {
                                extractedValue = $"Unsupported property type: {subtype}[]";
                            }
                            break;
                    }

                    properties.Add(new OpenVRDeviceProperty()
                    {
                        Name = name,
                        Value = extractedValue,
                    });
                }

                devicesListBox.Items.Add(new OpenVRDevice()
                {
                    ID = i,
                    Name = $"Device #{i} ({Utils.ExtractName(cls.ToString())})",
                    Class = cls,
                    Role = _system.GetControllerRoleForTrackedDeviceIndex(i),
                    Connected = _system.IsTrackedDeviceConnected(i),
                    Properties = properties.ToArray(),
                });
            }
        }

        private void devicesListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (devicesListBox.SelectedItem == null)
            {
                devicePropertiesDataGridView.DataSource = null;

                deviceClassValueLabel.Text = "N/A";
                deviceRoleValueLabel.Text = "N/A";
                deviceConnectedValueLabel.Text = "N/A";

                return;
            }

            devicePropertiesDataGridView.DataSource = ((OpenVRDevice)devicesListBox.SelectedItem).Properties;

            deviceClassValueLabel.Text = Utils.CamelCase2Words(((OpenVRDevice)devicesListBox.SelectedItem).Class.ToString());
            deviceRoleValueLabel.Text = Utils.CamelCase2Words(((OpenVRDevice)devicesListBox.SelectedItem).Role.ToString());
            deviceConnectedValueLabel.Text = ((OpenVRDevice)devicesListBox.SelectedItem).Connected ? "true" : "false";
        }

        private void refreshGeneralButton_Click(object sender, EventArgs e)
        {
            runtimeInstalledValueLabel.Text = OpenVR.IsRuntimeInstalled() ? "Yes" : "No";
            hmdPresentValueLabel.Text = OpenVR.IsHmdPresent() ? "Yes" : "No";
            runtimePathValueLabel.Text = OpenVR.RuntimePath();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_system != null)
            {
                OpenVR.Shutdown();
                _system = null;
            }
        }
    }
}
