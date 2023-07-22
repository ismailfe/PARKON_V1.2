using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parkon
{
    public class UserLogin
    {
        public CLS CLS;
        public bool KullaniciGirisBasarili;
        public bool KullaniciCikisBasarili;
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


        ComboBox CBSecilenUserID = new ComboBox();
       // ListBox LBox_SecilenUserID = new ListBox();
        public string Listele_UserName(ComboBox Liste)
        {
            try
            {
                ListBox LBox = new ListBox();
                ListBox LBoxID = new ListBox();
                CLS.ID_MySQL.READ_SelectColumn_FromMySQL(CLS.MySQLVar.TableName_DBUser, "UserName", LBox);
                CLS.ID_MySQL.READ_SelectColumn_FromMySQL(CLS.MySQLVar.TableName_DBUser, "ID", LBoxID);
                Liste.Items.Clear();

                for (int i = 0; i < LBox.Items.Count; i++)
                {
                    string txtOpn = LBox.Items[i].ToString();
                    string txt = Crypto.Decrypt(txtOpn, "xxx");
                    Liste.Items.Add(txt);
                    CBSecilenUserID.Items.Add(LBoxID.Items[i].ToString());


                }

                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }

        }


        public string KullaniciNoSorgula(out string SiradakiKullaniciNo)
        {
            SiradakiKullaniciNo = "";
            try
            {
                string[] refColumnName = new string[1];
                string[] refValue = new string[1];

                refColumnName[0] = "";
                refValue[0] = "";

                CLS.ID_MySQL.FindLastNumber(CLS.MySQLVar.TableName_DBUser, "UserNo", false, refColumnName, refValue, out string LastNumber);

                if (LastNumber.Length < 2)
                {
                    SiradakiKullaniciNo = "0" + LastNumber;
                }else
                {
                    SiradakiKullaniciNo = LastNumber;
                }


                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }

        }


        public string YeniKullaniciOlustur(string UsrNot, string UsrName,string UsrPass, string UsrLevel, string UsrAd, string UsrTitle, 
                                           string UsrBolum, string UsrTel, string UsrTel2, string UsrMail, string UsrDTarih, string UsrKan)
        {

            try
            {
                string UserNo = "";
                string[] WriteData = new string[17];

                string[] refColumnName = new string[1];
                string[] refValue = new string[1];

                CLS.ID_MySQL.FindLastNumber(CLS.MySQLVar.TableName_DBUser, "UserNo", false, refColumnName, refValue, out string LastNumber);

                if (LastNumber.Length < 2)
                {
                    UserNo = "0" + LastNumber;
                }
                else
                {
                    UserNo = LastNumber;
                }





                WriteData[0]    = ""; // ID Primary Key
                WriteData[1]    = DateTime.Now.ToString();
                WriteData[2]    = "ISMAIL DEMİR";
                WriteData[3]    = UsrNot;
                WriteData[4]    = UserNo;
                WriteData[5]    = "";
                WriteData[6]    = UsrName;
                WriteData[7]    = UsrPass;
                WriteData[8]    = UsrLevel;
                WriteData[9]    = UsrAd;
                WriteData[10]   = UsrTitle;
                WriteData[11]   = UsrBolum; 
                WriteData[12]   = UsrTel;
                WriteData[13]   = UsrTel2;
                WriteData[14]   = UsrMail;
                WriteData[15]   = UsrDTarih;
                WriteData[16]   = UsrKan;
           


                CLS.ID_MySQL.WRITE_ToSQLRow(CLS.MySQLVar.TableName_DBUser, CLS.MySQLVar.ColumnName_DBUser, WriteData, 0);

                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }
        }

        public string SifreKarsilastir(int KullaniciAdiIndex, string Pass, string[] KullaniciBilgileri, PictureBox UserPic)
        {
      
            try
            {
                string[] RData = new string[17];

                if (KullaniciAdiIndex >= 0)
                {
                    CLS.ID_MySQL.READ_SelectIndex_FromMySQLRow(CLS.MySQLVar.TableName_DBUser, CLS.MySQLVar.ColumnName_DBUser, RData, KullaniciAdiIndex);
                }

                string SecilenKullaniciSifre = Crypto.Decrypt(RData[7].ToString(), "xxx"); 

                if (SecilenKullaniciSifre == Pass)
                {

                    KullaniciGirisBasarili = true;
                  //  KullaniciBilgileri;// = new string[17];

                    KullaniciBilgileri[0] = RData[0];
                    KullaniciBilgileri[1] = RData[1];
                    KullaniciBilgileri[2] = RData[2];
                    KullaniciBilgileri[3] = RData[3];
                    KullaniciBilgileri[4] = RData[4];
                    KullaniciBilgileri[5] = RData[5];
                    KullaniciBilgileri[6] = Crypto.Decrypt(RData[6].ToString(), "xxx"); 
                    KullaniciBilgileri[7] = Crypto.Decrypt(RData[7].ToString(), "xxx");    
                    KullaniciBilgileri[8] = RData[8];
                    KullaniciBilgileri[9] = RData[9];
                    KullaniciBilgileri[10] = Crypto.Decrypt(RData[10].ToString(), "xxx"); 
                    KullaniciBilgileri[11] = Crypto.Decrypt(RData[11].ToString(), "xxx"); 
                    KullaniciBilgileri[12] = Crypto.Decrypt(RData[12].ToString(), "xxx"); 
                    KullaniciBilgileri[13] = Crypto.Decrypt(RData[13].ToString(), "xxx"); 
                    KullaniciBilgileri[14] = Crypto.Decrypt(RData[14].ToString(), "xxx"); 
                    KullaniciBilgileri[15] = Crypto.Decrypt(RData[15].ToString(), "xxx"); 
                    KullaniciBilgileri[16] = RData[16];



                    CLS.ID_MySQL.READ_ImageFormMySQL(CLS.MySQLVar.TableName_DBUser, "UserPic", UserPic, "ID", RData[0].ToString());
                    //byte img = (byte)RData[5].ToString();
                    //MemoryStream ms = new MemoryStream(img);
                    //pictureBox1.Image = Image.FromStream(ms);
                }

                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }



        }

        public void KullaniciGiris()
        {
            string[] UsrInfo = new string[17];
            CLS.UserLogin.SifreKarsilastir(CLS.Form_Main.CB_User_SecUserName.SelectedIndex, CLS.Form_Main.TB_User_UserPass.Text, UsrInfo, CLS.Form_Main.Pic_User_UserPic);


            if (KullaniciGirisBasarili)
            {

                CLS.Form_Main.TB_User_UserAd.Text                   = UsrInfo[9];
                CLS.Form_Main.toolStrip_Kullanici.Text              = UsrInfo[9];
                CLS.Form_Main.TB_User_UserGorev.Text                = UsrInfo[11];
                CLS.Form_Main.TB_User_UserTitle.Text                = UsrInfo[10];

                CLS.Form_Main.TB_UserLoginStatus.Text               = "Giriş Başarılı!";

                CLS.Form_Main.TB_User_UserPass.Enabled              = false;
                CLS.Form_Main.CB_User_SecUserName.Enabled           = false;
                CLS.Form_Main.B_UserGiris.Visible                   = false;

                CLS.Form_Main.Pic_User_UserPic.Visible              = true;
                CLS.Form_Main.TB_Selam.Visible                      = true;
                CLS.Form_Main.Tab_User.Visible                      = true;

                CLS.Form_Main.TableLayout_ProjeOlusturma.Enabled    = true;
            }
            else
            {
                CLS.Form_Main.TB_UserLoginStatus.Text = "Hatalı şifre ya da kullanıcı adı!";
            }
        }



        public void KullaniciCikis()
        {
            CLS.Form_Main.TB_User_UserAd.Text               = "";
            CLS.Form_Main.toolStrip_Kullanici.Text          = "";
            CLS.Form_Main.TB_User_UserGorev.Text            = "";
            CLS.Form_Main.TB_User_UserTitle.Text            = "";
            CLS.Form_Main.TB_UserLoginStatus.Text           = "";

            CLS.Form_Main.TB_User_UserPass.Enabled          = true;
            CLS.Form_Main.CB_User_SecUserName.Enabled       = true;
            CLS.Form_Main.B_UserGiris.Visible               = true;


            CLS.Form_Main.Pic_User_UserPic.Visible          = false;
            CLS.Form_Main.TB_Selam.Visible                  = false;
            CLS.Form_Main.Tab_User.Visible                  = false;

            CLS.Form_Main.TableLayout_ProjeOlusturma.Enabled = false;
            KullaniciCikisBasarili = true;
            KullaniciGirisBasarili = false;

            CLS.CreateProject.Temizle_Musteri();
            CLS.CreateProject.Temizle_MusteriBolum();
            CLS.CreateProject.Temizle_ProjeBilgileri();
            CLS.CreateProject.Temizle_YetkiliKisi();

        }




    }
}
