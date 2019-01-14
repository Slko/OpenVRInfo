namespace OpenVRInfo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.initButton = new System.Windows.Forms.Button();
            this.initModeComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.refreshGeneralButton = new System.Windows.Forms.Button();
            this.generalTabLayout = new System.Windows.Forms.TableLayoutPanel();
            this.runtimeInstalledValueLabel = new System.Windows.Forms.Label();
            this.runtimeInstalledNameLabel = new System.Windows.Forms.Label();
            this.devicesTabPage = new System.Windows.Forms.TabPage();
            this.deviceConnectedValueLabel = new System.Windows.Forms.Label();
            this.deviceConnectedNameLabel = new System.Windows.Forms.Label();
            this.deviceRoleValueLabel = new System.Windows.Forms.Label();
            this.deviceRoleNameLabel = new System.Windows.Forms.Label();
            this.deviceClassValueLabel = new System.Windows.Forms.Label();
            this.deviceClassNameLabel = new System.Windows.Forms.Label();
            this.devicePropertiesDataGridView = new System.Windows.Forms.DataGridView();
            this.refreshDevicesButton = new System.Windows.Forms.Button();
            this.deviceListHeaderLabel = new System.Windows.Forms.Label();
            this.devicesListBox = new System.Windows.Forms.ListBox();
            this.hmdPresentNameLabel = new System.Windows.Forms.Label();
            this.runtimePathNameLabel = new System.Windows.Forms.Label();
            this.hmdPresentValueLabel = new System.Windows.Forms.Label();
            this.runtimePathValueLabel = new System.Windows.Forms.Label();
            this.devicesTabLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.generalTabLayout.SuspendLayout();
            this.devicesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicePropertiesDataGridView)).BeginInit();
            this.devicesTabLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // initButton
            // 
            this.initButton.Location = new System.Drawing.Point(12, 12);
            this.initButton.Name = "initButton";
            this.initButton.Size = new System.Drawing.Size(125, 23);
            this.initButton.TabIndex = 0;
            this.initButton.Text = "initButton";
            this.initButton.UseVisualStyleBackColor = true;
            this.initButton.Click += new System.EventHandler(this.initButton_Click);
            // 
            // initModeComboBox
            // 
            this.initModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.initModeComboBox.FormattingEnabled = true;
            this.initModeComboBox.Location = new System.Drawing.Point(143, 14);
            this.initModeComboBox.Name = "initModeComboBox";
            this.initModeComboBox.Size = new System.Drawing.Size(164, 21);
            this.initModeComboBox.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.generalTabPage);
            this.tabControl.Controls.Add(this.devicesTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 41);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 397);
            this.tabControl.TabIndex = 2;
            // 
            // generalTabPage
            // 
            this.generalTabPage.Controls.Add(this.refreshGeneralButton);
            this.generalTabPage.Controls.Add(this.generalTabLayout);
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalTabPage.Size = new System.Drawing.Size(768, 371);
            this.generalTabPage.TabIndex = 2;
            this.generalTabPage.Text = "General";
            this.generalTabPage.UseVisualStyleBackColor = true;
            // 
            // refreshGeneralButton
            // 
            this.refreshGeneralButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshGeneralButton.Location = new System.Drawing.Point(687, 342);
            this.refreshGeneralButton.Name = "refreshGeneralButton";
            this.refreshGeneralButton.Size = new System.Drawing.Size(75, 23);
            this.refreshGeneralButton.TabIndex = 1;
            this.refreshGeneralButton.Text = "Refresh";
            this.refreshGeneralButton.UseVisualStyleBackColor = true;
            this.refreshGeneralButton.Click += new System.EventHandler(this.refreshGeneralButton_Click);
            // 
            // generalTabLayout
            // 
            this.generalTabLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalTabLayout.ColumnCount = 2;
            this.generalTabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.generalTabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.generalTabLayout.Controls.Add(this.runtimeInstalledValueLabel, 1, 0);
            this.generalTabLayout.Controls.Add(this.runtimeInstalledNameLabel, 0, 0);
            this.generalTabLayout.Controls.Add(this.hmdPresentNameLabel, 0, 1);
            this.generalTabLayout.Controls.Add(this.runtimePathNameLabel, 0, 2);
            this.generalTabLayout.Controls.Add(this.hmdPresentValueLabel, 1, 1);
            this.generalTabLayout.Controls.Add(this.runtimePathValueLabel, 1, 2);
            this.generalTabLayout.Location = new System.Drawing.Point(6, 6);
            this.generalTabLayout.Name = "generalTabLayout";
            this.generalTabLayout.RowCount = 3;
            this.generalTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.generalTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.generalTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.generalTabLayout.Size = new System.Drawing.Size(756, 330);
            this.generalTabLayout.TabIndex = 0;
            // 
            // runtimeInstalledValueLabel
            // 
            this.runtimeInstalledValueLabel.AutoSize = true;
            this.runtimeInstalledValueLabel.Location = new System.Drawing.Point(103, 0);
            this.runtimeInstalledValueLabel.Name = "runtimeInstalledValueLabel";
            this.runtimeInstalledValueLabel.Size = new System.Drawing.Size(27, 13);
            this.runtimeInstalledValueLabel.TabIndex = 1;
            this.runtimeInstalledValueLabel.Text = "N/A";
            // 
            // runtimeInstalledNameLabel
            // 
            this.runtimeInstalledNameLabel.AutoSize = true;
            this.runtimeInstalledNameLabel.Location = new System.Drawing.Point(3, 0);
            this.runtimeInstalledNameLabel.Name = "runtimeInstalledNameLabel";
            this.runtimeInstalledNameLabel.Size = new System.Drawing.Size(91, 13);
            this.runtimeInstalledNameLabel.TabIndex = 0;
            this.runtimeInstalledNameLabel.Text = "Runtime Installed:";
            // 
            // devicesTabPage
            // 
            this.devicesTabPage.Controls.Add(this.devicesTabLayout);
            this.devicesTabPage.Controls.Add(this.devicePropertiesDataGridView);
            this.devicesTabPage.Controls.Add(this.refreshDevicesButton);
            this.devicesTabPage.Controls.Add(this.deviceListHeaderLabel);
            this.devicesTabPage.Controls.Add(this.devicesListBox);
            this.devicesTabPage.Location = new System.Drawing.Point(4, 22);
            this.devicesTabPage.Name = "devicesTabPage";
            this.devicesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.devicesTabPage.Size = new System.Drawing.Size(768, 371);
            this.devicesTabPage.TabIndex = 1;
            this.devicesTabPage.Text = "Devices";
            this.devicesTabPage.UseVisualStyleBackColor = true;
            // 
            // deviceConnectedValueLabel
            // 
            this.deviceConnectedValueLabel.AutoSize = true;
            this.deviceConnectedValueLabel.Location = new System.Drawing.Point(103, 40);
            this.deviceConnectedValueLabel.Name = "deviceConnectedValueLabel";
            this.deviceConnectedValueLabel.Size = new System.Drawing.Size(27, 13);
            this.deviceConnectedValueLabel.TabIndex = 9;
            this.deviceConnectedValueLabel.Text = "N/A";
            // 
            // deviceConnectedNameLabel
            // 
            this.deviceConnectedNameLabel.AutoSize = true;
            this.deviceConnectedNameLabel.Location = new System.Drawing.Point(3, 40);
            this.deviceConnectedNameLabel.Name = "deviceConnectedNameLabel";
            this.deviceConnectedNameLabel.Size = new System.Drawing.Size(62, 13);
            this.deviceConnectedNameLabel.TabIndex = 8;
            this.deviceConnectedNameLabel.Text = "Connected:";
            // 
            // deviceRoleValueLabel
            // 
            this.deviceRoleValueLabel.AutoSize = true;
            this.deviceRoleValueLabel.Location = new System.Drawing.Point(103, 20);
            this.deviceRoleValueLabel.Name = "deviceRoleValueLabel";
            this.deviceRoleValueLabel.Size = new System.Drawing.Size(27, 13);
            this.deviceRoleValueLabel.TabIndex = 7;
            this.deviceRoleValueLabel.Text = "N/A";
            // 
            // deviceRoleNameLabel
            // 
            this.deviceRoleNameLabel.AutoSize = true;
            this.deviceRoleNameLabel.Location = new System.Drawing.Point(3, 20);
            this.deviceRoleNameLabel.Name = "deviceRoleNameLabel";
            this.deviceRoleNameLabel.Size = new System.Drawing.Size(32, 13);
            this.deviceRoleNameLabel.TabIndex = 6;
            this.deviceRoleNameLabel.Text = "Role:";
            // 
            // deviceClassValueLabel
            // 
            this.deviceClassValueLabel.AutoSize = true;
            this.deviceClassValueLabel.Location = new System.Drawing.Point(103, 0);
            this.deviceClassValueLabel.Name = "deviceClassValueLabel";
            this.deviceClassValueLabel.Size = new System.Drawing.Size(27, 13);
            this.deviceClassValueLabel.TabIndex = 5;
            this.deviceClassValueLabel.Text = "N/A";
            // 
            // deviceClassNameLabel
            // 
            this.deviceClassNameLabel.AutoSize = true;
            this.deviceClassNameLabel.Location = new System.Drawing.Point(3, 0);
            this.deviceClassNameLabel.Name = "deviceClassNameLabel";
            this.deviceClassNameLabel.Size = new System.Drawing.Size(32, 13);
            this.deviceClassNameLabel.TabIndex = 4;
            this.deviceClassNameLabel.Text = "Class";
            // 
            // devicePropertiesDataGridView
            // 
            this.devicePropertiesDataGridView.AllowUserToAddRows = false;
            this.devicePropertiesDataGridView.AllowUserToDeleteRows = false;
            this.devicePropertiesDataGridView.AllowUserToResizeRows = false;
            this.devicePropertiesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.devicePropertiesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.devicePropertiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devicePropertiesDataGridView.Location = new System.Drawing.Point(221, 85);
            this.devicePropertiesDataGridView.Name = "devicePropertiesDataGridView";
            this.devicePropertiesDataGridView.ReadOnly = true;
            this.devicePropertiesDataGridView.RowHeadersVisible = false;
            this.devicePropertiesDataGridView.Size = new System.Drawing.Size(541, 250);
            this.devicePropertiesDataGridView.TabIndex = 3;
            // 
            // refreshDevicesButton
            // 
            this.refreshDevicesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshDevicesButton.Location = new System.Drawing.Point(687, 342);
            this.refreshDevicesButton.Name = "refreshDevicesButton";
            this.refreshDevicesButton.Size = new System.Drawing.Size(75, 23);
            this.refreshDevicesButton.TabIndex = 2;
            this.refreshDevicesButton.Text = "Refresh";
            this.refreshDevicesButton.UseVisualStyleBackColor = true;
            this.refreshDevicesButton.Click += new System.EventHandler(this.refreshDevicesButton_Click);
            // 
            // deviceListHeaderLabel
            // 
            this.deviceListHeaderLabel.AutoSize = true;
            this.deviceListHeaderLabel.Location = new System.Drawing.Point(6, 3);
            this.deviceListHeaderLabel.Name = "deviceListHeaderLabel";
            this.deviceListHeaderLabel.Size = new System.Drawing.Size(59, 13);
            this.deviceListHeaderLabel.TabIndex = 1;
            this.deviceListHeaderLabel.Text = "Device list:";
            // 
            // devicesListBox
            // 
            this.devicesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.devicesListBox.FormattingEnabled = true;
            this.devicesListBox.Location = new System.Drawing.Point(9, 19);
            this.devicesListBox.Name = "devicesListBox";
            this.devicesListBox.Size = new System.Drawing.Size(206, 316);
            this.devicesListBox.TabIndex = 0;
            this.devicesListBox.SelectedValueChanged += new System.EventHandler(this.devicesListBox_SelectedValueChanged);
            // 
            // hmdPresentNameLabel
            // 
            this.hmdPresentNameLabel.AutoSize = true;
            this.hmdPresentNameLabel.Location = new System.Drawing.Point(3, 20);
            this.hmdPresentNameLabel.Name = "hmdPresentNameLabel";
            this.hmdPresentNameLabel.Size = new System.Drawing.Size(74, 13);
            this.hmdPresentNameLabel.TabIndex = 2;
            this.hmdPresentNameLabel.Text = "HMD Present:";
            // 
            // runtimePathNameLabel
            // 
            this.runtimePathNameLabel.AutoSize = true;
            this.runtimePathNameLabel.Location = new System.Drawing.Point(3, 40);
            this.runtimePathNameLabel.Name = "runtimePathNameLabel";
            this.runtimePathNameLabel.Size = new System.Drawing.Size(74, 13);
            this.runtimePathNameLabel.TabIndex = 3;
            this.runtimePathNameLabel.Text = "Runtime Path:";
            // 
            // hmdPresentValueLabel
            // 
            this.hmdPresentValueLabel.AutoSize = true;
            this.hmdPresentValueLabel.Location = new System.Drawing.Point(103, 20);
            this.hmdPresentValueLabel.Name = "hmdPresentValueLabel";
            this.hmdPresentValueLabel.Size = new System.Drawing.Size(27, 13);
            this.hmdPresentValueLabel.TabIndex = 4;
            this.hmdPresentValueLabel.Text = "N/A";
            // 
            // runtimePathValueLabel
            // 
            this.runtimePathValueLabel.AutoSize = true;
            this.runtimePathValueLabel.Location = new System.Drawing.Point(103, 40);
            this.runtimePathValueLabel.Name = "runtimePathValueLabel";
            this.runtimePathValueLabel.Size = new System.Drawing.Size(27, 13);
            this.runtimePathValueLabel.TabIndex = 5;
            this.runtimePathValueLabel.Text = "N/A";
            // 
            // devicesTabLayout
            // 
            this.devicesTabLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.devicesTabLayout.ColumnCount = 2;
            this.devicesTabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.devicesTabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.devicesTabLayout.Controls.Add(this.deviceClassNameLabel, 0, 0);
            this.devicesTabLayout.Controls.Add(this.deviceConnectedValueLabel, 1, 2);
            this.devicesTabLayout.Controls.Add(this.deviceClassValueLabel, 1, 0);
            this.devicesTabLayout.Controls.Add(this.deviceConnectedNameLabel, 0, 2);
            this.devicesTabLayout.Controls.Add(this.deviceRoleNameLabel, 0, 1);
            this.devicesTabLayout.Controls.Add(this.deviceRoleValueLabel, 1, 1);
            this.devicesTabLayout.Location = new System.Drawing.Point(221, 19);
            this.devicesTabLayout.Name = "devicesTabLayout";
            this.devicesTabLayout.RowCount = 3;
            this.devicesTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.devicesTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.devicesTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.devicesTabLayout.Size = new System.Drawing.Size(541, 60);
            this.devicesTabLayout.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.initModeComboBox);
            this.Controls.Add(this.initButton);
            this.Name = "MainForm";
            this.Text = "OpenVR Info Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tabControl.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.generalTabLayout.ResumeLayout(false);
            this.generalTabLayout.PerformLayout();
            this.devicesTabPage.ResumeLayout(false);
            this.devicesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicePropertiesDataGridView)).EndInit();
            this.devicesTabLayout.ResumeLayout(false);
            this.devicesTabLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button initButton;
        private System.Windows.Forms.ComboBox initModeComboBox;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage devicesTabPage;
        private System.Windows.Forms.Label deviceListHeaderLabel;
        private System.Windows.Forms.ListBox devicesListBox;
        private System.Windows.Forms.Button refreshDevicesButton;
        private System.Windows.Forms.DataGridView devicePropertiesDataGridView;
        private System.Windows.Forms.Label deviceClassNameLabel;
        private System.Windows.Forms.Label deviceClassValueLabel;
        private System.Windows.Forms.Label deviceRoleValueLabel;
        private System.Windows.Forms.Label deviceRoleNameLabel;
        private System.Windows.Forms.Label deviceConnectedValueLabel;
        private System.Windows.Forms.Label deviceConnectedNameLabel;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.TableLayoutPanel generalTabLayout;
        private System.Windows.Forms.Label runtimeInstalledNameLabel;
        private System.Windows.Forms.Label runtimeInstalledValueLabel;
        private System.Windows.Forms.Button refreshGeneralButton;
        private System.Windows.Forms.Label hmdPresentNameLabel;
        private System.Windows.Forms.Label runtimePathNameLabel;
        private System.Windows.Forms.Label hmdPresentValueLabel;
        private System.Windows.Forms.Label runtimePathValueLabel;
        private System.Windows.Forms.TableLayoutPanel devicesTabLayout;
    }
}

