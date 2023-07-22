using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parkon
{
   public class TextCheck
    {
        public CLS CLS;

        public string StringENG(string StringTR)
        {
            StringTR = StringTR.Replace('ö', 'o');
            StringTR = StringTR.Replace('ü', 'u');
            StringTR = StringTR.Replace('ğ', 'g');
            StringTR = StringTR.Replace('ş', 's');
            StringTR = StringTR.Replace('ı', 'i');
            StringTR = StringTR.Replace('ç', 'c');
            StringTR = StringTR.Replace('Ö', 'O');
            StringTR = StringTR.Replace('Ü', 'U');
            StringTR = StringTR.Replace('Ğ', 'G');
            StringTR = StringTR.Replace('Ş', 'S');
            StringTR = StringTR.Replace('İ', 'I');
            StringTR = StringTR.Replace('Ç', 'C');

            return StringTR;
        }



        private void BUYUK_HARF_YAZ(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).SelectionStart = ((TextBox)sender).Text.Length;
        }
        private void BUYUK_HARF_YAZ_ENG(object sender, EventArgs e)
        {

            ((TextBox)sender).Text = CLS.TextCheck.StringENG(((TextBox)sender).Text).ToUpper();
            ((TextBox)sender).SelectionStart = ((TextBox)sender).Text.Length;
        }
        private void SADECE_RAKAM_YAZ(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void SADECE_HARF_YAZ(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                        && !char.IsSeparator(e.KeyChar);
        }


    }
}
