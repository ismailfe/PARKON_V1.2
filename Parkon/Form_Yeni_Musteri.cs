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
    public partial class Form_Yeni_Musteri : Form
    {

        #region PUBLIC_VARIABLE
        public CLS CLS;
        #endregion



        public Form_Yeni_Musteri()
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
            if (TB_MusteriFirma_Adi.Text != "")
            {
                if (TB_MusteriFirma_No.Text != "")
                {
                    if (CB_MusteriFirma_Bolge.Text != "")
                    {
                        if (TB_MusteriFirma_Adres.Text != "")
                        {
                            if (TB_MusteriBolum_No.Text != "")
                            {
                                if (TB_MusteriBolum_Adi.Text != "")
                                {
                                    MUSTERI_OLUSTUR();
                                } else {  MessageBox.Show("Müşteri firma bölüm adı yazılmadı!", Baslik); }
                            } else { MessageBox.Show("Müşteri firma bölüm no oluşturulmadı!", Baslik); }
                        }else { MessageBox.Show("Müşteri firma adresi yazılmadı!", Baslik); }
                    }else { MessageBox.Show("Müşteri firma bölgesi seçilmedi!", Baslik); }
                }else { MessageBox.Show("Müşteri firma No oluşturulmadı!", Baslik); }
            } else {  MessageBox.Show("Müşteri firma adı girilmedi!", Baslik); }

        }

        public void MUSTERI_OLUSTUR()
        {
            DialogResult a = new DialogResult();
            string baslik = "Yeni Müşteri Ekle - Onay";
            string mesaj = "Aşağıdaki bilgilere göre yeni bir müşteri firma eklemeyi kabul ediyor musunuz?" + "\n" + "\n" +
                "Müşteri firma no: " + TB_MusteriFirma_No.Text + "\n" +
                "Müşteri firma adı: " + TB_MusteriFirma_Adi.Text + "\n" + "\n" +
                "Müşteri firma bölgesi: " + CB_MusteriFirma_Bolge.Text + "\n" +
                "Müşteri firma adresi: " + TB_MusteriFirma_Adres.Text + "\n" +
                "Müşteri firma maps link: " + TB_MusteriFirma_MapsLink.Text + "\n" +
                "Müşteri firma tel: " + TB_MusteriFirma_Tel.Text + "\n" +
                "Müşteri firma Notları: " + TB_MusteriFirma_Not.Text + "\n" + "\n" +
                "Müşteri firma bölüm no: " + TB_MusteriBolum_No.Text + "\n" +
                "Müşteri firma bölüm adi: " + TB_MusteriBolum_Adi.Text + "\n" + "";


            a = MessageBox.Show(mesaj, baslik, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (a == DialogResult.OK)
            {
                //    TB_MusteriBolum_No.Text = "01";
                string mfirmaolustur = CLS.CreateCustomer.YeniMusteriOlustur(TB_MusteriFirma_Not.Text, TB_MusteriFirma_Adi.Text, CB_MusteriFirma_Bolge.Text, TB_MusteriFirma_Adres.Text, TB_MusteriFirma_MapsLink.Text, TB_MusteriFirma_Tel.Text);
                string mfirmaBolumolustur = CLS.CreateDepartment.YeniMusteriBolumOlustur("", TB_MusteriFirma_No.Text, TB_MusteriFirma_Adi.Text, TB_MusteriBolum_No.Text, TB_MusteriBolum_Adi.Text);

                string baslik2 = "İşlem tamamlandı";
                string mesaj2 = "Yeni Müşteri firma oluşturma işlemi " + mfirmaolustur + "\n" + "\n" +
                                "Yeni Müşteri firma Bölümü oluşturma işlemi " + mfirmaBolumolustur;
                DialogResult islemOnay = new DialogResult();
                islemOnay = MessageBox.Show(mesaj2, baslik2, MessageBoxButtons.OK);

                if (islemOnay == DialogResult.OK)
                {
                    Temizle();
                    this.Hide();
                }

            }

        }
        


        public void CreateFolder()
        {
            //string MüsteriDizini = Form_Main.Anadizin + "/" + Tb_Yeni_Musteri_Adi.Text;

            //if (!Directory.Exists(MüsteriDizini))
            //{
            //    Directory.CreateDirectory(MüsteriDizini);
            //    Lb_Uyari.Text = "Oluşturulan Yeni Müşteri Firma Dizini: " + Form_Main.Anadizin + Tb_Yeni_Musteri_Adi.Text;
            //    this.Close();
            //}
            //else
            //{
            //    Lb_Uyari.Text = "Yazdığınız Müşteri Firma adı kullanılıyor. \nLütfen kontrol ederek tekrar deneyiniz.";
            //}


        }

        private void Form_Yeni_Musteri_Load(object sender, EventArgs e)
        {

        }


        public void Temizle()
        {
            TB_MusteriFirma_No.Text = "";
            TB_MusteriFirma_Adi.Text = "";
            CB_MusteriFirma_Bolge.Text = "";
            CB_MusteriFirma_Bolge.SelectedIndex = 0;
            TB_MusteriFirma_Adres.Text = "";
            TB_MusteriFirma_MapsLink.Text = "";
            TB_MusteriFirma_Tel.Text = "";
            TB_MusteriFirma_Not.Text = "";
            TB_MusteriBolum_No.Text = "";
            TB_MusteriBolum_Adi.Text = "";
            CHB_MuseriBolum_Adi_Degistir.Checked = false;
        }

        private void CHB_MuseriBolum_Adi_Degistir_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_MuseriBolum_Adi_Degistir.Checked)
            {
                TB_MusteriBolum_Adi.ReadOnly = false;

            }else
            {
                TB_MusteriBolum_Adi.ReadOnly = true;
            }
        }

        private void TB_MusteriBolum_Adi_TextChanged(object sender, EventArgs e)
        {
            if (TB_MusteriBolum_Adi.Text == "")
            {
                TB_MusteriBolum_Adi.Text = "MERKEZ";
            }
        }

        private void TB_MusteriFirma_Adi_Validating(object sender, CancelEventArgs e)
        {
            
            if (TB_MusteriFirma_Adi.Text != "")
            {
                CLS.CreateCustomer.MusteriNoSorgula(out string No);
                TB_MusteriFirma_No.Text = No;
                CLS.CreateDepartment.MusteriBolumNoSorgula(TB_MusteriFirma_No.Text, out string No2);
                TB_MusteriBolum_No.Text = No2;
            }
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
