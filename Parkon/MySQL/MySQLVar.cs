using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parkon
{
    public class MySQLVar
    {
        #region PUBLIC VARIABLE
        public CLS CLS;

        #endregion


       public string TableName_DBMusteri            = "DBMusteri";
       public string TableName_DBMusteriBolum       = "DBMusteriBolum";
       public string TableName_DBMYetkili           = "DBMYetkili";
       public string TableName_DBProje              = "DBProje";
        public string TableName_DBRev               = "DBRev";
        public string TableName_DBAksiyon           = "DBAksiyon";
       public string TableName_DBUser               = "DBUser";

       public string[] ColumnName_DBMusteri         = new string[10];
       public string[] ColumnName_DBMusteriBolum    = new string[8];
       public string[] ColumnName_DBMYetkili        = new string[13];
       public string[] ColumnName_DBProje           = new string[21];
       public string[] ColumnName_DBRev             = new string[26];
       public string[] ColumnName_DBAksiyon         = new string[22];
       public string[] ColumnName_DBUser            = new string[17];

        public void FirstStart()
        {
            ColumnName_Write();
        }


        void ColumnName_Write()
        {
            ColumnName_DBMusteri[0]         = "ID";
            ColumnName_DBMusteri[1]         = "KayitTarih";
            ColumnName_DBMusteri[2]         = "KayitUser";
            ColumnName_DBMusteri[3]         = "Notlar";
            ColumnName_DBMusteri[4]         = "MusteriNo";
            ColumnName_DBMusteri[5]         = "MusteriAdi";
            ColumnName_DBMusteri[6]         = "MusteriBolge";
            ColumnName_DBMusteri[7]         = "MusteriAdres";
            ColumnName_DBMusteri[8]         = "MapsLink";
            ColumnName_DBMusteri[9]         = "MusteriTel";

            ColumnName_DBMusteriBolum[0]    = "ID";
            ColumnName_DBMusteriBolum[1]    = "KayitTarih";
            ColumnName_DBMusteriBolum[2]    = "KayitUser";
            ColumnName_DBMusteriBolum[3]    = "Notlar";
            ColumnName_DBMusteriBolum[4]    = "MusteriNo";
            ColumnName_DBMusteriBolum[5]    = "MusteriAdi";
            ColumnName_DBMusteriBolum[6]    = "BolumNo";
            ColumnName_DBMusteriBolum[7]    = "BolumAdi";

            ColumnName_DBMYetkili[0]        = "ID";
            ColumnName_DBMYetkili[1]        = "KayitTarih";
            ColumnName_DBMYetkili[2]        = "KayitUser";
            ColumnName_DBMYetkili[3]        = "Notlar";
            ColumnName_DBMYetkili[4]        = "MusteriNo";
            ColumnName_DBMYetkili[5]        = "MusteriAdi";
            ColumnName_DBMYetkili[6]        = "MYetkiliNo";
            ColumnName_DBMYetkili[7]        = "MYetkiliAdi";
            ColumnName_DBMYetkili[8]        = "MYetkiliTitle";
            ColumnName_DBMYetkili[9]        = "MYetkiliTel";
            ColumnName_DBMYetkili[10]       = "MYetkiliTel2";
            ColumnName_DBMYetkili[11]       = "MYetkiliMail";
            ColumnName_DBMYetkili[12]       = "MYetkiliInfo";

            ColumnName_DBProje[0]           = "ID";
            ColumnName_DBProje[1]           = "KayitTarih";
            ColumnName_DBProje[2]           = "KayitUser";
            ColumnName_DBProje[3]           = "Notlar";
            ColumnName_DBProje[4]           = "MusteriNo";
            ColumnName_DBProje[5]           = "MusteriAdi";
            ColumnName_DBProje[6]           = "BolumNo";
            ColumnName_DBProje[7]           = "BolumAdi";
            ColumnName_DBProje[8]           = "ProjeNo";
            ColumnName_DBProje[9]           = "ProjeKodu";
            ColumnName_DBProje[10]          = "ProjeAdi";
            ColumnName_DBProje[11]          = "ProjeBaslamaTarih";
            ColumnName_DBProje[12]          = "ProjeDonemAy";
            ColumnName_DBProje[13]          = "ProjeDonemYil";
            ColumnName_DBProje[14]          = "MYetkiliNo";
            ColumnName_DBProje[15]          = "MYetkiliAdi";
            ColumnName_DBProje[16]          = "MYetkiliTitle";
            ColumnName_DBProje[17]          = "MYetkiliTel";
            ColumnName_DBProje[18]          = "MYetkiliTel2";
            ColumnName_DBProje[19]          = "MYetkiliMail";
            ColumnName_DBProje[20]          = "MYetkiliInfo";

            ColumnName_DBRev[0]           = "ID";
            ColumnName_DBRev[1]           = "KayitTarih";
            ColumnName_DBRev[2]           = "KayitUser";
            ColumnName_DBRev[3]           = "Notlar";
            ColumnName_DBRev[4]           = "MusteriNo";
            ColumnName_DBRev[5]           = "MusteriAdi";
            ColumnName_DBRev[6]           = "BolumNo";
            ColumnName_DBRev[7]           = "BolumAdi";
            ColumnName_DBRev[8]           = "ProjeNo";
            ColumnName_DBRev[9]           = "ProjeKodu";
            ColumnName_DBRev[10]          = "ProjeAdi";
            ColumnName_DBRev[11]          = "ProjeBaslamaTarih";
            ColumnName_DBRev[12]          = "ProjeDonemAy";
            ColumnName_DBRev[13]          = "ProjeDonemYil";
            ColumnName_DBRev[14]          = "MYetkiliNo";
            ColumnName_DBRev[15]          = "MYetkiliAdi";
            ColumnName_DBRev[16]          = "MYetkiliTitle";
            ColumnName_DBRev[17]          = "MYetkiliTel";
            ColumnName_DBRev[18]          = "MYetkiliTel2";
            ColumnName_DBRev[19]          = "MYetkiliMail";
            ColumnName_DBRev[20]          = "MYetkiliInfo";
            ColumnName_DBRev[21]          = "RevBaslamaTarih";
            ColumnName_DBRev[22]          = "RevDonemAy";
            ColumnName_DBRev[23]          = "RevDonemYil";
            ColumnName_DBRev[24]          = "RevNo";
            ColumnName_DBRev[25]          = "RevAdi";

            ColumnName_DBAksiyon[0]         = "ID";
            ColumnName_DBAksiyon[1]         = "KayitTarih";
            ColumnName_DBAksiyon[2]         = "KayitUser";
            ColumnName_DBAksiyon[3]         = "Notlar";
            ColumnName_DBAksiyon[4]         = "MusteriNo";
            ColumnName_DBAksiyon[5]         = "MusteriAdi";
            ColumnName_DBAksiyon[6]         = "BolumNo";
            ColumnName_DBAksiyon[7]         = "BolumAdi";
            ColumnName_DBAksiyon[8]         = "ProjeNo";
            ColumnName_DBAksiyon[9]         = "ProjeAdi";
            ColumnName_DBAksiyon[10]        = "IslemBaslamaTarih";
            ColumnName_DBAksiyon[11]        = "IslemBitirmeTarih";
            ColumnName_DBAksiyon[12]        = "Islem";
            ColumnName_DBAksiyon[13]        = "Aciklama";
            ColumnName_DBAksiyon[14]        = "Sorumlu";
            ColumnName_DBAksiyon[15]        = "MYetkiliNo";
            ColumnName_DBAksiyon[16]        = "MYetkiliAdi";
            ColumnName_DBAksiyon[17]        = "MYetkiliTitle";
            ColumnName_DBAksiyon[18]        = "MYetkiliTel";
            ColumnName_DBAksiyon[19]        = "MYetkiliTel2";
            ColumnName_DBAksiyon[20]        = "MYetkiliMail";
            ColumnName_DBAksiyon[21]        = "MYetkiliInfo";


            ColumnName_DBUser[0]            = "ID";
            ColumnName_DBUser[1]            = "KayitTarih";
            ColumnName_DBUser[2]            = "KayitUser";
            ColumnName_DBUser[3]            = "Notlar";
            ColumnName_DBUser[4]            = "UserNo";
            ColumnName_DBUser[5]            = "UserPic";
            ColumnName_DBUser[6]            = "UserName";
            ColumnName_DBUser[7]            = "UserPass";
            ColumnName_DBUser[8]            = "UserLevel";
            ColumnName_DBUser[9]            = "UserAd";
            ColumnName_DBUser[10]           = "UserTitle";
            ColumnName_DBUser[11]           = "UserBolum";
            ColumnName_DBUser[12]           = "UserTel";
            ColumnName_DBUser[13]           = "UserTel2";
            ColumnName_DBUser[14]           = "UserMail";
            ColumnName_DBUser[15]           = "UserDTarih";
            ColumnName_DBUser[16]           = "UserKan";

        }




    }
}
