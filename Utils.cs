using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenVRInfo
{
    static class Utils
    {
        public static string CamelCase2Words(string src)
        {
            var builder = new StringBuilder();
            var prevSmall = false;

            foreach (var c in src)
            {
                if (!char.IsLetter(c))
                {
                    prevSmall = false;
                }
                else if (char.IsUpper(c) && prevSmall)
                {
                    builder.Append(' ');
                    prevSmall = false;
                }
                else if (char.IsLower(c))
                {
                    prevSmall = true;
                }
                else
                {
                    prevSmall = false;
                }

                builder.Append(c);
            }

            return builder.ToString();
        }

        public static string ExtractName(string src)
        {
            var parts = src.Split('_');
            if (parts.Length == 1)
            {
                return CamelCase2Words(src);
            }
            else if (parts.Length == 2)
            {
                return CamelCase2Words(parts[1]);
            }
            else
            {
                return CamelCase2Words(string.Join(" ", parts.Skip(1).Take(parts.Length - 2).ToArray()));
            }
        }
    }
}
