using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Parkon
{
   public class PrgSettings
    {
        public CLS CLS;


        public class INIKaydet
        {
            [DllImport("kernel32")]
            private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
            [DllImport("kernel32")]
            private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
            public INIKaydet(string dosyaYolu)
            {
                DOSYAYOLU = dosyaYolu;
            }
            private string DOSYAYOLU = String.Empty;
            public string Varsayilan { get; set; }
            public string Oku(string bolum, string ayaradi)
            {
                Varsayilan = Varsayilan ?? String.Empty;
                StringBuilder StrBuild = new StringBuilder(256);
                GetPrivateProfileString(bolum, ayaradi, Varsayilan, StrBuild, 512, DOSYAYOLU);
                return StrBuild.ToString();
            }
            public long Yaz(string bolum, string ayaradi, string deger)
            {
                return WritePrivateProfileString(bolum, ayaradi, deger, DOSYAYOLU);
            }
        }

        INIKaydet INI = new INIKaydet(Application.StartupPath + @"\Settings.ini");
        INIKaydet INI_PRGCheck = new INIKaydet(Application.StartupPath + @"\PRGCheck.ini");
        //public Form_Main Form_Main;
        //public Logs Logs;

        string INI_Main = "Main";



        public void KAYDET_SistemAyarlari()
        {
            INI.Yaz(INI_Main, "CLS.Form_Main.CHB_SystemTray",           CLS.Form_Main.CHB_SystemTray.Checked.ToString());
            INI.Yaz(INI_Main, "CLS.Form_Main.CHB_IlkAcilisTamEkran",    CLS.Form_Main.CHB_IlkAcilisTamEkran.Checked.ToString());
            INI.Yaz(INI_Main, "CLS.Form_Main.CHB_Acilista_Calistir",    CLS.Form_Main.CHB_Acilista_Calistir.Checked.ToString());
            INI.Yaz(INI_Main, "CLS.Form_Main.CHB_HerZamanUstte",        CLS.Form_Main.CHB_HerZamanUstte.Checked.ToString());
            INI.Yaz(INI_Main, "CLS.Form_Main.CHB_DizinBolumuGizle",     CLS.Form_Main.CHB_DizinBolumuGizle.Checked.ToString());
        }


        public void YUKLE_SistemAyarlari()
        {
            CLS.Form_Main.CHB_SystemTray.Checked            = Boolean.Parse(INI.Oku(INI_Main, "CLS.Form_Main.CHB_SystemTray"));
            CLS.Form_Main.CHB_IlkAcilisTamEkran.Checked     = Boolean.Parse(INI.Oku(INI_Main, "CLS.Form_Main.CHB_IlkAcilisTamEkran"));
            CLS.Form_Main.CHB_Acilista_Calistir.Checked     = Boolean.Parse(INI.Oku(INI_Main, "CLS.Form_Main.CHB_Acilista_Calistir"));
            CLS.Form_Main.CHB_HerZamanUstte.Checked         = Boolean.Parse(INI.Oku(INI_Main, "CLS.Form_Main.CHB_HerZamanUstte"));
            CLS.Form_Main.CHB_DizinBolumuGizle.Checked      = Boolean.Parse(INI.Oku(INI_Main, "CLS.Form_Main.CHB_DizinBolumuGizle"));
        }




    }
}
