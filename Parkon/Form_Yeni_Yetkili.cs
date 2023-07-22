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
    public partial class Form_Yeni_Yetkili : Form
    {

        #region PUBLIC_VARIABLE
        public CLS CLS;
        #endregion



        public Form_Yeni_Yetkili()
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
           
            MUSTERI_OLUSTUR_ON_KONTROL();
        }

        public void MUSTERI_OLUSTUR_ON_KONTROL()
        {
            string Baslik = "Hata";
            if (CB_MusteriFirma_Adi.Text != "")
            {
                if (TB_YetkiliAd.Text != "")
                {
                    if (TB_YetkiliSoyad.Text != "")
                    {
                        if (TB_YetkiliUnvan.Text != "")
                        {
                            if (TB_YetkiliTel1.Text != "" || TB_YetkiliTel1.Text != "")
                            {
                                if (TB_YetkiliMail.Text != "")
                                {
                                    if (TB_YetkiliNo.Text != "")
                                    {
                                        MUSTERI_OLUSTUR();
                                    }
                                    else { MessageBox.Show("Yetkili No getirmedi!", Baslik); }
                                } else {  MessageBox.Show("Yetkili mail adresi girilmedi!", Baslik); }
                            } else { MessageBox.Show("Yetkili mail adresi girilmedi!", Baslik); }
                        }else { MessageBox.Show("Yetkili ünvanı girilmedi!", Baslik); }
                    }else { MessageBox.Show("Yetkili Kişi soyadı Girilmedi!", Baslik); }
                }else { MessageBox.Show("Yetkili adı Girilmedi!", Baslik); }
            } else {  MessageBox.Show("Müşteri firma seçilmedi!", Baslik); }

        }

        public void MUSTERI_OLUSTUR()
        {
            DialogResult a = new DialogResult();
            string baslik = "Yeni Müşteri Ekle - Onay";
            string mesaj = "Aşağıdaki bilgilere göre yeni bir yetkili eklemeyi kabul ediyor musunuz?" + "\n" + "\n" +
                "Müşteri firma no: " + TB_MusteriFirma_No.Text + "\n" +
                "Müşteri firma adı: " + CB_MusteriFirma_Adi.Text + "\n" + "\n" +

                "Yetkili Ad: " + TB_YetkiliAd.Text + "\n" +
                "Yetkili Soyad: " + TB_YetkiliSoyad.Text + "\n" +
                "Yetkili Ünvan: " + TB_YetkiliUnvan.Text + "\n" +
                "Yetkili Tel1 : " + TB_YetkiliTel1.Text + "\n" +
                "Yetkili Tel2 : " + TB_YetkiliTel2.Text + "\n" +
                "Yetkili Mail : " + TB_YetkiliMail.Text + "\n" +
                "Yetkili Notlar: " + TB_YetkiliNot.Text + "\n" + "";
           

            a = MessageBox.Show(mesaj, baslik, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (a == DialogResult.OK)
            {
                //    TB_MusteriBolum_No.Text = "01";
                //string mfirmaolustur = CLS.CreateCustomer.YeniMusteriOlustur(TB_MusteriFirma_Not.Text, TB_MusteriFirma_Adi.Text, CB_MusteriFirma_Bolge.Text, TB_MusteriFirma_Adres.Text, TB_MusteriFirma_MapsLink.Text, TB_MusteriFirma_Tel.Text);
                //string mfirmaBolumolustur = CLS.CreateDepartment.YeniMusteriBolumOlustur("", TB_MusteriFirma_No.Text, TB_MusteriFirma_Adi.Text, TB_MusteriBolum_No.Text, TB_MusteriBolum_Adi.Text);


                string YetkiliNot       = Crypto.Encrypt(TB_YetkiliNot.Text, "xxx");
                string YetkiliAdSoyad   = Crypto.Encrypt(TB_YetkiliAd.Text + " " + TB_YetkiliSoyad.Text, "xxx");
                string YetkiliUnvan     = Crypto.Encrypt(TB_YetkiliUnvan.Text, "xxx");
                string YetkiliTel1      = Crypto.Encrypt(TB_YetkiliTel1.Text, "xxx");
                string YetkiliTel2      = Crypto.Encrypt(TB_YetkiliTel2.Text, "xxx");
                string YetkiliMail      = Crypto.Encrypt(TB_YetkiliMail.Text, "xxx");

                string YetkiliOlustur = CLS.CreateAuthorized.YeniYetkiliOlustur(
                    YetkiliNot, 
                    TB_MusteriFirma_No.Text, 
                    CB_MusteriFirma_Adi.Text, 
                    YetkiliAdSoyad,
                    YetkiliUnvan,
                    YetkiliTel1,
                    YetkiliTel2,
                    YetkiliMail, "");


                string baslik2 = "İşlem tamamlandı";
                string mesaj2 = "Yeni Müşteri firma oluşturma işlemi " + YetkiliOlustur; 
                    
                DialogResult islemOnay = new DialogResult();
                islemOnay = MessageBox.Show(mesaj2, baslik2, MessageBoxButtons.OK);

                if (islemOnay == DialogResult.OK)
                {
                    Temizle();
                    this.Hide();
                }

            }

        }



        #region MÜŞTERİ FİRMA SEÇİMİ
        private void CB_MusteriFirma_Adi_MouseDown(object sender, MouseEventArgs e)
        {
            CLS.CreateProject.Listele_MusteriAdi(CB_MusteriFirma_Adi);
        }

        private void CB_MusteriFirma_Adi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Temizle();
            CLS.CreateProject.MusteriAdiSecildi(CB_MusteriFirma_Adi.SelectedIndex, out string MusteriNo, out string MBolge, out string MAdres, out string MMapslink, out string MTel, out string Mnot, out string INFO);

            //TB_CrtPrj_MusteriSecim_No.Text = MusteriNo;
            //TB_CrtPrj_MusteriBolge.Text = MBolge;
            //TB_CrtPrj_MusteriAdres.Text = MAdres;
            //TB_CrtPrj_MusteriMapsLink.Text = MMapslink;
            //TB_CrtPrj_MusteriTel.Text = MTel;
            //RTB_CrtPrj_MusteriNot.Text = Mnot;

            TB_MusteriFirma_No.Text = MusteriNo;
         
        }
        #endregion


        private void Form_Yeni_Musteri_Load(object sender, EventArgs e)
        {

        }


        public void Temizle()
        {
            TB_MusteriFirma_No.Text = "";
            CB_MusteriFirma_Adi.Text = "";

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

        private void YetkiliNO_Sorgula(object sender, CancelEventArgs e)
        {
            if (TB_YetkiliAd.Text != "" && TB_YetkiliSoyad.Text != "")
            {
                CLS.CreateAuthorized.YetkikiNoSorgula(TB_MusteriFirma_No.Text, out string YetkiliNo);
                TB_YetkiliNo.Text = YetkiliNo;
            }
           
        }
    }
}
