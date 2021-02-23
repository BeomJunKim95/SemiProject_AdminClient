using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient
{
    public static class UtilEvent
    {
        #region TextBoxKeyPressEvent
        public static void TextBoxIsDigit(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        public static void TextBoxNoIsDigit(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        public static void tbx_Trim(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        public static void isHangul_KeyPress(object sender, KeyPressEventArgs e)
        {
            string a = e.KeyChar.ToString();
            Regex regex = new Regex("[ㄱ-ㅎ가-힣]");
            if (!(regex.IsMatch(a) || e.KeyChar == 8 || e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }

        public static void isAlpha_KeyPress(object sender, KeyPressEventArgs e)
        {
            string a = e.KeyChar.ToString();
            Regex regex = new Regex(@"[a-zA-Z]");
            if ((!(regex.IsMatch(a) || e.KeyChar == 8 || e.KeyChar == ' ')))
            {
                e.Handled = true;
            }
        }

        public static void isAlphaAndDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            string a = e.KeyChar.ToString();
            Regex regex = new Regex(@"[a-zA-Z0-9]");
            if (!(regex.IsMatch(a) || e.KeyChar == 8 || e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }

        public static void Handled_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public static void tbx_password_Test(object sender, EventArgs e)
        {
            Regex test1 = new Regex("(?=.*?[a-zA-Z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}");
            Regex test2 = new Regex("(?=.*?[a-zA-Z])(?=.*?[0-9]).{8,}");
            if (test1.IsMatch(""))
            {

            }
            else if (test2.IsMatch(""))
            {

            }
            else
            {

            }
        }
        #endregion

        /// <summary>
        /// 텍스트박스에 아무것도 입력받지 않았을때 
        /// </summary>
        /// <param name="txt">텍스트박스 컨트롤명</param>
        /// <param name="msg">메세지박스에 출력할 문자열</param>
        public static void TextBoxIsNotNull(TextBox txt, string msg)
		{
			if (string.IsNullOrEmpty(txt.Text.Trim()))
			{
                MessageBox.Show(msg);
                return;
			}
		}
    }
}
