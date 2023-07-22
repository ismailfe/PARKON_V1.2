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
    public partial class Form_Yeni_User : Form
    {

        #region PUBLIC_VARIABLE
        public CLS CLS;
        #endregion



        public Form_Yeni_User()
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
           
           OLUSTUR_ON_KONTROL();
        }

        public void OLUSTUR_ON_KONTROL()
        {
            string Baslik = "Hata";
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
            //                        if (TB_YetkiliNo.Text != "")
            //                        {
            OLUSTUR();
            //                        }
            //                        else { MessageBox.Show("Yetkili No getirmedi!", Baslik); }
            //                    } else {  MessageBox.Show("Yetkili mail adresi girilmedi!", Baslik); }
            //                } else { MessageBox.Show("Yetkili mail adresi girilmedi!", Baslik); }
            //            }else { MessageBox.Show("Yetkili ünvanı girilmedi!", Baslik); }
            //        }else { MessageBox.Show("Yetkili Kişi soyadı Girilmedi!", Baslik); }
            //    }else { MessageBox.Show("Yetkili adı Girilmedi!", Baslik); }
            //} else {  MessageBox.Show("Müşteri firma seçilmedi!", Baslik); }

        }

        public void OLUSTUR()
        {
            DialogResult a = new DialogResult();
            string baslik = "Yeni Kullanıcı Ekle - Onay";
            string mesaj = "Aşağıdaki bilgilere göre yeni bir kullanıcı eklemeyi kabul ediyor musunuz?" + "\n" + "\n" +
                "Kullanıcı Adı: " + TB_Kullanici_Adi.Text + "\n" +
                "Kullanıcı Şifre: " + TB_Kullanici_Pass.Text + "\n" + "\n" +
                "Kullanıcı Yetki Seviyesi: " + CB_KullaniciSeviye.Text + "\n" +
                "Ad Soyad: " + TB_KullaniciAd.Text + " " + TB_KullaniciSoyad.Text + "\n" +
                "Bağlı Bölüm : " + CB_KullaniciBolum.Text + "\n" +
                "Ünvan: " + TB_KullaniciUnvan.Text + "\n" +
                "Telefon 1: " + TB_KullaniciTel1.Text + "\n" +
                "Telefon 2: " + TB_KullaniciTel2.Text + "\n" +
                "Mail Adresi: " + TB_KullaniciMail.Text + "\n" +
                "Doğum Tarihi: " + DTP_KullaniciDogumTarih.Text + "\n" +
                "Kan Gurubu: " + CB_KullaniciKan.Text + "\n" +
                "Kullanıcı Notu: " + TB_KullaniciNot.Text + "\n" + "";


            a = MessageBox.Show(mesaj, baslik, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (a == DialogResult.OK)
            {
                //    //    TB_MusteriBolum_No.Text = "01";
                //                string KullaniciOlustur = CLS.CreateCustomer.YeniMusteriOlustur(TB_MusteriFirma_Not.Text, TB_MusteriFirma_Adi.Text, CB_MusteriFirma_Bolge.Text, TB_MusteriFirma_Adres.Text, TB_MusteriFirma_MapsLink.Text, TB_MusteriFirma_Tel.Text);

                string not = TB_KullaniciNot.Text;
                string name = Crypto.Encrypt(TB_Kullanici_Adi.Text, "xxx");  
                string pass = Crypto.Encrypt(TB_Kullanici_Pass.Text, "xxx"); 
                string level = CB_KullaniciSeviye.Text;
                string ad =  TB_KullaniciAd.Text + " " + TB_KullaniciSoyad.Text;
                string unvan = Crypto.Encrypt(TB_KullaniciUnvan.Text, "xxx"); 
                string bolum = Crypto.Encrypt(CB_KullaniciBolum.Text, "xxx"); 
                string tel = Crypto.Encrypt(TB_KullaniciTel1.Text, "xxx"); 
                string tel2 = Crypto.Encrypt(TB_KullaniciTel2.Text, "xxx"); 
                string mail = Crypto.Encrypt(TB_KullaniciMail.Text, "xxx");
                string dtarih = Crypto.Encrypt(DTP_KullaniciDogumTarih.Text, "xxx"); 
                string kan = CB_KullaniciKan.Text;



                string KullaniciOlustur = CLS.UserLogin.YeniKullaniciOlustur(not, name, pass, level, ad, unvan, bolum, tel, tel2, mail, dtarih, kan);
                string KullaniciPicEkle = CLS.ID_MySQL.WRITE_ImageToMySQL(CLS.MySQLVar.TableName_DBUser, "UserPic", Pic_User_UserPic, "UserNo" , TB_KullaniciNo.Text);
                //    string YetkiliNot       = Crypto.Encrypt(TB_YetkiliNot.Text, "xxx");
                //    string YetkiliAdSoyad   = Crypto.Encrypt(TB_YetkiliAd.Text + " " + TB_YetkiliSoyad.Text, "xxx");
                //    string YetkiliUnvan     = Crypto.Encrypt(TB_YetkiliUnvan.Text, "xxx");
                //    string YetkiliTel1      = Crypto.Encrypt(TB_YetkiliTel1.Text, "xxx");
                //    string YetkiliTel2      = Crypto.Encrypt(TB_YetkiliTel2.Text, "xxx");
                //    string YetkiliMail      = Crypto.Encrypt(TB_YetkiliMail.Text, "xxx");

                //    string YetkiliOlustur = CLS.CreateAuthorized.YeniYetkiliOlustur(
                //        YetkiliNot, 
                //        TB_MusteriFirma_No.Text, 
                //        CB_MusteriFirma_Adi.Text, 
                //        YetkiliAdSoyad,
                //        YetkiliUnvan,
                //        YetkiliTel1,
                //        YetkiliTel2,
                //        YetkiliMail, "");


                    string baslik2 = "İşlem tamamlandı";
                    string mesaj2 = "Yeni kullanıcı oluşturma işlemi " + KullaniciOlustur + " " + KullaniciPicEkle; 

                    DialogResult islemOnay = new DialogResult();
                    islemOnay = MessageBox.Show(mesaj2, baslik2, MessageBoxButtons.OK);

                if (islemOnay == DialogResult.OK)
                {
                    Temizle();
                    this.Hide();
                }
            }

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

        private void B_KullaniciFotoSec_Click(object sender, EventArgs e)
        {
            FileStream fs;
            BinaryReader br;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;...";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(openFileDialog1.FileName);
                long fileSize = fi.Length; //The size of the current file in bytes.file 

                if (fileSize > 65535)
                {
                    MessageBox.Show("Seçtiğiniz image boyutu 64Kb üzerinde görünüyor. Lütfen 64Kb altında bir image seçin.", "HATA");
                }
                else
                {
                    //textBox1.Text = openFileDialog1.FileName;

                    Pic_User_UserPic.Image = Image.FromFile(openFileDialog1.FileName);
                }


            }
        }

        private void TB_Kullanici_Adi_Validating(object sender, CancelEventArgs e)
        {
            if(TB_Kullanici_Adi.Text != "" && TB_Kullanici_Pass.Text != "")
            {
                CLS.UserLogin.KullaniciNoSorgula(out string UserNo);
                TB_KullaniciNo.Text = UserNo;
            }
            
        }
    }
}
