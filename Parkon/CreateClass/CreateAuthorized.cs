using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parkon
{
    public class CreateAuthorized
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


        public string YetkikiNoSorgula(string MusteriNo, out string SiradakiYetkiliNo)
        {
            SiradakiYetkiliNo = "";
            try
            {
                string[] refColumnName = new string[1];
                string[] refValue = new string[1];

                refColumnName[0] = "MusteriNo";
                refValue[0] = MusteriNo.Trim();

                CLS.ID_MySQL.FindLastNumber(CLS.MySQLVar.TableName_DBMYetkili, "MYetkiliNo", true, refColumnName, refValue, out string LastNumber);

                if (LastNumber.Length < 2)
                {
                    SiradakiYetkiliNo = "0" + LastNumber;
                }
                //else if (LastNumber.Length == 2)
                //{
                //    SiradakiMusteriBolumNo = "00" + LastNumber;
                //}
                //else if (LastNumber.Length == 3
                //{
                //    SiradakiMusteriBolumNo = "0" + LastNumber;
                //}
                //else if (LastNumber.Length == 4)
                //{
                //    SiradakiMusteriBolumNo = "" + LastNumber;
                //}

                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }

        }


        public string YeniYetkiliOlustur(string Not, string MusteriNo, string MusteriAdi, string YetkiliAd, string YetkiliUnvan, string YetkiliTel1,string YetkiliTel2, string YetkiliMail, string YetkiliInfo)
        {
            try
            {
                string KullanilacakYetkiliNo = "";
                string[] WriteData = new string[13];

                string[] refColumnName = new string[1];
                string[] refValue = new string[1];

                refColumnName[0] = "MusteriNo";
                refValue[0] = MusteriNo;


                CLS.ID_MySQL.FindLastNumber(CLS.MySQLVar.TableName_DBMYetkili, "MYetkiliNo", true, refColumnName, refValue, out string LastNumber);

                if (LastNumber.Length < 2)
                {
                    KullanilacakYetkiliNo = "0" + LastNumber;
                }
                //else if (LastNumber.Length == 2)
                //{
                //    KullanilacakBolumNo = "00" + LastNumber;
                //}
                //else if (LastNumber.Length == 3)
                //{
                //    KullanilacakBolumNo = "0" + LastNumber;
                //}
                //else if (LastNumber.Length == 4)
                //{
                //    KullanilacakBolumNo = "" + LastNumber;
                //}


                WriteData[0] = ""; //PrimaryKey
                WriteData[1] = DateTime.Now.ToString();
                WriteData[2] = "ISMAIL DEMIR";
                WriteData[3] = Not;
                WriteData[4] = MusteriNo;
                WriteData[5] = MusteriAdi;
                WriteData[6] = KullanilacakYetkiliNo;
                WriteData[7] = YetkiliAd;
                WriteData[8] = YetkiliUnvan;
                WriteData[9] =  YetkiliTel1;
                WriteData[10] = YetkiliTel2;
                WriteData[11] = YetkiliMail;
                WriteData[12] = YetkiliInfo;
            

                string cmd = CLS.ID_MySQL.WRITE_ToSQLRow(CLS.MySQLVar.TableName_DBMYetkili, CLS.MySQLVar.ColumnName_DBMYetkili, WriteData, 0);

                return "OK! - " + cmd;
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }

        }





    }
}
