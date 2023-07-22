using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Web;
using Microsoft.Win32;
using ID_DB;
using System.Diagnostics;

namespace Parkon
{
    public partial class Form_Main : Form
    {

#region PUBLIC_VARIABLE
       
        Form_Yeni_Musteri Form_Yeni_Musteri                 = new Form_Yeni_Musteri();
        Form_Yeni_MusteriBolum Form_Yeni_MusteriBolum       = new Form_Yeni_MusteriBolum();
        Crypto Crypto                                       = new Crypto();
        Form_Yeni_Yetkili Form_Yeni_Yetkili                 = new Form_Yeni_Yetkili();
        Form_Yeni_User Form_Yeni_User                       = new Form_Yeni_User();
        Form_Yeni_Proje Form_Yeni_Proje                     = new Form_Yeni_Proje();
        Form_Yeni_Revizyon Form_Yeni_Revizyon               = new Form_Yeni_Revizyon();

        Log Log                                             = new Log();
        PrgSettings PrgSettings                             = new PrgSettings();
        TextCheck TextCheck                                 = new TextCheck();
        UserLogin UserLogin                                 = new UserLogin();
        Bildirimler Bildirimler                             = new Bildirimler();

        CreateAuthorized CreateAuthorized                   = new CreateAuthorized();
        CreateCustomer CreateCustomer                       = new CreateCustomer();
        CreateDepartment CreateDepartment                   = new CreateDepartment();
        CreateFolder CreateFolder                           = new CreateFolder();
        CreateProject CreateProject                         = new CreateProject();

        ID_MySQL ID_MySQL                                   = new ID_MySQL();
        MySQL MySQL                                         = new MySQL();
        MySQLVar MySQLVar                                   = new MySQLVar();
        CLS CLS                                             = new CLS();


        public string CrtPrj_SecilenMusteriNo;
        public string CrtPrj_SecilenMusteriAdi;
        public string CrtPrj_SecilenBolumNo;
        public string CrtPrj_SecilenBolumAdi;

        GroupBox Grp_PLC_Program                    = new GroupBox();
        WebBrowser WB_PLC_Program                   = new WebBrowser();
        Button B_PLC_Program_Geri                   = new Button();
        Button B_PLC_Program_Ac                     = new Button();
        Button B_PLC_Program_CopyLink               = new Button();

        GroupBox Grp_HMI_Program                    = new GroupBox();
        WebBrowser WB_HMI_Program                   = new WebBrowser();
        Button B_HMI_Program_Geri                   = new Button();
        Button B_HMI_Program_Ac                     = new Button();
        Button B_HMI_Program_CopyLink               = new Button();

        GroupBox Grp_SCADA_Program                  = new GroupBox();
        WebBrowser WB_SCADA_Program                 = new WebBrowser();
        Button B_SCADA_Program_Geri                 = new Button();
        Button B_SCADA_Program_Ac                   = new Button();
        Button B_SCADA_Program_CopyLink             = new Button();

        GroupBox Grp_YARD_Program                   = new GroupBox();
        WebBrowser WB_YARD_Program                  = new WebBrowser();
        Button B_YARD_Program_Geri                  = new Button();
        Button B_YARD_Program_Ac                    = new Button();
        Button B_YARD_Program_CopyLink              = new Button();

        GroupBox Grp_PC_Program                     = new GroupBox();
        WebBrowser WB_PC_Program                    = new WebBrowser();
        Button B_PC_Program_Geri                    = new Button();
        Button B_PC_Program_Ac                      = new Button();
        Button B_PC_Program_CopyLink                = new Button();

        GroupBox Grp_Malzeme_Listesi                = new GroupBox();
        WebBrowser WB_Malzeme_Listesi               = new WebBrowser();
        Button B_Malzeme_Listesi_Geri               = new Button();
        Button B_Malzeme_Listesi_Ac                 = new Button();
        Button B_Malzeme_Listesi_CopyLink           = new Button();

        GroupBox Grp_Elektrik_Projesi               = new GroupBox();
        WebBrowser WB_Elektrik_Projesi              = new WebBrowser();
        Button B_Elektrik_Projesi_Geri              = new Button();
        Button B_Elektrik_Projesi_Ac                = new Button();
        Button B_Elektrik_Projesi_CopyLink          = new Button();

        GroupBox Grp_Cizimler                       = new GroupBox();
        WebBrowser WB_Cizimler                      = new WebBrowser();
        Button B_Cizimler_Geri                      = new Button();
        Button B_Cizimler_Ac                        = new Button();
        Button B_Cizimler_CopyLink                  = new Button();

        GroupBox Grp_Musteri_Iliskileri             = new GroupBox();
        WebBrowser WB_Musteri_Iliskileri            = new WebBrowser();
        Button B_Musteri_Iliskileri_Geri            = new Button();
        Button B_Musteri_Iliskileri_Ac              = new Button();
        Button B_Musteri_Iliskileri_CopyLink        = new Button();


        GroupBox Grp_Teklif_Belgeleri               = new GroupBox();
        WebBrowser WB_Teklif_Belgeleri              = new WebBrowser();
        Button B_Teklif_Belgeleri_Geri              = new Button();
        Button B_Teklif_Belgeleri_Ac                = new Button();
        Button B_Teklif_Belgeleri_CopyLink          = new Button();

        GroupBox Grp_Servis_Egitim_Formlari         = new GroupBox();
        WebBrowser WB_Servis_Egitim_Formlari        = new WebBrowser();
        Button B_Servis_Egitim_Formlari_Geri        = new Button();
        Button B_Servis_Egitim_Formlari_Ac          = new Button();
        Button B_Servis_Egitim_Formlari_CopyLink    = new Button();

        GroupBox Grp_Dokumanlar                     = new GroupBox();
        WebBrowser WB_Dokumanlar                    = new WebBrowser();
        Button B_Dokumanlar_Geri                    = new Button();
        Button B_Dokumanlar_Ac                      = new Button();
        Button B_Dokumanlar_CopyLink                = new Button();

        GroupBox Grp_Diger_Dokumanlar               = new GroupBox();
        WebBrowser WB_Diger_Dokumanlar              = new WebBrowser();
        Button B_Diger_Dokumanlar_Geri              = new Button();
        Button B_Diger_Dokumanlar_Ac                = new Button();
        Button B_Diger_Dokumanlar_CopyLink          = new Button();

        GroupBox Grp_FotografVideo                  = new GroupBox();
        WebBrowser WB_FotografVideo                 = new WebBrowser();
        Button B_FotografVideo_Geri                 = new Button();
        Button B_FotografVideo_Ac                   = new Button();
        Button B_FotografVideo_CopyLink             = new Button();

        GroupBox Grp_Tum_Dokumanlar                 = new GroupBox();
        WebBrowser WB_Tum_Dokumanlar                = new WebBrowser();
        Button B_Tum_Dokumanlar_Geri                = new Button();
        Button B_Tum_Dokumanlar_Ac                  = new Button();
        Button B_Tum_Dokumanlar_CopyLink            = new Button();

        GroupBox Grp_Is_Zaman_Plani                 = new GroupBox();
        WebBrowser WB_Is_Zaman_Plani                = new WebBrowser();
        Button B_Is_Zaman_Plani_Geri                = new Button();
        Button B_Is_Zaman_Plani_Ac                  = new Button();
        Button B_Is_Zaman_Plani_CopyLink            = new Button();

#endregion

 void Class()
        {
            CLS.Form_Main                   = this;
            CLS.Form_Yeni_Musteri           = Form_Yeni_Musteri;
            CLS.Form_Yeni_MusteriBolum      = Form_Yeni_MusteriBolum;
            CLS.Form_Yeni_Yetkili           = Form_Yeni_Yetkili;
            CLS.Form_Yeni_User              = Form_Yeni_User;
            CLS.Form_Yeni_Proje             = Form_Yeni_Proje;
            CLS.Form_Yeni_Revizyon          = Form_Yeni_Revizyon;
            CLS.Crypto                      = Crypto;
            CLS.Log                         = Log;
            CLS.PrgSettings                 = PrgSettings;
            CLS.TextCheck                   = TextCheck;
            CLS.UserLogin                   = UserLogin;
            CLS.Bildirimler                 = Bildirimler;

            CLS.CreateAuthorized            = CreateAuthorized;
            CLS.CreateCustomer              = CreateCustomer;
            CLS.CreateDepartment            = CreateDepartment;
            CLS.CreateFolder                = CreateFolder;
            CLS.CreateProject               = CreateProject;
   
            CLS.ID_MySQL                    = ID_MySQL;
            CLS.MySQL                       = MySQL;
            CLS.MySQLVar                    = MySQLVar;

            Form_Yeni_Yetkili.CLS           = CLS;
            Form_Yeni_Musteri.CLS           = CLS;
            Form_Yeni_MusteriBolum.CLS      = CLS;
            Form_Yeni_User.CLS              = CLS;
            Form_Yeni_Proje.CLS             = CLS;
            Form_Yeni_Revizyon.CLS          = CLS;
            Crypto.CLS                      = CLS;
            Log.CLS                         = CLS;
            PrgSettings.CLS                 = CLS;
            TextCheck.CLS                   = CLS;
            UserLogin.CLS                   = CLS;
            Bildirimler.CLS                 = CLS;

            CreateAuthorized.CLS            = CLS;
            CreateCustomer.CLS              = CLS;
            CreateDepartment.CLS            = CLS;
            CreateFolder.CLS                = CLS;
            CreateProject.CLS               = CLS;

            ID_MySQL.CLS                    = CLS;
            MySQL.CLS                       = CLS;
            MySQLVar.CLS                    = CLS;

        //public PrgSettings PrgSettings = new PrgSettings();
        //public TextCheck TextCheck = new TextCheck();

        //public CreateAuthorized CreateAuthorized = new CreateAuthorized();
        //public CreateCustomer CreateCustomer = new CreateCustomer();
        //public CreateDepartment CreateDepartment = new CreateDepartment();
        //public CreateFolder CreateFolder = new CreateFolder();
        //public CreateProject CreateProject = new CreateProject();

        //public ID_MySQL ID_MySQL = new ID_MySQL();
        //public MySQL MySQL = new MySQL();
        //public MySQLVar MySQLVar = new MySQLVar();

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


        #region FORM_FUNCTIONS

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FirstStart();
            CLS.ID_MySQL.Connect();
            //string VERSION = "1.0.2";
            //this.Text = "Proje Arşivleme ve Kontrol V" + VERSION;
            //ToolTip_Verison.Text = "Version: " + VERSION;

        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            CLS.ID_MySQL.Disconnect();
        }

        public void FirstStart()
        {
            Class();
            CLS.MySQLVar.FirstStart();

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            this.Text = "Proje Arşivleme ve Kontrol Sistemi V" + fvi.FileVersion;
            LB_Version.Text = "V" + fvi.FileVersion;


            //// ***************  GEÇİÇİ  ****************
            //Tab_Main.TabPages.Remove(Programmer);
            //// *****************************************

            //LB_AnaDizin.Text = Properties.Settings.Default.AnaDizin;
            //TB_Kullanici.Text = Properties.Settings.Default.UserName;

            //TreeView_Duzeni();
            //Anadizin = LB_AnaDizin.Text;
            //toolStripKullanici.Text = "  Kullanıcı : " + TB_Kullanici.Text;


            //try
            //{
            //    InternetKontrol();
            //    AcilistaCalistir();
            //    if (Properties.Settings.Default.SimgeOlarakKucult)
            //    {
            //        Notify();
            //        CHB_Acilista_Calistir.Checked = true;
            //    }

            //    if (Properties.Settings.Default.IlkAcilistaTamEkran)
            //    {
            //        this.WindowState = FormWindowState.Maximized;
            //        CHB_IlkAcilisTamEkran.Checked = true;
            //    }
            //    else
            //    {
            //        this.WindowState = FormWindowState.Normal;
            //        CHB_IlkAcilisTamEkran.Checked = false;
            //    }

            //    if (Properties.Settings.Default.HerZamanUstte)
            //    {
            //        this.TopMost = true;
            //        CHB_HerZamanUstte.Checked = true;
            //    }
            //    else
            //    {
            //        this.TopMost = false;
            //        CHB_HerZamanUstte.Checked = false;
            //    }
            //}
            //catch 
            //{
            //    Properties.Settings.Default.SimgeOlarakKucult       = true;
            //    Properties.Settings.Default.acililstaBaslat         = true;
            //    Properties.Settings.Default.AnaDizin                = "C:\\";
            //    Properties.Settings.Default.UserName                = "";
            //    Properties.Settings.Default.IlkAcilistaTamEkran     = false;
            //    Properties.Settings.Default.HerZamanUstte           = false;
            //    Properties.Settings.Default.Save();
            //}

        }

