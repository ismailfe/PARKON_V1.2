using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parkon
{
    public class CreateCustomer
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


        public string MusteriNoSorgula(out string SiradakiMusteriNo)
        {
            SiradakiMusteriNo = "";
            try
            {
                string[] refColumnName = new string[0];
                string[] refValue      = new string[0];
                CLS.ID_MySQL.FindLastNumber(CLS.MySQLVar.TableName_DBMusteri, "MusteriNo",false, refColumnName, refValue, out string LastNumber);

                if (LastNumber.Length < 2)
                {
                    SiradakiMusteriNo = "000" + LastNumber;
                }
                else if (LastNumber.Length == 2)
                {
                    SiradakiMusteriNo = "00" + LastNumber;
                }
                else if (LastNumber.Length == 3)
                {
                    SiradakiMusteriNo = "0" + LastNumber;
                }
                else if (LastNumber.Length == 4)
                {
                    SiradakiMusteriNo = "" + LastNumber;
                }

                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }

        }


        public string YeniMusteriOlustur(string MusteriNot, string MusteriAdi, string MusteriBolge, string MusteriAdres, string MusteriMapLink, string MusteriTel)
        {
            try
            {
                string MusteriNo = "";
                string[] WriteData = new string[10];

                string[] refColumnName = new string[0];
                string[] refValue = new string[0];

                CLS.ID_MySQL.FindLastNumber(CLS.MySQLVar.TableName_DBMusteri, "MusteriNo",false, refColumnName, refValue, out string LastNumber);

                if (LastNumber.Length < 2)
                {
                    MusteriNo = "000" + LastNumber;
                }
                else if (LastNumber.Length == 2)
                {
                    MusteriNo = "00" + LastNumber;
                }
                else if (LastNumber.Length == 3)
                {
                    MusteriNo = "0" + LastNumber;
                }
                else if (LastNumber.Length == 4)
                {
                    MusteriNo = "" + LastNumber;
                }


                WriteData[0] = ""; //PrimaryKey
                WriteData[1] = DateTime.Now.ToString();
                WriteData[2] = "ISMAIL DEMIR";
                WriteData[3] = MusteriNot;
                WriteData[4] = MusteriNo;
                WriteData[5] = MusteriAdi;
                WriteData[6] = MusteriBolge;
                WriteData[7] = MusteriAdres;
                WriteData[8] = MusteriMapLink;
                WriteData[9] = MusteriTel;

                CLS.ID_MySQL.WRITE_ToSQLRow(CLS.MySQLVar.TableName_DBMusteri, CLS.MySQLVar.ColumnName_DBMusteri, WriteData, 0);




                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }

        }






    }
}
