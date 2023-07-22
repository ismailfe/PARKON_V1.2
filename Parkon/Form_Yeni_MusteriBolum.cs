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
    public partial class Form_Yeni_MusteriBolum : Form
    {

        #region PUBLIC_VARIABLE
        public CLS CLS;
        public Form_Main Form_Main;

        #endregion

        #region FORM NESNELERİ
        public Form_Yeni_MusteriBolum()
        {
            InitializeComponent();
        }
        private void Form_Yeni_Musteri_Load(object sender, EventArgs e)
        {
  
        }
        private void Form_Yeni_MusteriBolum_Shown(object sender, EventArgs e)
        {
            Temizle(true);
        }


        private void B_Iptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void B_OK_Click(object sender, EventArgs e)
        {
            CLS.CreateDepartment.MusteriBolumNoSorgula(TB_MusteriFirma_No.Text, out string BolumNo);
            CLS.CreateDepartment.YeniMusteriBolumOlustur(TB_MusteriBolum_Not.Text, TB_MusteriFirma_No.Text, CB_MusteriFirma_Adi.Text, BolumNo, TB_MusteriBolum_Adi.Text);

            TB_Durum.Text = DateTime.Now.ToString() + " - " + TB_MusteriFirma_No.Text.Trim() + " " + CB_MusteriFirma_Adi.Text + " adlı müşteri için " + 
                            BolumNo + " " + TB_MusteriBolum_Adi.Text + " bölümü oluşturuldu.";
        }

        #endregion


        #region MÜŞTERİ FİRMA SEÇİMİ
        private void CB_MusteriFirma_Adi_MouseDown(object sender, MouseEventArgs e)
        {
            CLS.CreateProject.Listele_MusteriAdi(CB_MusteriFirma_Adi);
        }

        private void CB_MusteriFirma_Adi_SelectedIndexChanged(object sender, EventArgs e)
        {

            CLS.CreateProject.MusteriAdiSecildi(CB_MusteriFirma_Adi.SelectedIndex, out string MusteriNo, out string MBolge, out string MAdres, out string MMapslink, out string MTel, out string Mnot, out string INFO);

            //TB_CrtPrj_MusteriSecim_No.Text = MusteriNo;
            //TB_CrtPrj_MusteriBolge.Text = MBolge;
            //TB_CrtPrj_MusteriAdres.Text = MAdres;
            //TB_CrtPrj_MusteriMapsLink.Text = MMapslink;
            //TB_CrtPrj_MusteriTel.Text = MTel;
            //RTB_CrtPrj_MusteriNot.Text = Mnot;

            TB_MusteriFirma_No.Text = MusteriNo;
            Temizle(false);
        }
        #endregion

        #region BÖLÜM BİLGİLERİ
        private void TB_Bolum_Adi_Validating(object sender, CancelEventArgs e)
        {
            CLS.CreateDepartment.MusteriBolumNoSorgula(TB_MusteriFirma_No.Text, out string No2);
            TB_MusteriBolum_No.Text = No2;
        }

        #endregion
        void Temizle(bool Hepsi)
        {
            if (Hepsi)
            {
                TB_MusteriBolum_Adi.Text = "";
                TB_MusteriBolum_No.Text = "";
                TB_MusteriBolum_Not.Text = "";
                CB_MusteriFirma_Adi.Text = "";
                TB_MusteriFirma_No.Text = "";
                TB_Durum.Text = "";
            }
            else
            {
                TB_MusteriBolum_Adi.Text = "";
                TB_MusteriBolum_No.Text = "";
                TB_MusteriBolum_Not.Text = "";
                TB_Durum.Text = "";
            }

        }

    
    }
}