        void AcilistaCalistir()
        {
            //string ProgramAdi = "PARKON";
            //if (Properties.Settings.Default.acililstaBaslat)
            //{ //işaretlendi ise Regedit e açılışta çalıştır olarak ekle
            //    RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            //    key.SetValue(ProgramAdi, "\"" + Application.ExecutablePath + "\"");
            //    CHB_Acilista_Calistir.Checked = true;
            //}
            //else
            //{  //işaret kaldırıldı ise Regeditten açılışta çalıştırılacaklardan kaldır
            //    RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            //    key.DeleteValue(ProgramAdi);
            //    CHB_Acilista_Calistir.Checked = false;
            //}
        }

        public void InternetKontrol()
        {
            try
            {
                System.Net.Sockets.TcpClient kontrol_client = new System.Net.Sockets.TcpClient("www.google.com.tr", 80);
                kontrol_client.Close();
                toolStrip_InternetKnt.BackColor = Color.Lime;
                LB_Internet_Knt.Text = "İnternet Bağlantısı Var!"; LB_Internet_Knt.ForeColor = Color.DarkGreen;
                B_Proje_Olustur.Enabled = true;
                B_CrtPrj_YeniMusteriEkle.Enabled = true;
            }
            catch
            {
                toolStrip_InternetKnt.BackColor = Color.Red;
                LB_Internet_Knt.Text = "İnternet Bağlantısı Yok!"; LB_Internet_Knt.ForeColor = Color.Red;
                B_Proje_Olustur.Enabled = false;
                B_CrtPrj_YeniMusteriEkle.Enabled = false;
            }
        }

#region KLAVYE DINLEME
        //globalKeyboardHook klavyeDinleyicisi = new globalKeyboardHook();
        //public void DinlenecekTuslariAyarla()
        //{
        //    // hangi tuşları dinlemek istiyorsak burada ekliyoruz
        //    // Ben burada F,K ve M harflerine basılınca tetiklenecek şekilde ayarladım
        //    klavyeDinleyicisi.HookedKeys.Add(Keys.F9);

        //    //basıldığında ilk burası çalışır
        //    klavyeDinleyicisi.KeyDown += new KeyEventHandler(islem1);
        //    //basıldıktan sonra ikinci olarak burası çalışır
        //    klavyeDinleyicisi.KeyUp += new KeyEventHandler(islem2);
        //}

        //  void islem1(object sender, KeyEventArgs e)
        //  {
        ////Yapılmasını istediğiniz kodlar burada yer alacak
        ////Burası tuşa basıldığı an çalışır



        ////Eğer buraya gelecek olan tuşa basıldığında
        ////o tuşun normal işlevi yine çalışsın istiyorsanız
        ////e.Handled değeri false olmalı
        ////eğer ilgili tuşa basıldığında burada yakalansın
        //// ve devamında tuş başka bir işlev gerçekleştirmesin
        ////istiyorsanız bu değeri true yapmalısınız
        //e.Handled = false;
        //}

        // void islem2(object sender, KeyEventArgs e)
        // {
        ////Yapılmasını istediğiniz kodlar burada yer alacak
        //// Burası ilgili tuşlara basılıp çekildikten sonra çalışır
        //     if (WindowState == FormWindowState.Minimized)
        //     {
        //         WindowState = FormWindowState.Normal;
        //     }


        ////Eğer buraya gelecek olan tuşa basıldığında
        ////o tuşun normal işlevi yine çalışsın istiyorsanız
        ////e.Handled değeri false olmalı
        ////eğer ilgili tuşa basıldığında burada yakalansın
        //// ve devamında tuş başka bir işlev gerçekleştirmesin
        ////istiyorsanız bu değeri true yapmalısınız
        //e.Handled = true;
        //}
#endregion

#region NOTIFY CONTROL

        void Notify()
        {

            //// Backround Work
            Notify_Parkon.BalloonTipText = "Hi! Parkon is running. Have a nice day!";
            Notify_Parkon.BalloonTipTitle = "Parkon - Proje Arşivleme ve Kontrol";
            // this.WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            Notify_Parkon.Visible = true;
            Notify_Parkon.ShowBalloonTip(800);
            ////**********************
            ////**********************
        }

        private void Notify_Parkon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            Notify_Parkon.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Form_Main_Resize(object sender, EventArgs e)
        {
            //if (WindowState == FormWindowState.Minimized && Properties.Settings.Default.SimgeOlarakKucult)
            //{
            //    //// Backround Work
            //    Notify_Parkon.BalloonTipText = "Parkon is still running";
            //    Notify_Parkon.BalloonTipTitle = "Parkon - Proje Arşivleme ve Kontrol";
            //    // this.WindowState = FormWindowState.Minimized;
            //    ShowInTaskbar = false;
            //    Notify_Parkon.Visible = true;
            //    Notify_Parkon.ShowBalloonTip(800);
            //    ShowInTaskbar = false;
            //    Notify_Parkon.Visible = true;
            //    Notify_Parkon.ShowBalloonTip(1000);
            //}
        }

        private void Notify_Bilgi_Uyari()
        {
            if (DateTime.Now.ToLongTimeString() == "14:30:02")
            {
                //// Backround Work
                Notify_Parkon.BalloonTipText = "Bir fincan kahve içmenin tam zamanı...";
                Notify_Parkon.BalloonTipTitle = "Parkon - Proje Arşivleme ve Kontrol";
                // this.WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
                Notify_Parkon.Visible = true;
                Notify_Parkon.ShowBalloonTip(800);
                ShowInTaskbar = false;
                Notify_Parkon.Visible = true;
                Notify_Parkon.ShowBalloonTip(1000);
            }

            if (DateTime.Now.ToLongTimeString() == "17:00:02")
            {
                //// Backround Work
                Notify_Parkon.BalloonTipText = "Sıcak bir fincan kahve daha? ";
                Notify_Parkon.BalloonTipTitle = "Parkon - Proje Arşivleme ve Kontrol";
                // this.WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
                Notify_Parkon.Visible = true;
                Notify_Parkon.ShowBalloonTip(800);
                ShowInTaskbar = false;
                Notify_Parkon.Visible = true;
                Notify_Parkon.ShowBalloonTip(1000);
            }



        }

        #endregion


        private void B_Dizin_Gizle_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            B_Dizin_Ac.Visible = true;
        }

        private void B_Dizin_Ac_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
            B_Dizin_Ac.Visible = false;
        }

#region TIMERLAR
        private void Timer_1sec_Tick(object sender, EventArgs e)
        {
            LB_Time.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            Notify_Bilgi_Uyari();
        }

        private void Timer_1min_Tick(object sender, EventArgs e)
        {
            InternetKontrol();

        }
        #endregion

#region AYARLAR - Kullanıcı ve Program Ayarları
        //private void B_AnaDizinSec_Click(object sender, EventArgs e)
        //{
        //    FolderBrowserDialog FbWDialog = new FolderBrowserDialog();
        //    FbWDialog.ShowDialog();
        //    LB_AnaDizin.Text = FbWDialog.SelectedPath + "\\";
        //    Properties.Settings.Default.AnaDizin = LB_AnaDizin.Text;
        //    Properties.Settings.Default.Save();
        //    Anadizin = LB_AnaDizin.Text;
        //}

        //private void TB_Kullanici_TextChanged(object sender, EventArgs e)
        //{
        //    Properties.Settings.Default.UserName = TB_Kullanici.Text;
        //    Properties.Settings.Default.Save();
        //    toolStripKullanici.Text = "  Kullanıcı : " + TB_Kullanici.Text;
        //}
#endregion

#region AYARLAR - Program Görüntüleme Ayarları
        private void CHB_Acilista_Calistir_CheckedChanged(object sender, EventArgs e)
        {
            //if (CHB_Acilista_Calistir.Checked)
            //{
            //    Properties.Settings.Default.acililstaBaslat = true;
            //    Properties.Settings.Default.Save();
            //}
            //else
            //{
            //    Properties.Settings.Default.acililstaBaslat = false;
            //    Properties.Settings.Default.Save();
            //}
            //AcilistaCalistir();
        }

        private void CHB_SystemTray_CheckedChanged(object sender, EventArgs e)
        {
            //if (CHB_SystemTray.Checked)
            //{
            //    Properties.Settings.Default.SimgeOlarakKucult = true;
            //    Properties.Settings.Default.Save();
            //}
            //else
            //{
            //    Properties.Settings.Default.SimgeOlarakKucult = false;
            //    Properties.Settings.Default.Save();
            //}

        }

        private void CHB_IlkAcilisTamEkran_CheckedChanged(object sender, EventArgs e)
        {

            //if (CHB_IlkAcilisTamEkran.Checked == true)
            //{
            //    Properties.Settings.Default.IlkAcilistaTamEkran = true;
            //    Properties.Settings.Default.Save();
            //}
            //else
            //{
            //    Properties.Settings.Default.IlkAcilistaTamEkran = false;
            //    Properties.Settings.Default.Save();
            //}



        }

        private void CHB_HerZamanUstte_CheckedChanged(object sender, EventArgs e)
        {
            //if (CHB_HerZamanUstte.Checked == true)
            //{
            //    Properties.Settings.Default.HerZamanUstte = true;
            //    Properties.Settings.Default.Save();
            //}
            //else
            //{
            //    Properties.Settings.Default.HerZamanUstte = false;
            //    Properties.Settings.Default.Save();
            //}
        }
#endregion




#endregion

#region DIZIN_AGACI

        private void dirsTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
                {
                    e.Node.Nodes.Clear();

                    //get the list of sub direcotires
                    string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());

                    foreach (string dir in dirs)
                    {
                        DirectoryInfo di = new DirectoryInfo(dir);
                        TreeNode node = new TreeNode(di.Name, 0, 1);

                        try
                        {
                            //keep the directory's full path in the tag for use later
                            node.Tag = dir;

                            //if the directory has sub directories add the place holder
                            if (di.GetDirectories().Count() > 0)
                                node.Nodes.Add(null, "...", 0, 0);
                        }
                        catch (UnauthorizedAccessException)
                        {
                            //display a locked folder icon
                            node.ImageIndex = 12;
                            node.SelectedImageIndex = 12;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "DirectoryLister",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            e.Node.Nodes.Add(node);
                        }
                    }
                }
            }
        }

        private void TreeView_Duzeni()
        {

            //get a list of the drives
            string[] drives = Environment.GetLogicalDrives();

            foreach (string drive in drives)
            {
                DriveInfo di = new DriveInfo(drive);
                int driveImage;

                switch (di.DriveType)    //set the drive's icon
                {
                    case DriveType.CDRom:
                        driveImage = 27;
                        break;
                    case DriveType.Network:
                        driveImage = 24;
                        break;
                    case DriveType.NoRootDirectory:
                        driveImage = 18;
                        break;
                    case DriveType.Unknown:
                        driveImage = 30;
                        break;
                    default:
                        driveImage = 26;
                        break;
                }

                TreeNode node = new TreeNode(drive.Substring(0, 1), driveImage, driveImage);
                node.Tag = drive;

                if (di.IsReady == true)
                    node.Nodes.Add("...");

                dirsTreeView.Nodes.Add(node);
            }
        }

        string TreeView_SeciliDizin;
        private void dirsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode CurrentNode = e.Node;
            TreeView_SeciliDizin = CurrentNode.Tag.ToString();
            TB_TreeView_SeciliDizin.Text = TreeView_SeciliDizin;
        }

        private void B_Dizin_Open_Click(object sender, EventArgs e)
        {
            string myDocspath = TreeView_SeciliDizin; // Buraya istediğimiz dosyanın yolunu yazıyorz
            string windir = Environment.GetEnvironmentVariable("WINDIR");
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = windir + @"\explorer.exe";
            prc.StartInfo.Arguments = myDocspath;
            prc.Start();
        }


#endregion

