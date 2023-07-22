using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkon
{
    /// <summary>
    /// Classlar arası Bağlantı sınıfı
    /// </summary>
    public class CLS
    {
        public Form_Main                    Form_Main;
        public Form_Yeni_Musteri            Form_Yeni_Musteri;
        public Form_Yeni_MusteriBolum       Form_Yeni_MusteriBolum;
        public Form_Yeni_Yetkili            Form_Yeni_Yetkili;
        public Form_Yeni_User               Form_Yeni_User;
        public Form_Yeni_Proje              Form_Yeni_Proje;
        public Form_Yeni_Revizyon           Form_Yeni_Revizyon;

        public Crypto                       Crypto;
        public Log                          Log;
        public PrgSettings                  PrgSettings;
        public TextCheck                    TextCheck;
        public UserLogin                    UserLogin;
        public Bildirimler                  Bildirimler;

        public CreateAuthorized             CreateAuthorized;
        public CreateCustomer               CreateCustomer;
        public CreateDepartment             CreateDepartment;
        public CreateFolder                 CreateFolder;
        public CreateProject                CreateProject;

        public ID_MySQL                     ID_MySQL;
        public MySQL                        MySQL;
        public MySQLVar                     MySQLVar;

    }
}
