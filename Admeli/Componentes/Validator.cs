using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace Admeli.Componentes
{
    public class Validator
    {
        private static bool invalid = false;

        public static void isNumber(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void isString(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool IsValidEmail(string strIn)
        {
            invalid = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", Validator.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format.
            try
            {
                return Regex.IsMatch(strIn,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private static string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }

        internal static void textboxValidateColor(BunifuMetroTextbox textBox, bool isSuccess)
        {
            if (isSuccess)
            {
                textBox.BorderColorIdle = Color.FromArgb(22, 166, 106);
                textBox.BorderColorFocused = Color.FromArgb(22, 166, 106);
                textBox.BorderColorMouseHover = Color.FromArgb(22, 166, 106);
            }
            else
            {
                textBox.BorderColorIdle = Color.FromArgb(248, 63, 81);
                textBox.BorderColorFocused = Color.FromArgb(248, 63, 81);
                textBox.BorderColorMouseHover = Color.FromArgb(248, 63, 81);
            }
        }

        internal static void labelAlert(Label label, int alertType, string message = "")
        {
            /**
             * 0 =====> error
             * 1 =====> success
             * 2 =====> warning
             * 3 =====> info
             * 4 =====> alternative
             * */

            switch (alertType)
            {
                case 0:
                    label.ForeColor = Color.FromArgb(250, 5, 73);
                    label.BackColor = Color.FromArgb(255, 224, 224);
                    break;
                case 1:
                    label.ForeColor = Color.FromArgb(76, 175, 80);
                    label.BackColor = Color.FromArgb(232, 250, 239);
                    break;
                case 2:
                    label.ForeColor = Color.FromArgb(76, 175, 80);
                    label.BackColor = Color.FromArgb(232, 250, 239);
                    break;
                case 3:
                    label.ForeColor = Color.FromArgb(76, 175, 80);
                    label.BackColor = Color.FromArgb(232, 250, 239);
                    break;
                case 4:
                    label.ForeColor = Color.FromArgb(76, 175, 80);
                    label.BackColor = Color.FromArgb(232, 250, 239);
                    break;
                default:
                    break;
            }

            // Message label
            label.Text = message;
        }
    }
}