#region PROJE_OLUSTURMA

        //private void CB_MusteriFirma_PrjOlusturma_MouseDown(object sender, MouseEventArgs e)
        //{

        //    CB_Proje_Olustur_Musteri_Firma.Items.Clear();

        //    string[] dosya = Directory.GetDirectories(Anadizin);
        //    for (int a = 0; a < dosya.Length; a++)
        //    {
        //        string MusteriFirma_Klasorleri = dosya[a];
        //        MusteriFirma_Klasorleri = MusteriFirma_Klasorleri.Replace(Anadizin, "");
        //        CB_Proje_Olustur_Musteri_Firma.Items.Add(MusteriFirma_Klasorleri);
        //    }
        //}

        //private void B_Yeni_Musteri_Ekle_Prj_Olusturma_Click(object sender, EventArgs e)
        //{
        //    Form_Yeni_Musteri.ShowDialog();
        //}

        //private void B_Proje_Olustur_Click(object sender, EventArgs e)
        //{
        //    if (CB_Proje_Olustur_Musteri_Firma.Text == "")
        //    {
        //        DialogResult result = MessageBox.Show("Müşteri Firma seçimi yapılmadı! Lütfen seçim yapınız. " +
        //             "Eğer listede aradığınız müşteri firmayı bulamadıysanız yöneticinize danışarak yeni " +
        //             "'Müşteri Firma Klasörü' oluşturabilirsiniz.",
        //             "Uyarı! Eksik Parametre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    else
        //    {
        //        Karakter_TRtoENG();
        //        CreateFolder();
        //    }


        //}

        //private void B_Proje_Olustur_Temizle_Click(object sender, EventArgs e)
        //{
        //    ProjeOlusturTemizle();
        //}

        //private void CB_Proje_Olustur_Musteri_Firma_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if(Lb_Uyari.Text != "") { ProjeOlusturTemizle(); }
        //}

        //public void ProjeOlusturTemizle()
        //{
        //    TB_Proje_Olustur_Proje_Adi.Text = "";
        //    TB_Proje_Olustur_Proje_Donemi.Text = "";
        //    //TB_Proje_Olustur_Proje_Kodu_Simgesi.Text = "";
        //    TB_Proje_Olustur_Bölüm.Text = "";
        //    CHB_Proje_Olustur_Proje_Donemi_Degistir.Checked = false;
        //    CHB_Proje_Olustur_Proje_Kodu_Degistir.Checked = false;
        //    CB_Proje_Olustur_Musteri_Firma.Text = "";
        //    Lb_Uyari.Text = "";
        //}

        //public void CreateFolder()
        //{

        //    Dizin_Musteri_Firma = Anadizin + CB_Proje_Olustur_Musteri_Firma.Text;

        //    string Proje_Olustur_Bolum_Knt;
        //    if (TB_Proje_Olustur_Bölüm.Text != "")
        //    { Proje_Olustur_Bolum_Knt = TB_Proje_Olustur_Bölüm.Text + " "; }
        //    else { Proje_Olustur_Bolum_Knt = TB_Proje_Olustur_Bölüm.Text; }

        //    Dizin_Proje = Dizin_Musteri_Firma + "\\" + TB_Proje_Olustur_Proje_Kodu_Simgesi.Text + Num_Proje_Olustur_Proje_Kodu_NO.Text + " " + CB_Proje_Olustur_Musteri_Firma.Text + " - " + Proje_Olustur_Bolum_Knt + TB_Proje_Olustur_Proje_Adi.Text;

        //    if (!Directory.Exists(Dizin_Proje))
        //    {
        //        Directory.CreateDirectory(Dizin_Proje);
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri); //P1 Musteriden Gelenler
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri + "\\E-Mailler");
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri + "\\Musteri Talebi ve Degisiklikleri");
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri + "\\Musteriden Gelen Belgeler");
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri + "\\Musteriden Gelen Belgeler");
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri + Dizin_Teklif_Belgeleri);
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri + Dizin_Teklif_Belgeleri + "\\Musteriden Alinan Teklif Onayi");
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri + Dizin_Teklif_Belgeleri + "\\Musteriye Verilen Teklifler");

        //        Directory.CreateDirectory(Dizin_Proje + Dizin_IsZaman_Plani);

        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Elektrik_Projesi);

        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim);
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PLC_Program);
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PLC_Program + "\\00 Guncel");
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PLC_Program + "\\01 Yedek");
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PLC_Program + "\\02 IO Listesi");
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_HMI_Program);
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_HMI_Program + "\\00 Guncel");
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_HMI_Program + "\\01 Yedek");
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_HMI_Program + "\\02 Inport-Export");
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_SCADA_Program);
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_SCADA_Program + "\\00 Guncel");
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_SCADA_Program + "\\01 Yedek");
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_SCADA_Program + "\\02 Inport-Export");
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PC_Program);
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PC_Program + "\\00 Guncel");
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PC_Program + "\\01 Yedek");
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PC_Program + "\\02 Dokumanlar Ornekler");
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_Yardimci_Program);

        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Servis_Egitim_Formlari);

        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Dokumanlar);
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Dokumanlar + Dizim_Kullanim_Kilavuzlari);
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Dokumanlar + Dizin_Cizim);
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Dokumanlar + Dizin_Diger_Dokumanlar);
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Dokumanlar + Dizin_FotografVideo);
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Dokumanlar + Dizin_Malzeme_Listesi);
        //        Directory.CreateDirectory(Dizin_Proje + Dizin_Dokumanlar + Dizim_Toplanti_Notlari);


        //        Lb_Uyari.Text = "Oluşturulan Yeni Proje Dizini: " + Dizin_Proje;


        //        //if (XLComm == null)
        //        //{
        //        //    MessageBox.Show("Galiba Excel yüklü değil. Proje Künyesi 'Excel' dosyasına kaydedilir. Bilgisayarınıza 'Excel' yükledikten sonra işlemi tekrar deneyiniz.");
        //        //    return;
        //        //}

        //        //Excel.Workbook xlWorkBook;
        //        //Excel.Worksheet xlWorkSheet;
        //        //object misValue = System.Reflection.Missing.Value;

        //        //xlWorkBook = XLComm.Workbooks.Add(misValue);
        //        //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
        //        //xlWorkSheet.Cells[1, 1] = "NO"; xlWorkSheet.Cells[2, 1] = "1";
        //        //xlWorkSheet.Cells[1, 2] = "TARİH"; xlWorkSheet.Cells[2, 2] = DateTime.Now.ToLongDateString();
        //        //xlWorkSheet.Cells[1, 3] = "YETKİLİ"; xlWorkSheet.Cells[2, 3] = TB_Kullanici.Text;
        //        //xlWorkSheet.Cells[1, 4] = "İŞLEM"; xlWorkSheet.Cells[2, 4] = "Yeni Proje Oluşturma";
        //        //xlWorkSheet.Cells[1, 5] = "AÇIKLAMA"; xlWorkSheet.Cells[2, 5] = "Yeni Proje Oluşturuldu. Proje için gereken klasörler hazırlandı.";

        //        //xlWorkBook.SaveAs(Dizin_Proje + "\\" + "PROJE KUNYESI - " + "P" + Num_Proje_Olustur_Proje_Kodu_NO.Text + " " + TB_Proje_Olustur_Proje_Adi.Text + ".xls",
        //        //                 Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
        //        //                 Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
        //        //xlWorkBook.Close(true, misValue, misValue);
        //        //XLComm.Quit();

        //        //try
        //        //{
        //        //    System.Runtime.InteropServices.Marshal.ReleaseComObject(XLComm);
        //        //    XLComm = null;
        //        //}
        //        //catch (Exception ex)
        //        //{
        //        //    XLComm = null;
        //        //    MessageBox.Show("Hata " + ex.ToString());
        //        //}
        //        //finally
        //        //{
        //        //    GC.Collect();
        //        //}
        //        YeniExcelDosyasiOlustur();

        //    }
        //    else
        //    {
        //        Lb_Uyari.Text = "Yazdığınız Proje adı kullanılıyor. \nLütfen kontrol ederek tekrar deneyiniz.";
        //    }

        //}


        //void YeniExcelDosyasiOlustur()
        //{
        //    DataTable TempDT = new DataTable();
        //    TempDT.Columns.Clear();
        //    TempDT.Columns.Add("NO");
        //    TempDT.Columns.Add("TARIH");
        //    TempDT.Columns.Add("YETKILI");
        //    TempDT.Columns.Add("ISLEM");
        //    TempDT.Columns.Add("ACIKLAMA");

        //    DataRow rowlar = TempDT.NewRow();
        //    rowlar[0] = "1";
        //    rowlar[1] = DateTime.Now.ToLongDateString();
        //    rowlar[2] = TB_Kullanici.Text;
        //    rowlar[3] = "Yeni Proje Oluşturma";
        //    rowlar[4] = "Yeni Proje Oluşturuldu. Proje için gereken klasörler hazırlandı.";
        //    TempDT.Rows.Add(rowlar);

        //    DataGridView TempDGV = new DataGridView();

        //    TempDGV.DataSource = TempDT;
        //    string Status = "";

        //    string KayitYolu = Dizin_Proje + "\\";
        //    string ExcelFileName = "PROJE KUNYESI - " + TB_Proje_Olustur_Proje_Kodu_Simgesi.Text + Num_Proje_Olustur_Proje_Kodu_NO.Text + " " + TB_Proje_Olustur_Bölüm.Text + " " + TB_Proje_Olustur_Proje_Adi.Text;

        //    SAVE_EXCEL(KayitYolu, ExcelFileName, "xls", TempDGV, false, out Status);
        //}




    
        void Karakter_TRtoENG()
        {
            //TB_Proje_Olustur_Bölüm.Text = ingilizcelestir(TB_Proje_Olustur_Bölüm.Text);
            //TB_Proje_Olustur_Proje_Adi.Text = ingilizcelestir(TB_Proje_Olustur_Proje_Adi.Text);
        }


        //private void TB_Proje_Olustur_Bölüm_TextChanged(object sender, EventArgs e)
        //{
        //    TB_Proje_Olustur_Bölüm.CharacterCasing = CharacterCasing.Upper;

        //}

        //private void TB_Proje_Olustur_Proje_Adi_TextChanged(object sender, EventArgs e)
        //{
        //    TB_Proje_Olustur_Proje_Adi.CharacterCasing = CharacterCasing.Upper;


        //    if (CHB_Proje_Olustur_Proje_Donemi_Degistir.Checked == false)
        //    {
        //        if (DateTime.Now.Month.ToString().Length < 2)
        //        { TB_Proje_Olustur_Proje_Donemi.Text = DateTime.Now.Year.ToString().Substring(2) + ".0" + DateTime.Now.Month.ToString(); }
        //        else
        //        { TB_Proje_Olustur_Proje_Donemi.Text = DateTime.Now.Year.ToString().Substring(2) + "." + DateTime.Now.Month.ToString(); }
        //    }

        //}

        //private void CHB_Proje_Olustur_Proje_Donemi_Degistir_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (CHB_Proje_Olustur_Proje_Donemi_Degistir.Checked == true)
        //    {
        //        TB_Proje_Olustur_Proje_Donemi.ReadOnly = false;
        //        CHB_Proje_Olustur_Proje_Donemi_Degistir.Text = "Değiştir - DİKKAT!";
        //    }
        //    else
        //    {
        //        TB_Proje_Olustur_Proje_Donemi.ReadOnly = true;
        //        CHB_Proje_Olustur_Proje_Donemi_Degistir.Text = "Değiştir";
        //    }
        //}

        //private void CHB_Proje_Olustur_Proje_Kodu_Degistir_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (CHB_Proje_Olustur_Proje_Kodu_Degistir.Checked == true)
        //    {
        //        Num_Proje_Olustur_Proje_Kodu_NO.ReadOnly = false;
        //        Num_Proje_Olustur_Proje_Kodu_NO.Enabled = true;
        //        CHB_Proje_Olustur_Proje_Kodu_Degistir.Text = "Değiştir - DİKKAT!";
        //    }
        //    else
        //    {
        //        Num_Proje_Olustur_Proje_Kodu_NO.ReadOnly = true;
        //        Num_Proje_Olustur_Proje_Kodu_NO.Enabled = false;
        //        CHB_Proje_Olustur_Proje_Kodu_Degistir.Text = "Değiştir";
        //    }

        //}

        //private void B_Proje_Olustur_Internet_Knt_Click(object sender, EventArgs e)
        //{
        //    InternetKontrol();
        //}

#endregion

