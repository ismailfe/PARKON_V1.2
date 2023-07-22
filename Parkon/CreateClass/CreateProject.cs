using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parkon
{
    public class CreateProject
    {
        public CLS CLS;


        public string FirstStart()
        {
            try
            {

                return "OK!";
            }
            catch (Exception HATA)
            {

                return "ERR! - " + HATA.ToString();
            }

        }



        #region SAYFA KONTROLLERI

        #region MÜŞTERİ SEÇİMİ
        #region MUSTERİ ADI İLE SEÇİM YAPMA
        public string Listele_MusteriAdi(ComboBox Liste)
        {
            try
            {
                ListBox LBox = new ListBox();
                CLS.ID_MySQL.READ_SelectColumn_FromMySQL(CLS.MySQLVar.TableName_DBMusteri, "MusteriAdi", LBox);
                Liste.Items.Clear();
                for (int i = 0; i < LBox.Items.Count; i++)
                {
                    Liste.Items.Add(LBox.Items[i]);
                }

                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }

        }

        public string MusteriAdiSecildi(int Index, out string MusteriNo, out string MusteriBolge, out string MusteriAdres, out string MapsLink, out string MusteriTel, out string notlar, out string INFO)
        {
            MusteriNo = "";
            MusteriBolge = "";
            MusteriAdres = "";
            MapsLink = "";
            MusteriTel = "";
            notlar = "";
            INFO = "";
            try
            {
                string[] RData = new string[10];
                if (Index >= 0)
                {
                    CLS.ID_MySQL.READ_SelectIndex_FromMySQLRow(CLS.MySQLVar.TableName_DBMusteri, CLS.MySQLVar.ColumnName_DBMusteri, RData, Index);
                }

                INFO = "ID:" + RData[0] + " Date:" + RData[1]  + " Creator:" + RData[2] + "\n" + "\n";
                notlar          = RData[3];
                MusteriNo       = RData[4].Trim();
                MusteriBolge    = RData[6];
                MusteriAdres    = RData[7];
                MapsLink        = RData[8];
                MusteriTel      = RData[9];
                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }
        }
        #endregion

        #region MÜŞTERİ NO İLE SEÇİM YAPMA

        public string Listele_MusteriNo(ComboBox Liste)
        {
            try
            {
                ListBox LBox = new ListBox();
                CLS.ID_MySQL.READ_SelectColumn_FromMySQL(CLS.MySQLVar.TableName_DBMusteri, "MusteriNo", LBox);
                Liste.Items.Clear();
                for (int i = 0; i < LBox.Items.Count; i++)
                {
                    Liste.Items.Add(LBox.Items[i]);
                }

                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }

        }
        public string MusteriNoSecildi(int Index, out string MusteriAdi)
        {
            MusteriAdi = "";
            try
            {
                string[] RData = new string[9];
                if (Index >= 0)
                {
                    CLS.ID_MySQL.READ_SelectIndex_FromMySQLRow(CLS.MySQLVar.TableName_DBMusteri, CLS.MySQLVar.ColumnName_DBMusteri, RData, Index);
                }


                MusteriAdi = RData[5];

                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }
        }


        #endregion

        #endregion

        #region BÖLÜM SEÇİMİ

        #region BÖLÜM ADI İLE SEÇİM YAPMA

        ListBox Lbox_BolumID    = new ListBox();
        ComboBox CBox_BolumID   = new ComboBox();
        public string Listele_BolumAdi(ComboBox Liste, string MusteriNo)
        {
            try
            {
                ListBox LBox = new ListBox();
                ListBox RefLBox = new ListBox();
                CLS.ID_MySQL.READ_SelectColumn_FromMySQL(CLS.MySQLVar.TableName_DBMusteriBolum, "BolumAdi", LBox);
                CLS.ID_MySQL.READ_SelectColumn_FromMySQL(CLS.MySQLVar.TableName_DBMusteriBolum, "MusteriNo", RefLBox);
                CLS.ID_MySQL.READ_SelectColumn_FromMySQL(CLS.MySQLVar.TableName_DBMusteriBolum, "ID", Lbox_BolumID);

                Liste.Items.Clear();
                CBox_BolumID.Items.Clear();
                for (int i = 0; i < LBox.Items.Count; i++)
                {
                 
                    if (RefLBox.Items[i].ToString() == MusteriNo.Trim())
                    {
                        Liste.Items.Add(LBox.Items[i]);
                        CBox_BolumID.Items.Add(Lbox_BolumID.Items[i]);
                    }
                   
                }

                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }

        }

        public string BolumAdiSecildi(int Index, out string BolumNo, out string BolumNot)
        {
            BolumNo = "";
            BolumNot = "";
            try
            {

                string[] RData = new string[9];

                  //  CLS.ID_MySQL.READ_SelectIndex_FromMySQLRow(CLS.MySQLVar.TableName_DBMusteriBolum, CLS.MySQLVar.ColumnName_DBMusteriBolum, RData, Index);
                    CLS.ID_MySQL.READ_SelectID_FromMySQLRow(CLS.MySQLVar.TableName_DBMusteriBolum, CLS.MySQLVar.ColumnName_DBMusteriBolum, RData, "ID", CBox_BolumID.Items[Index].ToString());
            


                BolumNo = RData[6];
                BolumNot = RData[3];

                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }
        }

        #endregion

        #region BÖLÜM NO İLE SEÇİM YAPMA
        public string Listele_BolumNo(ComboBox Liste, string MusteriNo)
        {
            try
            {
                ListBox LBox = new ListBox();
                ListBox RefLBox = new ListBox();
                CLS.ID_MySQL.READ_SelectColumn_FromMySQL(CLS.MySQLVar.TableName_DBMusteriBolum, "BolumNo", LBox);
                CLS.ID_MySQL.READ_SelectColumn_FromMySQL(CLS.MySQLVar.TableName_DBMusteriBolum, "MusteriNo", RefLBox);

                Liste.Items.Clear();
                for (int i = 0; i < LBox.Items.Count; i++)
                {

                    if (RefLBox.Items[i].ToString() == MusteriNo.Trim())
                    {
                        Liste.Items.Add(LBox.Items[i]);
                    }

                }

                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }

        }

        public string BolumNoSecildi(int Index, out string BolumAdi)
        {
            BolumAdi = "";
            try
            {
                string[] RData = new string[9];
                if (Index >= 0)
                {
                    CLS.ID_MySQL.READ_SelectIndex_FromMySQLRow(CLS.MySQLVar.TableName_DBMusteriBolum, CLS.MySQLVar.ColumnName_DBMusteriBolum, RData, Index);
                }


                BolumAdi = RData[7];

                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }
        }

        #endregion

        #endregion

        #region PROJE SEÇİMİ

        #region YENİ PROJE
           public string ProjeNoOlusturma(string MusteriNo, string BolumNo, string DonemYili, out string ProjeNo, out string ProjeKodu)
                {
                    ProjeNo = "";
                    ProjeKodu = "";
                    string ProjeNo1 = "";
                    string ProjeNo2 = "";
                    try
                    {
                        string[] RefColumnName = new string[3];
                        string[] RefValue = new string[3];

                        RefColumnName[0] = "MusteriNo";
                        RefColumnName[1] = "BolumNo";
                        RefColumnName[2] = "ProjeDonemYil";

                        RefValue[0] = MusteriNo;
                        RefValue[1] = BolumNo;
                        RefValue[2] = DonemYili.Remove(0, 2); // Panelde 01.18 şeklinde yazılıyor. Sadece yılı alıp Yıl sütunu içinde sorgualam yapılıyor.

                CLS.ID_MySQL.FindLastNumber(CLS.MySQLVar.TableName_DBProje, "ProjeNo", true, RefColumnName, RefValue, out string LastPrjNo);

                        if (LastPrjNo.Length < 2)
                        {
                            ProjeNo2 = "00" + LastPrjNo;
                        }
                        else if (LastPrjNo.Length == 2)
                        {
                            ProjeNo2 = "0" + LastPrjNo;
                        }

                        ProjeNo1 = "P" + MusteriNo + BolumNo + DonemYili.Remove(0,2) + ProjeNo2;

                        ProjeNo = ProjeNo2;     // Proje No
                        ProjeKodu = ProjeNo1;   // Proje Kodu

                        return "OK!";
                    }
                    catch (Exception HATA)
                    {
                        return "ERR! - " + HATA.ToString();
                    }



                }

        #endregion



        #endregion

        #region YETKİLİ SEÇİMİ
        ComboBox CBox_YetkiliID = new ComboBox();
        ListBox Lbox_YetkiliID = new ListBox();
        //ComboBox CBox_YetkiliID = new ComboBox();
        public string Listele_YetkiliAdi(ComboBox Liste, string MusteriNo)
        {
            try
            {
                ListBox LBoxAd = new ListBox();
                //ListBox LBoxSoyad = new ListBox();
                ListBox RefLBox = new ListBox();
                CLS.ID_MySQL.READ_SelectColumn_FromMySQL(CLS.MySQLVar.TableName_DBMYetkili, "MYetkiliAdi", LBoxAd);
                //CLS.ID_MySQL.READ_SelectColumn_FromMySQL(CLS.MySQLVar.TableName_DBMYetkili, "MYetkiliSoyadi", LBoxSoyad);
                CLS.ID_MySQL.READ_SelectColumn_FromMySQL(CLS.MySQLVar.TableName_DBMYetkili, "MusteriNo", RefLBox);
                CLS.ID_MySQL.READ_SelectColumn_FromMySQL(CLS.MySQLVar.TableName_DBMYetkili, "ID", Lbox_BolumID);

                Liste.Items.Clear();
                CBox_YetkiliID.Items.Clear();
                for (int i = 0; i < LBoxAd.Items.Count; i++)
                {

                    if (RefLBox.Items[i].ToString() == MusteriNo.Trim())
                    {
                        string txtOpn = LBoxAd.Items[i].ToString();
                        string txt = Crypto.Decrypt(txtOpn, "xxx");
                        Liste.Items.Add(txt);
                        CBox_YetkiliID.Items.Add(Lbox_BolumID.Items[i]);
                    }

                }

                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }

        }

        public string YetkiliAdiSecildi(int Index, out string YetkiliNot, out string YetkiliNo, out string YetkiliTitle, out string YetkiliTel1, out string YetkiliTel2, out string YetkiliMail, out string YetkiliInfo)
        {
            YetkiliNot = "";
            YetkiliNo = "";
            YetkiliTitle = "";
            YetkiliTel1 = "";
            YetkiliTel2 = "";
            YetkiliMail = "";
            YetkiliInfo = "";
        

            try
            {

                string[] RData = new string[14];

                //  CLS.ID_MySQL.READ_SelectIndex_FromMySQLRow(CLS.MySQLVar.TableName_DBMusteriBolum, CLS.MySQLVar.ColumnName_DBMusteriBolum, RData, Index);
                CLS.ID_MySQL.READ_SelectID_FromMySQLRow(CLS.MySQLVar.TableName_DBMYetkili, CLS.MySQLVar.ColumnName_DBMYetkili, RData, "ID", CBox_YetkiliID.Items[Index].ToString());


                YetkiliNot = RData[3];
                YetkiliNo = RData[6];
                YetkiliTitle = RData[8];
                YetkiliTel1 = RData[9];
                YetkiliTel2 = RData[10];
                YetkiliMail = RData[11];
                YetkiliInfo = RData[12];


                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }
        }



        #endregion

        #region PROJE OLUŞTUR

        public string Proje_Olustur(string[] ProjeVerileri)
        {
            try
            {
               string Cmd = CLS.ID_MySQL.WRITE_ToSQLRow(CLS.MySQLVar.TableName_DBProje, CLS.MySQLVar.ColumnName_DBProje, ProjeVerileri, 0);

                return "OK! - " + Cmd;
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }
        }


        #endregion

        #region REVIZYON OLUŞTUR

        ListBox Lbox_RevID = new ListBox();
        ComboBox CBox_RevID = new ComboBox();
        public string Listele_RevIcinProjeler(ComboBox Liste, string MusteriNo, string BolumNo)
        {
            try
            {
                ListBox LBox = new ListBox();
                ListBox RefLBox = new ListBox();
                ListBox Ref2LBox = new ListBox();
                CLS.ID_MySQL.READ_SelectColumn_FromMySQL(CLS.MySQLVar.TableName_DBProje, "ProjeAdi",    LBox);
                CLS.ID_MySQL.READ_SelectColumn_FromMySQL(CLS.MySQLVar.TableName_DBProje, "MusteriNo",   RefLBox);
                CLS.ID_MySQL.READ_SelectColumn_FromMySQL(CLS.MySQLVar.TableName_DBProje, "BolumNo",     Ref2LBox);
                CLS.ID_MySQL.READ_SelectColumn_FromMySQL(CLS.MySQLVar.TableName_DBProje, "ID",          Lbox_BolumID);

                Liste.Items.Clear();
                CBox_RevID.Items.Clear();
                for (int i = 0; i < LBox.Items.Count; i++)
                {
                    if (RefLBox.Items[i].ToString() == MusteriNo.Trim() && Ref2LBox.Items[i].ToString() == BolumNo.Trim())
                    {
                        Liste.Items.Add(LBox.Items[i]);
                        CBox_RevID.Items.Add(Lbox_BolumID.Items[i]);
                    }
                }

                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }

        }

        public string RevIcinProjeSecildi(int Index, out string ProjeNo, out string ProjeKodu, out string ProjeBasTarih, out string ProjeDonem, out string ProjeNot)
        {
            ProjeNo         = "";
            ProjeKodu       = "";
            ProjeBasTarih   = "";
            ProjeDonem      = "";
            ProjeNot        = "";
            try
            {

                string[] RData = new string[26];

                //  CLS.ID_MySQL.READ_SelectIndex_FromMySQLRow(CLS.MySQLVar.TableName_DBMusteriBolum, CLS.MySQLVar.ColumnName_DBMusteriBolum, RData, Index);
                CLS.ID_MySQL.READ_SelectID_FromMySQLRow(CLS.MySQLVar.TableName_DBProje, CLS.MySQLVar.ColumnName_DBProje, RData, "ID", CBox_RevID.Items[Index].ToString());



                ProjeNo             = RData[8];
                ProjeKodu           = RData[9];
                ProjeBasTarih       = RData[11];
                ProjeDonem          = RData[12] + "." + RData[13];
                ProjeNot            = RData[3];
                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }
        }

        public string RevNoOlusturma(string MusteriNo, string BolumNo, string ProjeNo, out string RevNo)
        {
            RevNo = "";

            string RevNo2 = "";
            try
            {
                string[] RefColumnName = new string[3];
                string[] RefValue = new string[3];

                RefColumnName[0] = "MusteriNo";
                RefColumnName[1] = "BolumNo";
                RefColumnName[2] = "ProjeNo";

                RefValue[0] = MusteriNo;
                RefValue[1] = BolumNo;
                RefValue[2] = ProjeNo; 

                CLS.ID_MySQL.FindLastNumber(CLS.MySQLVar.TableName_DBRev, "RevNo", true, RefColumnName, RefValue, out string LastPrjNo);

                if (LastPrjNo.Length < 2)
                {
                    RevNo2 = "0" + LastPrjNo;
                }
                else 
                {
                    RevNo2 = LastPrjNo;
                }

                RevNo = RevNo2;

                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }



        }

        public string Revizyon_Olustur(string[] ProjeVerileri)
        {
            try
            {
                string Cmd = CLS.ID_MySQL.WRITE_ToSQLRow(CLS.MySQLVar.TableName_DBRev, CLS.MySQLVar.ColumnName_DBRev, ProjeVerileri, 0);

                return "OK! - " + Cmd;
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }
        }


        #endregion


        #region TEMİZLEME FONKSİYONLARI

        public void Temizle_Musteri()
        {
            CLS.Form_Main.TB_CrtPrj_MusteriSecim_Ad.Text = "";
            CLS.Form_Main.TB_CrtPrj_MusteriSecim_No.Text = "";
            CLS.Form_Main.CrtPrj_SecilenMusteriNo = "";
            CLS.Form_Main.CrtPrj_SecilenMusteriAdi = "";

            CLS.Form_Main.TB_CrtPrj_MusteriSecim_No.Text = "";
            CLS.Form_Main.TB_CrtPrj_MusteriBolge.Text = "";
            CLS.Form_Main.TB_CrtPrj_MusteriAdres.Text = "";
            CLS.Form_Main.TB_CrtPrj_MusteriMapsLink.Text = "";
            CLS.Form_Main.TB_CrtPrj_MusteriTel.Text = "";
            CLS.Form_Main.RTB_CrtPrj_MusteriNot.Text = "";
            CLS.Form_Main.CB_CrtPrj_MusteriSecim_Ad.Text = "";
            CLS.Form_Main.CB_CrtPrj_MusteriSecim_Ad.Items.Clear();
            CLS.Form_Main.CB_CrtPrj_MusteriSecim_No.Text = "";
            CLS.Form_Main.CB_CrtPrj_MusteriSecim_No.Items.Clear();

            CLS.Form_Main.LB_CrtPtj_MusteriFirmaSecimiOK.Text = " -";
            CLS.Form_Main.LB_CrtPtj_MusteriFirmaSecimiOK.BackColor = Color.Transparent;
        }

        public void Temizle_MusteriBolum()
        {
            CLS.Form_Main.CB_CrtPrj_BolumSecim_Ad.Text = "";
            CLS.Form_Main.CB_CrtPrj_BolumSecim_Ad.Items.Clear();
            CLS.Form_Main.TB_CrtPrj_BolumSecim_No.Text = "";

            CLS.Form_Main.RTB_CrtPrj_BolumNot.Text = "";
            CLS.Form_Main.TB_CrtPrj_BolumSecim_Ad.Text = "";
            CLS.Form_Main.CB_CrtPrj_BolumSecim_No.Text = "";
            CLS.Form_Main.CB_CrtPrj_BolumSecim_No.Items.Clear();

            CLS.Form_Main.CrtPrj_SecilenBolumNo = "";
            CLS.Form_Main.CrtPrj_SecilenBolumAdi = "";

            CLS.Form_Main.LB_CrtPtj_BolumSecimiOK.Text = " -";
            CLS.Form_Main.LB_CrtPtj_BolumSecimiOK.BackColor = Color.Transparent;
        }

        public void Temizle_ProjeBilgileri()
        {
            CLS.Form_Main.TB_CrtPrj_ProjeAdi.Text = "";
            CLS.Form_Main.TB_CrtPrj_ProjeNo.Text = "";
            CLS.Form_Main.TB_CrtPrj_ProjeKodu.Text = "";
            CLS.Form_Main.DTP_CrtPrj_ProjeDonem.Text = "";
            CLS.Form_Main.TB_CrtPrj_RevAdi.Text = "";
            CLS.Form_Main.TB_CrtPrj_RevNo.Text = "";
            CLS.Form_Main.CB_CrtPrj_Secim_ProjeAdi.Text = "";
            CLS.Form_Main.CB_CrtPrj_Secim_ProjeAdi.Items.Clear();
            CLS.Form_Main.RTB_CrtPrj_ProjeNot.ReadOnly = true;
            CLS.Form_Main.RTB_CrtPrj_ProjeNot.Text = "";
            CLS.Form_Main.RTB_CrtPrj_ProjeNot.BackColor = SystemColors.Control;



            CLS.Form_Main.LB_CrtPtj_ProjeBilgileriOK.Text = " -";
            CLS.Form_Main.LB_CrtPtj_ProjeBilgileriOK.BackColor = Color.Transparent;
        }

        public void Temizle_YetkiliKisi()
        {
            CLS.Form_Main.TB_CrtPrj_YetkiliNo.Text = "";
            CLS.Form_Main.TB_CrtPrj_YetkiliUnvan.Text = "";
            CLS.Form_Main.TB_CrtPrj_YetkiliMail.Text = "";
            CLS.Form_Main.TB_CrtPrj_YetkiliTel1.Text = "";

            CLS.Form_Main.TB_CrtPrj_YetkiliTel2.Text = "";
            CLS.Form_Main.RTB_CrtPrj_YetkiliNot.Text = "";
            CLS.Form_Main.CB_CrtPrj_YetkiliSecim.Text = "";
            CLS.Form_Main.CB_CrtPrj_YetkiliSecim.Items.Clear();

            CLS.Form_Main.LB_CrtPtj_YetkiliOK.Text = " -";
            CLS.Form_Main.LB_CrtPtj_YetkiliOK.BackColor = Color.Transparent;
        }

        #endregion



        #endregion

    }
}
