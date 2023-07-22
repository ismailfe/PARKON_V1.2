using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Parkon
{
    public partial class Form_Yeni_Proje : Form
    {

        #region PUBLIC_VARIABLE
        public CLS CLS;
        #endregion



        public Form_Yeni_Proje()
        {
            InitializeComponent();
        }





        private void B_Iptal_Click(object sender, EventArgs e)
        {
            Temizle();
            this.Hide();
        }

        private void B_OK_Click(object sender, EventArgs e)
        {

            PROJE_OLUSTUR_ON_KONTROL();
        }

        public void PROJE_OLUSTUR_ON_KONTROL()
        {
            //string Baslik = "Hata";
            //if (CB_MusteriFirma_Adi.Text != "")
            //{
            //    if (TB_YetkiliAd.Text != "")
            //    {
            //        if (TB_YetkiliSoyad.Text != "")
            //        {
            //            if (TB_YetkiliUnvan.Text != "")
            //            {
            //                if (TB_YetkiliTel1.Text != "" || TB_YetkiliTel1.Text != "")
            //                {
            //                    if (TB_YetkiliMail.Text != "")
            //                    {
            //                        if (TB_ProjeAdi.Text != "")
            //                        {
            PROJE_OLUSTUR();
            //                        }
            //                        else { MessageBox.Show("Yetkili No getirmedi!", Baslik); }
            //                    } else {  MessageBox.Show("Yetkili mail adresi girilmedi!", Baslik); }
            //                } else { MessageBox.Show("Yetkili mail adresi girilmedi!", Baslik); }
            //            }else { MessageBox.Show("Yetkili ünvanı girilmedi!", Baslik); }
            //        }else { MessageBox.Show("Yetkili Kişi soyadı Girilmedi!", Baslik); }
            //    }else { MessageBox.Show("Yetkili adı Girilmedi!", Baslik); }
            //} else {  MessageBox.Show("Müşteri firma seçilmedi!", Baslik); }

        }

        public void PROJE_OLUSTUR()
        {
            //DialogResult a = new DialogResult();
            //string baslik = "Yeni Müşteri Ekle - Onay";
            //string mesaj = "Aşağıdaki bilgilere göre yeni bir yetkili eklemeyi kabul ediyor musunuz?" + "\n" + "\n" +
            //    "Müşteri firma no: " + TB_MusteriFirma_No.Text + "\n" +
            //    "Müşteri firma adı: " + CB_MusteriFirma_Adi.Text + "\n" + "\n" +

            //    "Yetkili Ad: " + TB_YetkiliAd.Text + "\n" +
            //    "Yetkili Soyad: " + TB_YetkiliSoyad.Text + "\n" +
            //    "Yetkili Ünvan: " + TB_YetkiliUnvan.Text + "\n" +
            //    "Yetkili Tel1 : " + TB_YetkiliTel1.Text + "\n" +
            //    "Yetkili Tel2 : " + TB_YetkiliTel2.Text + "\n" +
            //    "Yetkili Mail : " + TB_YetkiliMail.Text + "\n" +
            //    "Yetkili Notlar: " + TB_YetkiliNot.Text + "\n" + "";
           

            //a = MessageBox.Show(mesaj, baslik, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            //if (a == DialogResult.OK)
            //{
                //    TB_MusteriBolum_No.Text = "01";
                //string mfirmaolustur = CLS.CreateCustomer.YeniMusteriOlustur(TB_MusteriFirma_Not.Text, TB_MusteriFirma_Adi.Text, CB_MusteriFirma_Bolge.Text, TB_MusteriFirma_Adres.Text, TB_MusteriFirma_MapsLink.Text, TB_MusteriFirma_Tel.Text);
                //string mfirmaBolumolustur = CLS.CreateDepartment.YeniMusteriBolumOlustur("", TB_MusteriFirma_No.Text, TB_MusteriFirma_Adi.Text, TB_MusteriBolum_No.Text, TB_MusteriBolum_Adi.Text);

                string[] ProjeVerileri = new string[21];



                //string YetkiliNot       = Crypto.Encrypt(.Text, "xxx");
                //string YetkiliAdSoyad   = Crypto.Encrypt(TB_YetkiliAdi.Text, "xxx");
                //string YetkiliUnvan     = Crypto.Encrypt(TB_YetkiliUnvan.Text, "xxx");
                //string YetkiliTel1      = Crypto.Encrypt(TB_YetkiliTel1.Text, "xxx");
                //string YetkiliTel2      = Crypto.Encrypt(TB_YetkiliTel2.Text, "xxx");
                //string YetkiliMail      = Crypto.Encrypt(TB_YetkiliMail.Text, "xxx");


                ProjeVerileri[0] = "";
                ProjeVerileri[1] = DateTime.Now.ToString();
                ProjeVerileri[2] = CLS.Form_Main.TB_User_UserAd.Text;
                ProjeVerileri[3] = TB_ProjeNot.Text;
                ProjeVerileri[4] = TB_MusteriFirma_No.Text;
                ProjeVerileri[5] = TB_MusteriFirma_Adi.Text;
                ProjeVerileri[6] = TB_BolumNo.Text;
                ProjeVerileri[7] = TB_BolumAdi.Text;
                ProjeVerileri[8] = TB_ProjeNo.Text;
                ProjeVerileri[9] = TB_ProjeKodu.Text;
                ProjeVerileri[10] = TB_ProjeAdi.Text;
                ProjeVerileri[11] = TB_ProjeBaslangicTarih.Text;
                ProjeVerileri[12] = TB_ProjeDonem.Text.Remove(2, 3);
                ProjeVerileri[13] = TB_ProjeDonem.Text.Remove(0, 3);
                ProjeVerileri[14] = TB_YetkiliNo.Text; 
                ProjeVerileri[15] = Crypto.Encrypt(TB_YetkiliAdi.Text, "xxx");
                ProjeVerileri[16] = Crypto.Encrypt(TB_YetkiliUnvan.Text, "xxx");
                ProjeVerileri[17] = Crypto.Encrypt(TB_YetkiliTel1.Text, "xxx");
                ProjeVerileri[18] = Crypto.Encrypt(TB_YetkiliTel2.Text, "xxx");
                ProjeVerileri[19] = Crypto.Encrypt(TB_YetkiliMail.Text, "xxx");
                ProjeVerileri[20] = Crypto.Encrypt("", "xxx");
                //ProjeVerileri[20] = TB_YetkiliMail.Text;
                //ProjeVerileri[21] = TB_YetkiliMail.Text;
                //ProjeVerileri[22] = TB_YetkiliMail.Text;
                //ProjeVerileri[23] = TB_YetkiliMail.Text;
                //ProjeVerileri[24] = TB_YetkiliMail.Text;
                //ProjeVerileri[25] = TB_YetkiliMail.Text;

                string ProjeOlustur = CLS.CreateProject.Proje_Olustur(ProjeVerileri);


                string KlasorOlustur = CLS.CreateFolder.Create_Yeni_Proje_Klasor(TB_MusteriFirma_No.Text, TB_MusteriFirma_Adi.Text, TB_ProjeKodu.Text);

                string baslik2 = "İşlem tamamlandı";
                string mesaj2 = "Yeni proje oluşturma işlemi " + ProjeOlustur + "\n Yeni Proje klasörü oluşturma işlemi " + KlasorOlustur;

                DialogResult islemOnay = new DialogResult();
                islemOnay = MessageBox.Show(mesaj2, baslik2, MessageBoxButtons.OK);

                if (islemOnay == DialogResult.OK)
                {
                    //Temizle();
                    this.Hide();
                }

           // }

        }


        private void Form_Yeni_Musteri_Load(object sender, EventArgs e)
        {
            
        }


        public void Temizle()
        {
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

        private void Form_Yeni_Proje_Shown(object sender, EventArgs e)
        {
            TB_MusteriFirma_No.Text     = CLS.Form_Main.CrtPrj_SecilenMusteriNo;
            TB_MusteriFirma_Adi.Text    = CLS.Form_Main.CrtPrj_SecilenMusteriAdi;
            TB_BolumNo.Text             = CLS.Form_Main.CrtPrj_SecilenBolumNo;
            TB_BolumAdi.Text            = CLS.Form_Main.CrtPrj_SecilenBolumAdi;

            TB_ProjeNo.Text             = CLS.Form_Main.TB_CrtPrj_ProjeNo.Text;
            TB_ProjeKodu.Text           = CLS.Form_Main.TB_CrtPrj_ProjeKodu.Text;
            TB_ProjeAdi.Text            = CLS.Form_Main.TB_CrtPrj_ProjeAdi.Text;
            TB_ProjeKodu.Text           = CLS.Form_Main.TB_CrtPrj_ProjeKodu.Text;
            TB_ProjeBaslangicTarih.Text = CLS.Form_Main.DTP_CrtPrj_ProjeBaslangic.Text;
            TB_ProjeDonem.Text          = CLS.Form_Main.DTP_CrtPrj_ProjeDonem.Text;
            TB_ProjeNot.Text            = CLS.Form_Main.RTB_CrtPrj_ProjeNot.Text;
            TB_YetkiliNo.Text           = CLS.Form_Main.TB_CrtPrj_YetkiliNo.Text;
            TB_YetkiliUnvan.Text        = CLS.Form_Main.TB_CrtPrj_YetkiliUnvan.Text;
            TB_YetkiliAdi.Text          = CLS.Form_Main.CB_CrtPrj_YetkiliSecim.Text;
            TB_YetkiliTel1.Text         = CLS.Form_Main.TB_CrtPrj_YetkiliTel1.Text;
            TB_YetkiliTel2.Text         = CLS.Form_Main.TB_CrtPrj_YetkiliTel2.Text;
            TB_YetkiliMail.Text         = CLS.Form_Main.TB_CrtPrj_YetkiliMail.Text;
        }




    }
}