#region PROJE_SORGULAMA

        private void CB_MusteriFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_Proje.Text = "";
            CB_Proje.Items.Clear();

        }

        private void CB_MusteriFirma_MouseDown(object sender, MouseEventArgs e)
        {
            CB_MusteriFirma.Items.Clear();

            try
            {
                //string[] dosya = Directory.GetDirectories(Anadizin);
                //for (int a = 0; a < dosya.Length; a++)
                //{
                //    string MusteriFirma_Klasorleri = dosya[a];
                //    string TemizAnaDizin = Anadizin;
                //    MusteriFirma_Klasorleri = MusteriFirma_Klasorleri.Replace(TemizAnaDizin, "");
                //    CB_MusteriFirma.Items.Add(MusteriFirma_Klasorleri);
                //}
            }
            catch
            {


            }

        }

        private void CB_Proje_MouseDown(object sender, MouseEventArgs e)
        {
            CB_Proje.Items.Clear();
            if (CB_MusteriFirma.Text != "")
            {
                //string[] dosya = Directory.GetDirectories(Anadizin + CB_MusteriFirma.Text);
                //for (int a = 0; a < dosya.Length; a++)
                //{
                //    string Proje_Klasorleri = dosya[a];
                //    string KaldirilacakBolum = Anadizin + CB_MusteriFirma.Text + "\\";
                //    Proje_Klasorleri = Proje_Klasorleri.Replace(KaldirilacakBolum, "");

                //    CB_Proje.Items.Add(Proje_Klasorleri);
                //}
            }
        }

        //public void ReadDirectory()
        //{
        //    listView1.Items.Clear();
        //    //GetFiles metodu dosyaları temsil eder. Belirtilen Dizindeki Dosyaları Dizi olarak döndürür
        //    //  string[] dosyalar = System.IO.Directory.GetFiles("C:\\");

        //    string[] dosyalar = Directory.GetFiles(@"e:\", "*.txt", SearchOption.AllDirectories);

        //    for (int j = 0; j < dosyalar.Length; j++)
        //    {
        //        //klasörler dizisinin i. elemanı listboxa ekle
        //        listBox1.Items.Add(dosyalar[j]);
        //        //    listView1.Items.Add(dosyalar[j]);
        //    }

        //}

        public void OpenFolder()
        {
            string myDocspath = "DosyaYolunu yazıyoruz"; // Buraya istediğimiz dosyanın yolunu yazıyorz
            string windir = Environment.GetEnvironmentVariable("WINDIR");
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = windir + @"\explorer.exe";
            prc.StartInfo.Arguments = myDocspath;
            prc.Start();
        }


        private void B_Ara_Click(object sender, EventArgs e)
        {
            LB_Sorgu_Hata_Bildirimi.Text = "";
            if (CB_MusteriFirma.Text != "" && CB_Proje.Text != "")
            {
               // ReadDirectory();

                Sorgulama();

            }



            if (ChB_PrjSorgu_PLC_Program.Checked || ChB_PrjSorgu_HMI_Program.Checked || ChB_PrjSorgu_SCADA_Program.Checked ||
                 ChB_PrjSorgu_YARD_Program.Checked || ChB_PrjSorgu_Malzeme_Listesi.Checked || ChB_PrjSorgu_Elektrik_Projesi.Checked ||
                 ChB_PrjSorgu_Cizimler.Checked || ChB_PrjSorgu_PC_Program.Checked || ChB_PrjSorgu_Musteri_Iliskileri.Checked ||
                 ChB_PrjSorgu_Teklif_Belgeleri.Checked || ChB_PrjSorgu_Servis_Egitim_Formlari.Checked || ChB_PrjSorgu_Dokumanlar.Checked ||
                 ChB_PrjSorgu_FotografVideo.Checked || ChB_PrjSorgu_Is_Zaman_Plani.Checked)
            {
                LB_Dosya_NitelikSecilmedi.Visible = false;

            }
            else
            {
                LB_Dosya_NitelikSecilmedi.Visible = true;
                LB_Sorgu_Hata_Bildirimi.Text = "Arama Kriteri Seçilmedi. Dosyalar neye göre getirilecek? Lütfen 'Dosya Niteliği' bölümünden bir seçim yapınız.";
            }

            if (CB_Proje.Text == "") { LB_PrjSorgu_Proje.ForeColor = Color.Red; LB_Sorgu_Hata_Bildirimi.Text = "Proje Seçilmedi! Lütfen 'Proje' seçimi yapınız."; }
            else { LB_PrjSorgu_Proje.ForeColor = Color.Black; }
            if (CB_MusteriFirma.Text == "") { LB_PrjSorgu_MusteriFirma.ForeColor = Color.Red; LB_Sorgu_Hata_Bildirimi.Text = "Müşteri Firma Seçilmedi! Lütfen ilk önce 'Müşteri Firma' seçimini yapınız."; }
            else { LB_PrjSorgu_MusteriFirma.ForeColor = Color.Black; }



        }


        public static long KlasorBoyutKontrol(DirectoryInfo yol)
        {
            return yol.GetFiles().Sum(fi => fi.Length) +
            yol.GetDirectories().Sum(di => KlasorBoyutKontrol(di));

        }



        public void Sorgulama()
        {
            FLayoutPanel.Controls.Clear();

            //Klasor_Musteri_Iliskileri = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Musteri_Iliskileri;
            //Klasor_Teklif_Belgeleri = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Musteri_Iliskileri + Dizin_Teklif_Belgeleri;
            //Klasor_Servis_Egitim_Formlari = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Servis_Egitim_Formlari;

            //Klasor_PLC_Program = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Yazilim + Dizin_PLC_Program;
            //Klasor_HMI_Program = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Yazilim + Dizin_HMI_Program;
            //Klasor_SCADA_Program = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Yazilim + Dizin_SCADA_Program;
            //Klasor_YARD_Program = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Yazilim + Dizin_Yardimci_Program;
            //Klasor_PC_Program = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Yazilim + Dizin_PC_Program;

            //Klasor_Elektrik_Projesi = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Elektrik_Projesi;

            //Klasor_Malzeme_Listesi = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Dokumanlar + Dizin_Malzeme_Listesi;

            //Klasor_Dokumanlar = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Dokumanlar;
            //Klasor_Cizimler = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Dokumanlar + Dizin_Cizim;
            //Klasor_Diger_Dokumanlar = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Dokumanlar + Dizin_Diger_Dokumanlar;
            //Klasor_FotografVideo = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Dokumanlar + Dizin_FotografVideo;
            //Klasor_Is_Zaman_Plani = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_IsZaman_Plani; ;
            //Klasor_Tum_Dokumanlar = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text;

            try
            {
                ////=================================================================
                ////=================================================================
                //if (ChB_PrjSorgu_PLC_Program.Checked)
                //{
                //    DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_PLC_Program);
                //    long boyutyol = KlasorBoyutKontrol(klasoryolu);
                //    string[] NesneTextleri = new string[10];
                //    if (boyutyol == 0)
                //    { NesneTextleri[0] = " PLC Programı - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                //    else
                //    { NesneTextleri[0] = " PLC Programı "; }

                //    NesneTextleri[1] = Klasor_PLC_Program;
                //    NesneTextleri[2] = "B_Geri_PLC_Program";
                //    NesneTextleri[3] = "B_Ac_PLC_Program";
                //    NesneTextleri[4] = "B_LinkCopy_PLC_Program";
                //    NesneTextleri[5] = "WB_PLC_Program";
                //    NesneTextleri[6] = "";
                //    NesneTextleri[7] = "";
                //    NesneTextleri[8] = "";
                //    NesneTextleri[9] = "";
                //    if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                //    {
                //        KlasorSorguCevabiListele(Grp_PLC_Program, WB_PLC_Program, B_PLC_Program_Geri, B_PLC_Program_Ac, B_PLC_Program_CopyLink, NesneTextleri);
                //    }
                //}

                ////=================================================================
                ////=================================================================
                //if (ChB_PrjSorgu_HMI_Program.Checked)
                //{
                //    DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_HMI_Program);
                //    long boyutyol = KlasorBoyutKontrol(klasoryolu);
                //    string[] NesneTextleri = new string[10];
                //    if (boyutyol == 0)
                //    { NesneTextleri[0] = " HMI Programı - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                //    else
                //    { NesneTextleri[0] = " HMI Programı "; }
                //    NesneTextleri[1] = Klasor_HMI_Program;
                //    NesneTextleri[2] = "B_Geri_HMI_Program";
                //    NesneTextleri[3] = "B_Ac_HMI_Program";
                //    NesneTextleri[4] = "B_LinkCopy_HMI_Program";
                //    NesneTextleri[5] = "WB_HMI_Program";
                //    NesneTextleri[6] = "";
                //    NesneTextleri[7] = "";
                //    NesneTextleri[8] = "";
                //    NesneTextleri[9] = "";
                //    if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                //    {
                //        KlasorSorguCevabiListele(Grp_HMI_Program, WB_HMI_Program, B_HMI_Program_Geri, B_HMI_Program_Ac, B_HMI_Program_CopyLink, NesneTextleri);
                //    }
                //}

                ////=================================================================
                ////=================================================================
                //if (ChB_PrjSorgu_SCADA_Program.Checked)
                //{
                //    DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_SCADA_Program);
                //    long boyutyol = KlasorBoyutKontrol(klasoryolu);
                //    string[] NesneTextleri = new string[10];
                //    if (boyutyol == 0)
                //    { NesneTextleri[0] = " SCADA Programı - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                //    else
                //    { NesneTextleri[0] = " SCADA Programı "; }
                //    NesneTextleri[1] = Klasor_SCADA_Program;
                //    NesneTextleri[2] = "B_Geri_SCADA_Program";
                //    NesneTextleri[3] = "B_Ac_SCADA_Program";
                //    NesneTextleri[4] = "B_LinkCopy_SCADA_Program";
                //    NesneTextleri[5] = "WB_SCADA_Program";
                //    NesneTextleri[6] = "";
                //    NesneTextleri[7] = "";
                //    NesneTextleri[8] = "";
                //    NesneTextleri[9] = "";
                //    if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                //    {
                //        KlasorSorguCevabiListele(Grp_SCADA_Program, WB_SCADA_Program, B_SCADA_Program_Geri, B_SCADA_Program_Ac, B_SCADA_Program_CopyLink, NesneTextleri);
                //    }
                //}


                ////=================================================================
                ////=================================================================
                //if (ChB_PrjSorgu_YARD_Program.Checked)
                //{
                //    DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_YARD_Program);
                //    long boyutyol = KlasorBoyutKontrol(klasoryolu);
                //    string[] NesneTextleri = new string[10];
                //    if (boyutyol == 0)
                //    { NesneTextleri[0] = " Yardımcı Programlar - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                //    else
                //    { NesneTextleri[0] = " Yardımcı Programlar "; }
                //    NesneTextleri[1] = Klasor_YARD_Program;
                //    NesneTextleri[2] = "B_Geri_YARD_Program";
                //    NesneTextleri[3] = "B_Ac_YARD_Program";
                //    NesneTextleri[4] = "B_LinkCopy_YARD_Program";
                //    NesneTextleri[5] = "WB_YARD_Program";
                //    NesneTextleri[6] = "";
                //    NesneTextleri[7] = "";
                //    NesneTextleri[8] = "";
                //    NesneTextleri[9] = "";
                //    if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                //    {
                //        KlasorSorguCevabiListele(Grp_YARD_Program, WB_YARD_Program, B_YARD_Program_Geri, B_YARD_Program_Ac, B_YARD_Program_CopyLink, NesneTextleri);
                //    }
                //}

                ////=================================================================
                ////=================================================================
                //if (ChB_PrjSorgu_PC_Program.Checked)
                //{
                //    DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_PC_Program);
                //    long boyutyol = KlasorBoyutKontrol(klasoryolu);
                //    string[] NesneTextleri = new string[10];
                //    if (boyutyol == 0)
                //    { NesneTextleri[0] = " PC Programları - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                //    else
                //    { NesneTextleri[0] = " PC Programları "; }
                //    NesneTextleri[1] = Klasor_PC_Program;
                //    NesneTextleri[2] = "B_Geri_PC_Program";
                //    NesneTextleri[3] = "B_Ac_PC_Program";
                //    NesneTextleri[4] = "B_LinkCopy_PC_Program";
                //    NesneTextleri[5] = "WB_PC_Program";
                //    NesneTextleri[6] = "";
                //    NesneTextleri[7] = "";
                //    NesneTextleri[8] = "";
                //    NesneTextleri[9] = "";
                //    if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                //    {
                //        KlasorSorguCevabiListele(Grp_PC_Program, WB_PC_Program, B_PC_Program_Geri, B_PC_Program_Ac, B_PC_Program_CopyLink, NesneTextleri);
                //    }
                //}

                ////=================================================================
                ////=================================================================
                //if (ChB_PrjSorgu_Malzeme_Listesi.Checked)
                //{
                //    DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_Malzeme_Listesi);
                //    long boyutyol = KlasorBoyutKontrol(klasoryolu);
                //    string[] NesneTextleri = new string[10];
                //    if (boyutyol == 0)
                //    { NesneTextleri[0] = " Malzeme Listesi - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                //    else
                //    { NesneTextleri[0] = " Malzeme Listesi "; }
                //    NesneTextleri[1] = Klasor_Malzeme_Listesi;
                //    NesneTextleri[2] = "B_Geri_Malzeme_Listesi";
                //    NesneTextleri[3] = "B_Ac_Malzeme_Listesi";
                //    NesneTextleri[4] = "B_LinkCopy_Malzeme_Listesi";
                //    NesneTextleri[5] = "WB_Malzeme_Listesi";
                //    NesneTextleri[6] = "";
                //    NesneTextleri[7] = "";
                //    NesneTextleri[8] = "";
                //    NesneTextleri[9] = "";
                //    if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                //    {
                //        KlasorSorguCevabiListele(Grp_Malzeme_Listesi, WB_Malzeme_Listesi, B_Malzeme_Listesi_Geri, B_Malzeme_Listesi_Ac, B_Malzeme_Listesi_CopyLink, NesneTextleri);
                //    }
                //}


                ////=================================================================
                ////=================================================================
                //if (ChB_PrjSorgu_Elektrik_Projesi.Checked)
                //{
                //    DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_Elektrik_Projesi);
                //    long boyutyol = KlasorBoyutKontrol(klasoryolu);
                //    string[] NesneTextleri = new string[10];
                //    if (boyutyol == 0)
                //    { NesneTextleri[0] = " Elektrik Projesi - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                //    else
                //    { NesneTextleri[0] = " Elektrik Projesi "; }
                //    NesneTextleri[1] = Klasor_Elektrik_Projesi;
                //    NesneTextleri[2] = "B_Geri_Elektrik_Projesi";
                //    NesneTextleri[3] = "B_Ac_Elektrik_Projesi";
                //    NesneTextleri[4] = "B_LinkCopy_Elektrik_Projesi";
                //    NesneTextleri[5] = "WB_Elektrik_Projesi";
                //    NesneTextleri[6] = "";
                //    NesneTextleri[7] = "";
                //    NesneTextleri[8] = "";
                //    NesneTextleri[9] = "";
                //    if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                //    {
                //        KlasorSorguCevabiListele(Grp_Elektrik_Projesi, WB_Elektrik_Projesi, B_Elektrik_Projesi_Geri, B_Elektrik_Projesi_Ac, B_Elektrik_Projesi_CopyLink, NesneTextleri);
                //    }
                //}

                ////=================================================================
                ////=================================================================
                //if (ChB_PrjSorgu_Cizimler.Checked)
                //{
                //    DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_Cizimler);
                //    long boyutyol = KlasorBoyutKontrol(klasoryolu);
                //    string[] NesneTextleri = new string[10];
                //    if (boyutyol == 0)
                //    { NesneTextleri[0] = " Çizimler - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                //    else
                //    { NesneTextleri[0] = " Çizimler "; }
                //    NesneTextleri[1] = Klasor_Cizimler;
                //    NesneTextleri[2] = "B_Geri_Cizimler";
                //    NesneTextleri[3] = "B_Ac_Cizimler";
                //    NesneTextleri[4] = "B_LinkCopy_Cizimler";
                //    NesneTextleri[5] = "WB_Cizimler";
                //    NesneTextleri[6] = "";
                //    NesneTextleri[7] = "";
                //    NesneTextleri[8] = "";
                //    NesneTextleri[9] = "";
                //    if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                //    {
                //        KlasorSorguCevabiListele(Grp_Cizimler, WB_Cizimler, B_Cizimler_Geri, B_Cizimler_Ac, B_Cizimler_CopyLink, NesneTextleri);
                //    }
                //}


                ////=================================================================
                ////=================================================================
                //if (ChB_PrjSorgu_Musteri_Iliskileri.Checked)
                //{
                //    DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_Musteri_Iliskileri);
                //    long boyutyol = KlasorBoyutKontrol(klasoryolu);
                //    string[] NesneTextleri = new string[10];
                //    if (boyutyol == 0)
                //    { NesneTextleri[0] = " Müşteri İlişkileri - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                //    else
                //    { NesneTextleri[0] = " Müşteri İlişkileri "; }
                //    NesneTextleri[1] = Klasor_Musteri_Iliskileri;
                //    NesneTextleri[2] = "B_Geri_Musteri_Iliskileri";
                //    NesneTextleri[3] = "B_Ac_Musteri_Iliskileri";
                //    NesneTextleri[4] = "B_LinkCopy_Musteri_Iliskileri";
                //    NesneTextleri[5] = "WB_Musteri_Iliskileri";
                //    NesneTextleri[6] = "";
                //    NesneTextleri[7] = "";
                //    NesneTextleri[8] = "";
                //    NesneTextleri[9] = "";
                //    if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                //    {
                //        KlasorSorguCevabiListele(Grp_Musteri_Iliskileri, WB_Musteri_Iliskileri, B_Musteri_Iliskileri_Geri, B_Musteri_Iliskileri_Ac, B_Musteri_Iliskileri_CopyLink, NesneTextleri);
                //    }
                //}


                ////=================================================================
                ////=================================================================
                //if (ChB_PrjSorgu_Teklif_Belgeleri.Checked)
                //{
                //    DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_Teklif_Belgeleri);
                //    long boyutyol = KlasorBoyutKontrol(klasoryolu);
                //    string[] NesneTextleri = new string[10];
                //    if (boyutyol == 0)
                //    { NesneTextleri[0] = " Teklif Belgeleri - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                //    else
                //    { NesneTextleri[0] = " Teklif Belgeleri "; }
                //    NesneTextleri[1] = Klasor_Teklif_Belgeleri;
                //    NesneTextleri[2] = "B_Geri_Teklif_Belgeleri";
                //    NesneTextleri[3] = "B_Ac_Teklif_Belgeleri";
                //    NesneTextleri[4] = "B_LinkCopy_Teklif_Belgeleri";
                //    NesneTextleri[5] = "WB_Teklif_Belgeleri";
                //    NesneTextleri[6] = "";
                //    NesneTextleri[7] = "";
                //    NesneTextleri[8] = "";
                //    NesneTextleri[9] = "";
                //    if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                //    {
                //        KlasorSorguCevabiListele(Grp_Teklif_Belgeleri, WB_Teklif_Belgeleri, B_Teklif_Belgeleri_Geri, B_Teklif_Belgeleri_Ac, B_Teklif_Belgeleri_CopyLink, NesneTextleri);
                //    }
                //}

                ////=================================================================
                ////=================================================================
                //if (ChB_PrjSorgu_Servis_Egitim_Formlari.Checked)
                //{
                //    DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_Servis_Egitim_Formlari);
                //    long boyutyol = KlasorBoyutKontrol(klasoryolu);
                //    string[] NesneTextleri = new string[10];
                //    if (boyutyol == 0)
                //    { NesneTextleri[0] = " Servis Eğitim Formları - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                //    else
                //    { NesneTextleri[0] = " Servis Eğitim Formları "; }
                //    NesneTextleri[1] = Klasor_Servis_Egitim_Formlari;
                //    NesneTextleri[2] = "B_Geri_Servis_Egitim_Formlari";
                //    NesneTextleri[3] = "B_Ac_Servis_Egitim_Formlari";
                //    NesneTextleri[4] = "B_LinkCopy_Servis_Egitim_Formlari";
                //    NesneTextleri[5] = "WB_Servis_Egitim_Formlari";
                //    NesneTextleri[6] = "";
                //    NesneTextleri[7] = "";
                //    NesneTextleri[8] = "";
                //    NesneTextleri[9] = "";
                //    if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                //    {
                //        KlasorSorguCevabiListele(Grp_Servis_Egitim_Formlari, WB_Servis_Egitim_Formlari, B_Servis_Egitim_Formlari_Geri, B_Servis_Egitim_Formlari_Ac, B_Servis_Egitim_Formlari_CopyLink, NesneTextleri);
                //    }
                //}

                ////=================================================================
                ////=================================================================
                //if (ChB_PrjSorgu_Dokumanlar.Checked)
                //{
                //    DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_Dokumanlar);
                //    long boyutyol = KlasorBoyutKontrol(klasoryolu);
                //    string[] NesneTextleri = new string[10];
                //    if (boyutyol == 0)
                //    { NesneTextleri[0] = " Dökümanlar - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                //    else
                //    { NesneTextleri[0] = " Dökümanlar "; }
                //    NesneTextleri[1] = Klasor_Dokumanlar;
                //    NesneTextleri[2] = "B_Geri_Dokumanlar";
                //    NesneTextleri[3] = "B_Ac_Dokumanlar";
                //    NesneTextleri[4] = "B_LinkCopy_Dokumanlar";
                //    NesneTextleri[5] = "WB_Dokumanlar";
                //    NesneTextleri[6] = "";
                //    NesneTextleri[7] = "";
                //    NesneTextleri[8] = "";
                //    NesneTextleri[9] = "";
                //    if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                //    {
                //        KlasorSorguCevabiListele(Grp_Dokumanlar, WB_Dokumanlar, B_Dokumanlar_Geri, B_Dokumanlar_Ac, B_Dokumanlar_CopyLink, NesneTextleri);
                //    }
                //}

                ////=================================================================
                ////=================================================================
                //if (ChB_PrjSorgu_FotografVideo.Checked)
                //{
                //    DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_FotografVideo);
                //    long boyutyol = KlasorBoyutKontrol(klasoryolu);
                //    string[] NesneTextleri = new string[10];
                //    if (boyutyol == 0)
                //    { NesneTextleri[0] = " Fotoğraf ve Video - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                //    else
                //    { NesneTextleri[0] = " Fotoğraflar "; }
                //    NesneTextleri[1] = Klasor_FotografVideo;
                //    NesneTextleri[2] = "B_Geri_FotografVideo";
                //    NesneTextleri[3] = "B_Ac_FotografVideo";
                //    NesneTextleri[4] = "B_LinkCopy_FotografVideo";
                //    NesneTextleri[5] = "WB_FotografVideo";
                //    NesneTextleri[6] = "";
                //    NesneTextleri[7] = "";
                //    NesneTextleri[8] = "";
                //    NesneTextleri[9] = "";
                //    if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                //    {
                //        KlasorSorguCevabiListele(Grp_FotografVideo, WB_FotografVideo, B_FotografVideo_Geri, B_FotografVideo_Ac, B_FotografVideo_CopyLink, NesneTextleri);
                //    }
                //}

                ////=================================================================
                ////=================================================================
                //if (ChB_PrjSorgu_Is_Zaman_Plani.Checked)
                //{
                //    DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_Is_Zaman_Plani);
                //    long boyutyol = KlasorBoyutKontrol(klasoryolu);
                //    string[] NesneTextleri = new string[10];
                //    if (boyutyol == 0)
                //    { NesneTextleri[0] = " İş - Zaman Planı - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                //    else
                //    { NesneTextleri[0] = " İş - Zaman Planı "; }
                //    NesneTextleri[1] = Klasor_Is_Zaman_Plani;
                //    NesneTextleri[2] = "B_Geri_Is_Zaman_Plani";
                //    NesneTextleri[3] = "B_Ac_Is_Zaman_Plani";
                //    NesneTextleri[4] = "B_LinkCopy_Is_Zaman_Plani";
                //    NesneTextleri[5] = "WB_Is_Zaman_Plani";
                //    NesneTextleri[6] = "";
                //    NesneTextleri[7] = "";
                //    NesneTextleri[8] = "";
                //    NesneTextleri[9] = "";
                //    if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                //    {
                //        KlasorSorguCevabiListele(Grp_Is_Zaman_Plani, WB_Is_Zaman_Plani, B_Is_Zaman_Plani_Geri, B_Is_Zaman_Plani_Ac, B_Is_Zaman_Plani_CopyLink, NesneTextleri);
                //    }
                //}

            }
            catch
            {
                LB_Sorgu_Hata_Bildirimi.Text = " Hay Aksi! Arama yapılan dizinde bir problem var gibi gözüküyor. Kontrol edilmesi gerekir." +
                    "Bir klasör silinmiş, taşınmış olabilir ya da bir klasör adı standart dışı.";
            }

        }


        public void KlasorSorguCevabiListele(GroupBox Grup, WebBrowser WBrowser, Button BGeri, Button BAc, Button LinkCpy, string[] Textler) //  string URL, string GrupAdi,  )
        {
            //Textler[0] Grup ADI
            //Textler[1] Klasör URL
            //Textler[2] Buton Geri Name
            //Textler[3] Buton Ac Name
            //Textler[4] Buton Link Copy Name
            //Textler[5] Web Browser Name
            //Textler[6] 
            //Textler[7] 
            //Textler[8] 
            //Textler[9] 

            // GRUP
            System.Windows.Forms.GroupBox g = new System.Windows.Forms.GroupBox();
            Grup.Text = Textler[0];
            Grup.Size = new Size(422, 160);

            // BROWSER
            System.Windows.Forms.WebBrowser Wb = new System.Windows.Forms.WebBrowser();
            WBrowser.Name = Textler[5];
            WBrowser.Location = new Point(2, 20);
            WBrowser.Size = new Size(381, 138);
            WBrowser.Url = new Uri(Textler[1]);
            Grup.Controls.Add(WBrowser);

            // BUTON - GERİ
            System.Windows.Forms.Button BtnGeri = new System.Windows.Forms.Button();
            BGeri.Name = Textler[2];
            BGeri.Text = "Geri";
            BGeri.Location = new Point(383, 100);
            BGeri.Size = new Size(40, 22);
            BGeri.Click += new EventHandler(ButonGeri); // dinamik olarak oluşturulan butonu kontrol etmek için her oluşturulan butonun clik olayına atıyoruz.
            Grup.Controls.Add(BGeri);

            // BUTON - LİNK COPY
            System.Windows.Forms.Button BLinkCpy = new System.Windows.Forms.Button();
            LinkCpy.Name = Textler[4];
            LinkCpy.Text = " Link\nCopy";
            LinkCpy.Location = new Point(383, 123);
            LinkCpy.Size = new Size(40, 36);
            LinkCpy.Click += new EventHandler(ButonLinkCopy); // dinamik olarak oluşturulan butonu kontrol etmek için her oluşturulan butonun clik olayına atıyoruz.
            Grup.Controls.Add(LinkCpy);

            FLayoutPanel.Controls.Add(Grup);

        }




        protected void ButonGeri(object sender, EventArgs e)
        {
            Button DinamikButon = (sender as Button);
            if (DinamikButon.Name == "B_Geri_PLC_Program" && WB_PLC_Program.CanGoBack == true) { WB_PLC_Program.GoBack(); }
            if (DinamikButon.Name == "B_Geri_HMI_Program" && WB_HMI_Program.CanGoBack == true) { WB_HMI_Program.GoBack(); }
            if (DinamikButon.Name == "B_Geri_SCADA_Program" && WB_SCADA_Program.CanGoBack == true) { WB_SCADA_Program.GoBack(); }
            if (DinamikButon.Name == "B_Geri_YARD_Program" && WB_YARD_Program.CanGoBack == true) { WB_YARD_Program.GoBack(); }
            if (DinamikButon.Name == "B_Geri_PC_Program" && WB_PC_Program.CanGoBack == true) { WB_PC_Program.GoBack(); }
            if (DinamikButon.Name == "B_Geri_Malzeme_Listesi" && WB_Malzeme_Listesi.CanGoBack == true) { WB_Malzeme_Listesi.GoBack(); }
            if (DinamikButon.Name == "B_Geri_Elektrik_Projesi" && WB_Elektrik_Projesi.CanGoBack == true) { WB_Elektrik_Projesi.GoBack(); }
            if (DinamikButon.Name == "B_Geri_Cizimler" && WB_Cizimler.CanGoBack == true) { WB_Cizimler.GoBack(); }
            if (DinamikButon.Name == "B_Geri_Musteri_Iliskileri" && WB_Musteri_Iliskileri.CanGoBack == true) { WB_Musteri_Iliskileri.GoBack(); }
            if (DinamikButon.Name == "B_Geri_Teklif_Belgeleri" && WB_Teklif_Belgeleri.CanGoBack == true) { WB_Teklif_Belgeleri.GoBack(); }
            if (DinamikButon.Name == "B_Geri_Servis_Egitim_Formlari" && WB_Servis_Egitim_Formlari.CanGoBack == true) { WB_Servis_Egitim_Formlari.GoBack(); }
            if (DinamikButon.Name == "B_Geri_Dokumanlar" && WB_Dokumanlar.CanGoBack == true) { WB_Dokumanlar.GoBack(); }
            if (DinamikButon.Name == "B_Geri_Diger_Dokumanlar" && WB_Diger_Dokumanlar.CanGoBack == true) { WB_Diger_Dokumanlar.GoBack(); }
            if (DinamikButon.Name == "B_Geri_FotografVideo" && WB_FotografVideo.CanGoBack == true) { WB_FotografVideo.GoBack(); }
            if (DinamikButon.Name == "B_Geri_Tum_Dokumanlar" && WB_Tum_Dokumanlar.CanGoBack == true) { WB_Tum_Dokumanlar.GoBack(); }
            if (DinamikButon.Name == "B_Geri_Is_Zaman_Plani" && WB_Is_Zaman_Plani.CanGoBack == true) { WB_Is_Zaman_Plani.GoBack(); }
        }

        protected void ButonLinkCopy(object sender, EventArgs e)
        {
            Button DinamikButon = (sender as Button);
            //if (DinamikButon.Name == "B_LinkCopy_PLC_Program") { Clipboard.SetText(Klasor_PLC_Program); }
            //if (DinamikButon.Name == "B_LinkCopy_HMI_Program") { Clipboard.SetText(Klasor_HMI_Program); }
            //if (DinamikButon.Name == "B_LinkCopy_SCADA_Program") { Clipboard.SetText(Klasor_SCADA_Program); }
            //if (DinamikButon.Name == "B_LinkCopy_YARD_Program") { Clipboard.SetText(Klasor_YARD_Program); }
            //if (DinamikButon.Name == "B_LinkCopy_PC_Program") { Clipboard.SetText(Klasor_PC_Program); }
            //if (DinamikButon.Name == "B_LinkCopy_Malzeme_Listesi") { Clipboard.SetText(Klasor_Malzeme_Listesi); }
            //if (DinamikButon.Name == "B_LinkCopy_Elektrik_Projesi") { Clipboard.SetText(Klasor_Elektrik_Projesi); }
            //if (DinamikButon.Name == "B_LinkCopy_Cizimler") { Clipboard.SetText(Klasor_Cizimler); }

            //if (DinamikButon.Name == "B_LinkCopy_Musteri_Iliskileri") { Clipboard.SetText(Klasor_Musteri_Iliskileri); }
            //if (DinamikButon.Name == "B_LinkCopy_Teklif_Belgeleri") { Clipboard.SetText(Klasor_Teklif_Belgeleri); }
            //if (DinamikButon.Name == "B_LinkCopy_Servis_Egitim_Formlari") { Clipboard.SetText(Klasor_Servis_Egitim_Formlari); }
            //if (DinamikButon.Name == "B_LinkCopy_Dokumanlar") { Clipboard.SetText(Klasor_Dokumanlar); }
            //if (DinamikButon.Name == "B_LinkCopy_Diger_Dokumanlar") { Clipboard.SetText(Klasor_Diger_Dokumanlar); }
            //if (DinamikButon.Name == "B_LinkCopy_FotografVideo") { Clipboard.SetText(Klasor_FotografVideo); }
            //if (DinamikButon.Name == "B_LinkCopy_Tum_Dokumanlar") { Clipboard.SetText(Klasor_Tum_Dokumanlar); }
            //if (DinamikButon.Name == "B_LinkCopy_Is_Zaman_Plani") { Clipboard.SetText(Klasor_Is_Zaman_Plani); }
        }

        private void B_NitelikSecimTemizle_Click(object sender, EventArgs e)
        {
            ChB_PrjSorgu_PLC_Program.Checked = false;
            ChB_PrjSorgu_HMI_Program.Checked = false;
            ChB_PrjSorgu_SCADA_Program.Checked = false;
            ChB_PrjSorgu_YARD_Program.Checked = false;
            ChB_PrjSorgu_Malzeme_Listesi.Checked = false;
            ChB_PrjSorgu_Elektrik_Projesi.Checked = false;
            ChB_PrjSorgu_Cizimler.Checked = false;
            ChB_PrjSorgu_PC_Program.Checked = false;
            ChB_PrjSorgu_Musteri_Iliskileri.Checked = false;
            ChB_PrjSorgu_Teklif_Belgeleri.Checked = false;
            ChB_PrjSorgu_Servis_Egitim_Formlari.Checked = false;
            ChB_PrjSorgu_Dokumanlar.Checked = false;
            ChB_PrjSorgu_FotografVideo.Checked = false;
            ChB_PrjSorgu_Is_Zaman_Plani.Checked = false;
        }

        private void B_NitelikSecimHepsiniSec_Click(object sender, EventArgs e)
        {
            ChB_PrjSorgu_PLC_Program.Checked = true;
            ChB_PrjSorgu_HMI_Program.Checked = true;
            ChB_PrjSorgu_SCADA_Program.Checked = true;
            ChB_PrjSorgu_YARD_Program.Checked = true;
            ChB_PrjSorgu_Malzeme_Listesi.Checked = true;
            ChB_PrjSorgu_Elektrik_Projesi.Checked = true;
            ChB_PrjSorgu_Cizimler.Checked = true;
            ChB_PrjSorgu_PC_Program.Checked = true;
            ChB_PrjSorgu_Musteri_Iliskileri.Checked = true;
            ChB_PrjSorgu_Teklif_Belgeleri.Checked = true;
            ChB_PrjSorgu_Servis_Egitim_Formlari.Checked = true;
            ChB_PrjSorgu_Dokumanlar.Checked = true;
            ChB_PrjSorgu_FotografVideo.Checked = true;
            ChB_PrjSorgu_Is_Zaman_Plani.Checked = true;
        }

        #endregion

