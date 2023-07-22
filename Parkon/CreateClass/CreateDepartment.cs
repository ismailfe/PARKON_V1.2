using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parkon
{
    public class CreateDepartment
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


        public string MusteriBolumNoSorgula(string MusteriNo, out string SiradakiMusteriBolumNo)
        {
            SiradakiMusteriBolumNo = "";
            try
            {
                string[] refColumnName = new string[1];
                string[] refValue = new string[1];

                refColumnName[0] = "MusteriNo";
                refValue[0] = MusteriNo.Trim();

                CLS.ID_MySQL.FindLastNumber(CLS.MySQLVar.TableName_DBMusteriBolum, "BolumNo", true, refColumnName, refValue, out string LastNumber);

                if (LastNumber.Length < 2)
                {
                    SiradakiMusteriBolumNo = "0" + LastNumber;
                }else
                {
                    SiradakiMusteriBolumNo = LastNumber;
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


        public string YeniMusteriBolumOlustur(string BolumNot, string MusteriNo, string MusteriAdi, string BolumNo, string BolumAdi)
        {
            try
            {
                string KullanilacakBolumNo = "";
                string[] WriteData = new string[8];

                string[] refColumnName = new string[1];
                string[] refValue = new string[1];

                refColumnName[0] = "MusteriNo";
                refValue[0] = MusteriNo;


                CLS.ID_MySQL.FindLastNumber(CLS.MySQLVar.TableName_DBMusteriBolum, "BolumNo", true, refColumnName, refValue, out string LastNumber);

                if (LastNumber.Length < 2)
                {
                    KullanilacakBolumNo = "000" + LastNumber;
                }
                else if (LastNumber.Length == 2)
                {
                    KullanilacakBolumNo = "00" + LastNumber;
                }
                else if (LastNumber.Length == 3)
                {
                    KullanilacakBolumNo = "0" + LastNumber;
                }
                else if (LastNumber.Length == 4)
                {
                    KullanilacakBolumNo = "" + LastNumber;
                }


                WriteData[0] = ""; //PrimaryKey
                WriteData[1] = DateTime.Now.ToString();
                WriteData[2] = "ISMAIL DEMIR";
                WriteData[3] = BolumNot;
                WriteData[4] = MusteriNo;
                WriteData[5] = MusteriAdi;
                WriteData[6] = BolumNo;
                WriteData[7] = BolumAdi;


                CLS.ID_MySQL.WRITE_ToSQLRow(CLS.MySQLVar.TableName_DBMusteriBolum, CLS.MySQLVar.ColumnName_DBMusteriBolum, WriteData, 0);

                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }

        }







    }
}