#region EXCEL_TEST

        ID_DB.EXCELS PrgEXCEL = new ID_DB.EXCELS();
        //ID_DB.SQL ASD = new ID_DB.SQL();

        

        void READ_EXCEL(string ExcelFilePath, DataGridView DGV, out string Status)
        {
            Status = "";
            int KomutDurumu = PrgEXCEL.Read_FillingDGV_FromExel(ExcelFilePath, DGV);

            if (KomutDurumu == 1)
            {
                Status = "OK";
            }
            else if (KomutDurumu == -1)
            {
                Status = "ERROR";
            }
        }

        void SAVE_EXCEL(string ExcelFilePath, string ExcelFileName, string ExcelFileExtention, DataGridView DGV, bool SheckSaveAs, out string Status)
        {
            Status = "";
            int KomutDurumu = PrgEXCEL.Write_ExcelFile_FromDGV(ExcelFilePath, ExcelFileName, ExcelFileExtention, DGV, SheckSaveAs);

            if (KomutDurumu == 1)
            {
                Status = "OK";
            }
            else if (KomutDurumu == -1)
            {
                Status = "ERROR";
            }
            else if (KomutDurumu == 2)
            {
                Status = "DataRead ERROR";
            }
            else if (KomutDurumu == 3)
            {
                Status = "AYNI DOSYA VAR";
            }
        }



        private void B_EXL_NewCreate_Click(object sender, EventArgs e)
        {
            DataTable TempDT = new DataTable();
            TempDT.Columns.Clear();
            TempDT.Columns.Add("NO");
            TempDT.Columns.Add("TARIH");
            TempDT.Columns.Add("YETKILI");
            TempDT.Columns.Add("ISLEM");
            TempDT.Columns.Add("ACIKLAMA");

            DataRow rowlar = TempDT.NewRow();
            rowlar[0] = "1";
            rowlar[1] = DateTime.Now.ToLongDateString();
          //  rowlar[2] = TB_Kullanici.Text;
            rowlar[3] = "Yeni Proje Oluşturma";
            rowlar[4] = "Yeni Proje Oluşturuldu. Proje için gereken klasörler hazırlandı.";
            TempDT.Rows.Add(rowlar);

            DataGridView TempDGV = new DataGridView();

            TempDGV.DataSource = TempDT;
            string Status = "";

      //      SAVE_EXCEL(TB_EXL_KayitYolu.Text, TB_EXL_FileName.Text, CB_EXL_FileExtention.Text, TempDGV, false, out Status);
      //      LB_EXL_NewCreate.Text = Status;
        }







        #endregion




        #region CREATE PROJECT

        #region MÜŞTERİ SEÇİMİ İÇİN KULLANILAN NESNELER
        // ##### RADIO BUTTON  ##### //
        private void RB_MusteriSecim_No_CheckedChanged(object sender, EventArgs e)
                {
                    if (RB_MusteriSecim_No.Checked)
                    {
                        Panel_CrtPrj_MusteriSecimFirma_No.Visible = true;
                        CLS.CreateProject.Temizle_Musteri();
                        CLS.CreateProject.Temizle_MusteriBolum();
                        CLS.CreateProject.Temizle_YetkiliKisi();

                    }
                    else
                    {
                        Panel_CrtPrj_MusteriSecimFirma_No.Visible = false;
                        CLS.CreateProject.Temizle_Musteri();
                        CLS.CreateProject.Temizle_MusteriBolum();
                        CLS.CreateProject.Temizle_ProjeBilgileri();
                        CLS.CreateProject.Temizle_YetkiliKisi();
                    }
                }


        // ##### COMBOBOX BUTTON - MÜŞTERİ ADI  ##### //
        private void CB_CrtPrj_MusteriSecim_Ad_MouseDown(object sender, MouseEventArgs e)
        {
            CLS.CreateProject.Temizle_Musteri();
            CLS.CreateProject.Temizle_MusteriBolum();
            CLS.CreateProject.Temizle_ProjeBilgileri();
            CLS.CreateProject.Temizle_YetkiliKisi();
            CLS.CreateProject.Listele_MusteriAdi(CB_CrtPrj_MusteriSecim_Ad);
        }
        private void CB_CrtPrj_MusteriSecim_Ad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CLS.CreateProject.MusteriAdiSecildi(CB_CrtPrj_MusteriSecim_Ad.SelectedIndex, out string MusteriNo, out string MBolge, out string MAdres, out string MMapslink, out string MTel, out string Mnot, out string INFO); 
            
            TB_CrtPrj_MusteriSecim_No.Text = MusteriNo;
            TB_CrtPrj_MusteriBolge.Text = MBolge;
            TB_CrtPrj_MusteriAdres.Text = MAdres;
            TB_CrtPrj_MusteriMapsLink.Text = MMapslink;
            TB_CrtPrj_MusteriTel.Text = MTel;
            RTB_CrtPrj_MusteriNot.Text = INFO +  Mnot;

            CrtPrj_SecilenMusteriNo = MusteriNo;
            CrtPrj_SecilenMusteriAdi = CB_CrtPrj_MusteriSecim_Ad.Text;


        }


        // ##### COMBOBOX BUTTON - MÜŞTERİ NO  ##### //
        private void CB_CrtPrj_MusteriSecim_No_MouseDown(object sender, MouseEventArgs e)
        {
            CLS.CreateProject.Temizle_Musteri();
            CLS.CreateProject.Temizle_MusteriBolum();
            CLS.CreateProject.Temizle_ProjeBilgileri();
            CLS.CreateProject.Temizle_YetkiliKisi();

            CLS.CreateProject.Listele_MusteriNo(CB_CrtPrj_MusteriSecim_No);

        }
        private void CB_CrtPrj_MusteriSecim_No_SelectedIndexChanged(object sender, EventArgs e)
        {
            CLS.CreateProject.MusteriNoSecildi(CB_CrtPrj_MusteriSecim_No.SelectedIndex, out string MusteriAdi);
            TB_CrtPrj_MusteriSecim_Ad.Text = MusteriAdi;

            CrtPrj_SecilenMusteriNo = CB_CrtPrj_MusteriSecim_No.Text;
            CrtPrj_SecilenMusteriAdi = MusteriAdi;
        }


        // ##### BUTTON - YENİ MÜŞTERİ EKLE  ##### //
        private void B_Yeni_Musteri_Ekle_Prj_Olusturma_Click(object sender, EventArgs e)
        {
            CLS.Form_Yeni_Musteri.ShowDialog();
        }

        private void CrtPrj_MusteriFirmaSecildi(object sender, EventArgs e)
        {
            if (CB_CrtPrj_MusteriSecim_No.Text != "" || TB_CrtPrj_MusteriSecim_No.Text != "")
            {
                LB_CrtPtj_MusteriFirmaSecimiOK.Text = "✓";
                LB_CrtPtj_MusteriFirmaSecimiOK.BackColor = Color.LawnGreen;
            }
            else
            {
                LB_CrtPtj_MusteriFirmaSecimiOK.Text = " -";
                LB_CrtPtj_MusteriFirmaSecimiOK.BackColor = Color.Transparent;
            }


        }

        #endregion

        #region BÖLÜM SEÇİMİ İÇİN KULLANILAN NESNELER
        // ##### RADIO BUTTON  ##### //
        private void RB_BolumSecim_No_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_BolumSecim_No.Checked)
            {
                Panel_CrtPrj_BolumSecim_No.Visible = true;
                CB_CrtPrj_BolumSecim_Ad.Text = "";
                CB_CrtPrj_BolumSecim_Ad.Items.Clear();
                TB_CrtPrj_BolumSecim_No.Text = "";

                CLS.CreateProject.Temizle_ProjeBilgileri();
            }
            else
            {
                Panel_CrtPrj_BolumSecim_No.Visible = false;
                CB_CrtPrj_BolumSecim_No.Text = "";
                CB_CrtPrj_BolumSecim_No.Items.Clear();
                TB_CrtPrj_BolumSecim_Ad.Text = "";
            }
        }

        // ##### COMBOBOX BUTTON - BÖLÜM ADI  ##### //
        private void CB_CrtPrj_BolumSecim_Ad_MouseDown(object sender, MouseEventArgs e)
        {
            if (CrtPrj_SecilenMusteriNo != "")
            {
                CLS.CreateProject.Temizle_MusteriBolum();
                CLS.CreateProject.Temizle_ProjeBilgileri();
                CLS.CreateProject.Listele_BolumAdi(CB_CrtPrj_BolumSecim_Ad, CrtPrj_SecilenMusteriNo);
            }
            else
            {
                MessageBox.Show("Hay aksi! Birşeyler yanlış gitti. ''Müşteri Seçimi'' yapılmadan bölüm seçilemez. Önce ''Müşteri Seçimi'' yapın. ", "UYARI!");
            }

        }
        private void CB_CrtPrj_BolumSecim_Ad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CLS.CreateProject.BolumAdiSecildi(CB_CrtPrj_BolumSecim_Ad.SelectedIndex, out string BolumNo, out string BolumNot);
            RTB_CrtPrj_BolumNot.Text        = BolumNot;
            TB_CrtPrj_BolumSecim_No.Text    = BolumNo;
            CrtPrj_SecilenBolumNo           = BolumNo;
            CrtPrj_SecilenBolumAdi          = CB_CrtPrj_BolumSecim_Ad.Text;
        }

        // ##### COMBOBOX BUTTON - BÖLÜM NO  ##### //
        private void CB_CrtPrj_BolumSecim_No_MouseDown(object sender, MouseEventArgs e)
        {
            if (CrtPrj_SecilenMusteriNo != "")
            {
                CLS.CreateProject.Temizle_MusteriBolum();
                CLS.CreateProject.Temizle_ProjeBilgileri();
                CLS.CreateProject.Listele_BolumNo(CB_CrtPrj_BolumSecim_No, CrtPrj_SecilenMusteriNo);
            }
            else
            {
                MessageBox.Show("Hay aksi! Birşeyler yanlış gitti. ''Müşteri Seçimi'' yapılmadan bölüm seçilemez. Önce ''Müşteri Seçimi'' yapın. ", "UYARI!");
            }
        }
        private void CB_CrtPrj_BolumSecim_No_SelectedIndexChanged(object sender, EventArgs e)
        {
            CLS.CreateProject.BolumNoSecildi(CB_CrtPrj_BolumSecim_No.SelectedIndex, out string BolumAdi);
            TB_CrtPrj_BolumSecim_Ad.Text    = BolumAdi;
            CrtPrj_SecilenBolumNo           = CB_CrtPrj_BolumSecim_No.Text;
            CrtPrj_SecilenBolumAdi          = BolumAdi;
        }
       
        // ##### BUTTON - YENİ BÖLÜM EKLE  ##### //
        private void B_CrtPrj_YeniMusteriBolumEkle_Click(object sender, EventArgs e)
        {
            CLS.Form_Yeni_MusteriBolum.ShowDialog();
        }

        private void CrtPrj_BolümSecildi(object sender, EventArgs e)
        {
            if (CB_CrtPrj_BolumSecim_No.Text != "" || TB_CrtPrj_BolumSecim_No.Text != "")
            {
                LB_CrtPtj_BolumSecimiOK.Text = "✓";
                LB_CrtPtj_BolumSecimiOK.BackColor = Color.LawnGreen;
            }
            else
            {
                LB_CrtPtj_BolumSecimiOK.Text = " -";
                LB_CrtPtj_BolumSecimiOK.BackColor = Color.Transparent;
            }
        }

        #endregion

        #region PROJE SEÇİMİ İÇİN KULLANILAN NESNELER

        private void RB_CrtPrj_RevProje_CheckedChanged(object sender, EventArgs e)
        {

            if (RB_CrtPrj_RevProje.Checked)
            {
                Panel_CrtPrj_ProjeOlustur_RevProje.Visible  = true;
                TB_CrtPrj_RevAdi.Enabled                    = true;
                TB_CrtPrj_RevNo.Enabled                     = true;
                DTP_CrtPrj_RevBaslangic.Enabled             = true;
                CHB_CrtPrj_RevDonemDegistir.Enabled         = true;
                label11.Enabled                             = true;
                label13.Enabled                             = true;
                label75.Enabled                             = true;
                label76.Enabled                             = true;

                DTP_CrtPrj_ProjeBaslangic.Enabled           = false;
                DTP_CrtPrj_ProjeDonem.Enabled               = false;
                CHB_CrtPrj_ProjeDonemDegistir.Enabled       = false;
            }
            else
            {
                Panel_CrtPrj_ProjeOlustur_RevProje.Visible  = false;
                DTP_CrtPrj_ProjeBaslangic.Enabled           = true;
                DTP_CrtPrj_ProjeDonem.Enabled               = true;
                CHB_CrtPrj_ProjeDonemDegistir.Enabled       = true;
       

                TB_CrtPrj_RevAdi.Enabled                    = false;
                TB_CrtPrj_RevNo.Enabled                     = false;
                DTP_CrtPrj_RevBaslangic.Enabled             = false;
                DTP_CrtPrj_RevDonem.Enabled                 = false;
                CHB_CrtPrj_RevDonemDegistir.Enabled         = false;
                CHB_CrtPrj_RevDonemDegistir.Checked         = false;
                label11.Enabled                             = false;
                label13.Enabled                             = false;
                label75.Enabled = false;
                label76.Enabled = false;
            }
        }

        private void TB_CrtPrj_ProjeAdi_Validating(object sender, CancelEventArgs e)
        {
            if (!CHB_CrtPrj_ProjeDonemDegistir.Checked)
            {
                ProjeNoSorgula_Olustur(DateTime.Now.Month, DateTime.Now.Year, DateTime.Now.Day);
            }else
            {
                ProjeNoSorgula_Olustur(DTP_CrtPrj_ProjeDonem.Value.Month, DTP_CrtPrj_ProjeDonem.Value.Year, DTP_CrtPrj_ProjeDonem.Value.Day);
            }
        }

        public void ProjeNoSorgula_Olustur(int DonemAy, int DonemYil, int DonemGun)
        {
            if (CrtPrj_SecilenMusteriNo != "" && CrtPrj_SecilenBolumNo != "" && TB_CrtPrj_ProjeAdi.Text != "")
            {
                DateTime Donem = new DateTime(DonemYil, DonemAy, DonemGun);

                DTP_CrtPrj_ProjeDonem.Value = Donem;
                string DonemYili = DonemYil.ToString();
                CLS.CreateProject.ProjeNoOlusturma(CrtPrj_SecilenMusteriNo, CrtPrj_SecilenBolumNo, DonemYili, out string PRJNo, out string PRJKOD);
                TB_CrtPrj_ProjeNo.Text = PRJNo;
                TB_CrtPrj_ProjeKodu.Text = PRJKOD;
                RTB_CrtPrj_ProjeNot.ReadOnly = false;
                RTB_CrtPrj_ProjeNot.BackColor = Color.White;
            }

        }

        private void CrtPrj_ProjeNoOlusturuldu(object sender, EventArgs e)
        {
            if ((TB_CrtPrj_ProjeKodu.Text != "" && TB_CrtPrj_ProjeAdi.Text != "") || (RB_CrtPrj_RevProje.Checked && CB_CrtPrj_Secim_ProjeAdi.Text != "" && TB_CrtPrj_ProjeKodu.Text != ""  ))
            {
                LB_CrtPtj_ProjeBilgileriOK.Text = "✓";
                LB_CrtPtj_ProjeBilgileriOK.BackColor = Color.LawnGreen;
            }
            else
            {
                LB_CrtPtj_ProjeBilgileriOK.Text = " -";
                LB_CrtPtj_ProjeBilgileriOK.BackColor = Color.Transparent;
            }
        }

        private void CHB_CrtPrj_ProjeDonemDegistir_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_CrtPrj_ProjeDonemDegistir.Checked)
            {
                DTP_CrtPrj_ProjeDonem.Enabled = true;
            }
            else
            {
                DTP_CrtPrj_ProjeDonem.Enabled = false;
                DTP_CrtPrj_ProjeDonem.Value = DateTime.Now;
                ProjeNoSorgula_Olustur(DTP_CrtPrj_ProjeDonem.Value.Month, DTP_CrtPrj_ProjeDonem.Value.Year, DTP_CrtPrj_ProjeDonem.Value.Day);
            }
        }

        private void TB_CrtPrj_ProjeDonem_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                //DateTimePicker Tpicker = new DateTimePicker();
                //Tpicker.Text = DTP_CrtPrj_ProjeDonem.Text;

                if (CHB_CrtPrj_ProjeDonemDegistir.Checked)
                {
                    ProjeNoSorgula_Olustur(DTP_CrtPrj_ProjeDonem.Value.Month, DTP_CrtPrj_ProjeDonem.Value.Year, DTP_CrtPrj_ProjeDonem.Value.Day);
                }
                else
                {

                }


            }
            catch (Exception HATA)
            {
                MessageBox.Show("Hatalı ya da eksik dönem yazıldı. /n " +
                        "Proje Dönemi ''01.18'' şeklinde araya nokta ekleyerek yazılmalıdır. ", "Dönem yazım hatası!");

            }

        }

        private void PROJE_OLUSTURMA_ICIN_SECIMLER_OK(object sender, EventArgs e)
        {
            if (LB_CrtPtj_MusteriFirmaSecimiOK.Text == "✓" && LB_CrtPtj_ProjeBilgileriOK.Text == "✓" && LB_CrtPtj_BolumSecimiOK.Text == "✓")
            {
                B_Proje_Olustur.Enabled = true;
            }
            else
            {
                B_Proje_Olustur.Enabled = false;
            }
        }

        private void B_Proje_Olustur_Click(object sender, EventArgs e)
        {
            Proje_Olustur_ON_Kontrol();
        }

        public string Proje_Olustur_ON_Kontrol()
        {
            try
            {
                string Baslik = "HATA!";
                if (CrtPrj_SecilenMusteriNo != "")
                {
                    if (CrtPrj_SecilenMusteriAdi != "")
                    {
                        if (CrtPrj_SecilenBolumNo != "")
                        {
                            if (CrtPrj_SecilenBolumAdi != "")
                            {
                                if (TB_CrtPrj_ProjeKodu.Text != "")
                                {
                                    if (TB_CrtPrj_ProjeAdi.Text != "" || (RB_CrtPrj_RevProje.Checked && CB_CrtPrj_Secim_ProjeAdi.Text != "")) // Revizyon Seciliyle Proje Adına bakma
                                    {
                                        if (RB_CrtPrj_RevProje.Checked == false)
                                        {
                                            CLS.Form_Yeni_Proje.ShowDialog();
                                        }
                                        else
                                        {
                                            CLS.Form_Yeni_Revizyon.ShowDialog();
                                        }
                                       
                                    }
                                    else { MessageBox.Show("Proje Adı Oluşturulmadı!", Baslik); }
                                }
                                else { MessageBox.Show("Proje No Oluşturulmadı!", Baslik); }
                            }
                            else { MessageBox.Show("Bölüm Adı Oluşturulmadı!", Baslik); }
                        }
                        else { MessageBox.Show("Bölüm No Oluşturulmadı!", Baslik); }
                    }
                    else { MessageBox.Show("Müşteri aAdı Oluşturulmadı!", Baslik); }
                }
                else { MessageBox.Show("Müşteri No Oluşturulmadı!", Baslik); }

                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }
        }

        public string ProjeOlustur()
        {
            try
            {
                //ColumnName_DBProje[0] = "ID";
                //ColumnName_DBProje[1] = "KayitTarih";
                //ColumnName_DBProje[2] = "KayitUser";
                //ColumnName_DBProje[3] = "Notlar";
                //ColumnName_DBProje[4] = "MusteriNo";
                //ColumnName_DBProje[5] = "MusteriAdi";
                //ColumnName_DBProje[6] = "BolumNo";
                //ColumnName_DBProje[7] = "BolumAdi";
                //ColumnName_DBProje[8] = "ProjeNo";
                //ColumnName_DBProje[9] = "ProjeAdi";
                //ColumnName_DBProje[10] = "ProjeBaslamaTarih";
                //ColumnName_DBProje[11] = "ProjeDonem";
                //ColumnName_DBProje[12] = "MYetkiliNo";
                //ColumnName_DBProje[13] = "MYetkiliAdi";
                //ColumnName_DBProje[14] = "MYetkiliSoyadi";
                //ColumnName_DBProje[15] = "MYetkiliTitle";
                //ColumnName_DBProje[16] = "MYetkiliTel";
                //ColumnName_DBProje[17] = "MYetkiliTel2";
                //ColumnName_DBProje[18] = "MYetkiliMail";
                //ColumnName_DBProje[19] = "MYetkiliInfo";


                string[] WriteData = new string[21];

                WriteData[0] = "";
                WriteData[1] = DateTime.Now.ToString();
                WriteData[2] = "ISMAIL DEMIR";
                WriteData[3] = RTB_CrtPrj_ProjeNot.Text;
                WriteData[4] = CrtPrj_SecilenMusteriNo;
                WriteData[5] = CrtPrj_SecilenMusteriAdi;
                WriteData[6] = CrtPrj_SecilenBolumNo;
                WriteData[7] = CrtPrj_SecilenBolumAdi;
                WriteData[8] = TB_CrtPrj_ProjeNo.Text;
                WriteData[9] = TB_CrtPrj_ProjeKodu.Text;
                WriteData[10] =TB_CrtPrj_ProjeAdi.Text;
                WriteData[11] = DTP_CrtPrj_ProjeBaslangic.Text;
                WriteData[12] = DTP_CrtPrj_ProjeDonem.Text.Remove(2, 3);
                WriteData[13] = DTP_CrtPrj_ProjeDonem.Text.Remove(0, 3);
                WriteData[14] = TB_CrtPrj_YetkiliNo.Text;
                WriteData[15] = CB_CrtPrj_YetkiliSecim.Text;
                WriteData[16] = TB_CrtPrj_YetkiliUnvan.Text;
                WriteData[17] = TB_CrtPrj_YetkiliTel1.Text;
                WriteData[18] = TB_CrtPrj_YetkiliTel2.Text;
                WriteData[19] = TB_CrtPrj_YetkiliMail.Text;
                WriteData[20] = "";
                            
                string cmd = CLS.CreateProject.Proje_Olustur(WriteData);

                return "OK! - " + cmd;
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }
        }




        #endregion

        #region REVİZYON SEÇİMİ İÇİN KULLANILAN NESNELER



        #endregion

        #region YETKİLİ KİŞİ SEÇİMİ İÇİN KULLANILAN NESNELER
        private void B_CrtPrj_YeniYetkiliEkle_Click(object sender, EventArgs e)
        {
            Form_Yeni_Yetkili.Show();
        }

        private void CB_CrtPrj_YetkiliSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            CLS.CreateProject.YetkiliAdiSecildi(CB_CrtPrj_YetkiliSecim.SelectedIndex, out string YNot, out string YNo, out string YUnvan,
                out string YTel1, out string YTel2, out string YMail, out string YInfo);

            RTB_CrtPrj_YetkiliNot.Text  = Crypto.Decrypt(YNot, "xxx");
            TB_CrtPrj_YetkiliNo.Text    = YNo; // Crypto.Decrypt(, "xxx"); 
            TB_CrtPrj_YetkiliUnvan.Text = Crypto.Decrypt(YUnvan, "xxx"); 
            TB_CrtPrj_YetkiliTel1.Text  = Crypto.Decrypt(YTel1, "xxx"); 
            TB_CrtPrj_YetkiliTel2.Text  = Crypto.Decrypt(YTel2, "xxx"); 
            TB_CrtPrj_YetkiliMail.Text  = Crypto.Decrypt(YMail, "xxx"); 
        }

        private void CB_CrtPrj_YetkiliSecim_MouseDown(object sender, MouseEventArgs e)
        {
            CLS.CreateProject.Listele_YetkiliAdi(CB_CrtPrj_YetkiliSecim, CrtPrj_SecilenMusteriNo);
        }

        private void CB_CrtPrj_YetkiliSecim_TextChanged(object sender, EventArgs e)
        {
            if (CB_CrtPrj_YetkiliSecim.Text != "")
            {
                LB_CrtPtj_YetkiliOK.Text = "✓";
                LB_CrtPtj_YetkiliOK.BackColor = Color.LawnGreen;
            }
            else
            {
                LB_CrtPtj_YetkiliOK.Text = " -";
                LB_CrtPtj_YetkiliOK.BackColor = Color.Transparent;
            }
        }
        #endregion
        #endregion


     
        private void B_Proje_Olustur_Temizle_Click(object sender, EventArgs e)
        {
           CLS.CreateProject.Temizle_Musteri();
           CLS.CreateProject.Temizle_MusteriBolum();
           CLS.CreateProject.Temizle_ProjeBilgileri();
           CLS.CreateProject.Temizle_YetkiliKisi();
        }



        #region KULLANICI PANELİ
        private void CB_User_SecUserName_MouseDown(object sender, MouseEventArgs e)
        {
            CLS.UserLogin.Listele_UserName(CB_User_SecUserName);
            TB_User_UserPass.Text = "";
        }

        private void B_YeniUserEkle_Click(object sender, EventArgs e)
        {
            CLS.Form_Yeni_User.Show();
        }

        private void B_UserGiris_Click(object sender, EventArgs e)
        {

            CLS.UserLogin.KullaniciGiris();
        }

        private void B_UserCikis_Click(object sender, EventArgs e)
        {

            CLS.UserLogin.KullaniciCikis();
        }





        private void button8_Click(object sender, EventArgs e)
        {
            CLS.CreateFolder.Create_Yeni_Musteri_Klasor("0001", "AKSA");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CLS.CreateFolder.Create_Yeni_Proje_Klasor("0001", "AKSA", "P0010118002");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CLS.CreateFolder.Create_YeniRevizyon("0001", "AKSA", "P0010118002", "R01", out string a);
        }







        #endregion


        public void RevNoSorgula_Olustur()
        {
            if (CrtPrj_SecilenMusteriNo != "" && CrtPrj_SecilenBolumNo != "" && CB_CrtPrj_Secim_ProjeAdi.Text != "" && TB_CrtPrj_ProjeNo.Text != "")
            {
                CLS.CreateProject.RevNoOlusturma(CrtPrj_SecilenMusteriNo, CrtPrj_SecilenBolumNo, TB_CrtPrj_ProjeNo.Text, out string RevNo);
                TB_CrtPrj_RevNo.Text = RevNo;
                RTB_CrtPrj_ProjeNot.ReadOnly = false;
                RTB_CrtPrj_ProjeNot.BackColor = Color.White;
            }

        }



        private void CB_CrtPrj_Secim_ProjeAdi_MouseDown(object sender, MouseEventArgs e)
        {
            CLS.CreateProject.Listele_RevIcinProjeler(CB_CrtPrj_Secim_ProjeAdi, CrtPrj_SecilenMusteriNo, CrtPrj_SecilenBolumNo);
        }

        private void CB_CrtPrj_Secim_ProjeAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            CLS.CreateProject.RevIcinProjeSecildi(CB_CrtPrj_Secim_ProjeAdi.SelectedIndex, out string Pno, out string PKod, out string BasTarih, out string PrjDonem, out string Not);

            TB_CrtPrj_ProjeNo.Text = Pno;
            TB_CrtPrj_ProjeKodu.Text = PKod;
       //     DTP_CrtPrj_ProjeBaslangic.Text = BasTarih;
      //      DTP_CrtPrj_ProjeDonem.Text = PrjDonem;
            RTB_CrtPrj_ProjeNot.Text = Not;


        }

        private void TB_CrtPrj_RevAdi_Validating(object sender, CancelEventArgs e)
        {
            RevNoSorgula_Olustur();
        }

        private void B_AnaDizinSec_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLS.PrgSettings.KAYDET_SistemAyarlari();
            MessageBox.Show("Ayarlar Kaydedildi.", "Kayıt");
        }
    }
}
