using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parkon
{
    public class CreateFolder
    {
        public CLS CLS;




        #region PUBLIC VARIABLE

        public string ProjeAnadizin = "C:\\proje";
        public string ProjeDonemi;

        public string Dizin_ProjeRoot;
        public string Dizin_Musteri_Firma;
        public string Dizin_Proje;

        public string Dizin_Musteri_Iliskileri = "\\P1 Musteri Iliskileri";
        public string Dizin_Teklif_Belgeleri = "\\Teklif ve Ilgili Belgeler";
        public string Dizin_IsZaman_Plani = "\\P2 Proje Is-Zaman Plani";
        public string Dizin_Elektrik_Projesi = "\\P3 Elektrik Projesi";

        public string Dizin_Yazilim = "\\P4 Yazilim";
        public string Dizin_PLC_Program = "\\00 PLC";
        public string Dizin_HMI_Program = "\\01 HMI";
        public string Dizin_SCADA_Program = "\\02 SCADA";
        public string Dizin_PC_Program = "\\03 PC";
        public string Dizin_Yardimci_Program = "\\04 Yardimci Programlar";

        public string Dizin_Servis_Egitim_Formlari = "\\P5 Proje Teslim Egitim Servis Formlari";
        public string Dizin_Dokumanlar = "\\P6 Dokumanlar";
        public string Dizin_Cizim = "\\Cizim";
        public string Dizin_Malzeme_Listesi = "\\Malzeme Listesi";
        public string Dizim_Toplanti_Notlari = "\\Toplanti Notlari";
        public string Dizim_Kullanim_Kilavuzlari = "\\Cihaz Kullanim Kilavuzlari";
        public string Dizin_Diger_Dokumanlar = "\\Diger";
        public string Dizin_FotografVideo = "\\Fotograf Video";


        public string Klasor_PLC_Program;
        public string Klasor_HMI_Program;
        public string Klasor_SCADA_Program;
        public string Klasor_YARD_Program;
        public string Klasor_PC_Program;
        public string Klasor_Malzeme_Listesi;
        public string Klasor_Elektrik_Projesi;
        public string Klasor_Cizimler;
        public string Klasor_Musteri_Iliskileri;
        public string Klasor_Teklif_Belgeleri;
        public string Klasor_Servis_Egitim_Formlari;
        public string Klasor_Dokumanlar;
        public string Klasor_Diger_Dokumanlar;
        public string Klasor_FotografVideo;
        public string Klasor_Tum_Dokumanlar;
        public string Klasor_Is_Zaman_Plani;

        #endregion


        string MusteriAdi;  //BSH
        string MusteriKodu; //0013
        string ProjeAdi;    //
        string ProjeKodu;   //P00130118002

        string ProjeSimge;  //P
        string MusteriNo;   //0013
        string BolumNo;     //01
        string DonemYili;   //18
        string ProjeNo;     //002
        string RevizyonNo;  //R00


        string ProjeIcerik_D1 = "D1";  //Müşteri İlişkileri Gelenler/Teklifler=> Onaylanan/Verilen
        string ProjeIcerik_D2 = "D2";  //İş Zaman Planı
        string ProjeIcerik_D3 = "D3";  //Elektrik Projesi ve Malzeme listesi
        string ProjeIcerik_D4 = "D4";  //PLC, HMI-SCADA, Diger
        string ProjeIcerik_D5 = "D5";  //Cihaz, Cizim, Form, Diger
        string ProjeIcerik_D6 = "D6";  //Fotograf Video

        // D1 İÇİN OLUŞTURULACAK ALT KLASÖRLER //
        string AltKlasor_D1_1 = "Gelenler";      // = "Gelenler";
        string AltKlasor_D1_2 = "Teklifler";      // = "Teklifler";
        string AltKlasor_D1_2_1 = "Teklif - Verilen";    // = "Teklif Verilenler";
        string AltKlasor_D1_2_2 = "Teklif - Onaylanan";    // = "Teklif Onaylanan";

        // D4 İÇİN OLUŞTURULACAK ALT KLASÖRLER //
        string AltKlasor_D4_1 = "PLC";  // = "PLC";
        string AltKlasor_D4_2 = "HMI";  // = "HMI SCADA";
        string AltKlasor_D4_3 = "Diger";  // = "Diger";

        // D5 İÇİN OLUŞTURULACAK ALT KLASÖRLER //
        string AltKlasor_D5_1 = "Cihazlar";  // = "Cihazlar";
        string AltKlasor_D5_2 = "Cizim";  // = "Cizim";
        string AltKlasor_D5_3 = "Diğer";  // = "Diger";
        string AltKlasor_D5_4 = "Formlar";  // = "Formlar";


        public void KlasorYapisi()
        {
          //MusteriAdi;  //BSH
          //MusteriKodu; //0013
          //ProjeAdi;    //
          //ProjeKodu;   //P00130118002

          //ProjeSimge;  //P
          //MusteriNo;   //0013
          //BolumNo;     //01
          //DonemYili;   //18
          //ProjeNo;     //002
          //RevizyonNo;  //R00

            ProjeIcerik_D1 = "D1";  //Müşteri İlişkileri Gelenler/Teklifler=> Onaylanan/Verilen
            ProjeIcerik_D2 = "D2";  //İş Zaman Planı
            ProjeIcerik_D3 = "D3";  //Elektrik Projesi ve Malzeme listesi
            ProjeIcerik_D4 = "D4";  //PLC, HMI-SCADA, Diger
            ProjeIcerik_D5 = "D5";  //Cihaz, Cizim, Form, Diger
            ProjeIcerik_D6 = "D6";  //Fotograf Video

            // D1 İÇİN OLUŞTURULACAK ALT KLASÖRLER //
            AltKlasor_D1_1 = "Gelenler";
            AltKlasor_D1_2 = "Teklifler";
            AltKlasor_D1_2_1 = "Teklif Verilenler";
            AltKlasor_D1_2_2 = "Teklif Onaylanan";
                  
            // D4 İÇİN OLUŞTURULACAK ALT KLASÖRLER //
            AltKlasor_D4_1 = "PLC";
            AltKlasor_D4_2 = "HMI SCADA";
            AltKlasor_D4_3 = "Diger";

            // D5 İÇİN OLUŞTURULACAK ALT KLASÖRLER //
            AltKlasor_D5_1 = "Cihazlar";
            AltKlasor_D5_2 = "Cizim";
            AltKlasor_D5_3 = "Diger";
            AltKlasor_D5_4 = "Formlar";
        }

        public string Create_Yeni_Musteri_Klasor(string MusteriNo, string MusteriAdi)
        {
            try
            {
                string MusteriKlasor_Adi = MusteriNo + " " + MusteriAdi;

                string MusteriKlasoru_Yolu = ProjeAnadizin + "\\" + MusteriKlasor_Adi;




                if (!Directory.Exists(MusteriKlasoru_Yolu))
                {
                    //Dizin_Proje = Dizin_ProjeRoot;

                    Directory.CreateDirectory(MusteriKlasoru_Yolu);
                }


                    return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }
        }

        public string Create_Yeni_Proje_Klasor(string MusteriNo, string MusteriAdi, string ProjeKodu)
        {
            try
            {
                string MusteriKlasor_Adi = MusteriNo + " " + MusteriAdi;

                string MusteriKlasoru_Yolu = ProjeAnadizin + "\\" + MusteriKlasor_Adi;
                string ProjeKlasoru_Yolu = ProjeAnadizin + "\\" + MusteriKlasor_Adi + "\\" + ProjeKodu;

                if (!Directory.Exists(ProjeKlasoru_Yolu))
                {
                    Directory.CreateDirectory(ProjeKlasoru_Yolu);
                    Create_Bos_ProjeIcerik_Klasor(ProjeKlasoru_Yolu);
                }


                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }
        }

        public string Create_Bos_ProjeIcerik_Klasor(string ProjeKlasoru_Yolu)
        {
            string ProjeKlasoruIcindeBosIcerik_Yolu = ProjeKlasoru_Yolu + "\\" + "R00";
            try
            {
                if (!Directory.Exists(ProjeKlasoruIcindeBosIcerik_Yolu))
                {
                    Directory.CreateDirectory(ProjeKlasoruIcindeBosIcerik_Yolu + "\\" + ProjeIcerik_D1);
                    Directory.CreateDirectory(ProjeKlasoruIcindeBosIcerik_Yolu + "\\" + ProjeIcerik_D2);
                    Directory.CreateDirectory(ProjeKlasoruIcindeBosIcerik_Yolu + "\\" + ProjeIcerik_D3);
                    Directory.CreateDirectory(ProjeKlasoruIcindeBosIcerik_Yolu + "\\" + ProjeIcerik_D4);
                    Directory.CreateDirectory(ProjeKlasoruIcindeBosIcerik_Yolu + "\\" + ProjeIcerik_D5);
                    Directory.CreateDirectory(ProjeKlasoruIcindeBosIcerik_Yolu + "\\" + ProjeIcerik_D6);

                    Directory.CreateDirectory(ProjeKlasoruIcindeBosIcerik_Yolu + "\\" + ProjeIcerik_D1 + "\\" + AltKlasor_D1_1);
                    Directory.CreateDirectory(ProjeKlasoruIcindeBosIcerik_Yolu + "\\" + ProjeIcerik_D1 + "\\" + AltKlasor_D1_2);
                    Directory.CreateDirectory(ProjeKlasoruIcindeBosIcerik_Yolu + "\\" + ProjeIcerik_D1 + "\\" + AltKlasor_D1_2 + "\\" + AltKlasor_D1_2_1);
                    Directory.CreateDirectory(ProjeKlasoruIcindeBosIcerik_Yolu + "\\" + ProjeIcerik_D1 + "\\" + AltKlasor_D1_2 + "\\" + AltKlasor_D1_2_2);

                    Directory.CreateDirectory(ProjeKlasoruIcindeBosIcerik_Yolu + "\\" + ProjeIcerik_D4 + "\\" + AltKlasor_D4_1);
                    Directory.CreateDirectory(ProjeKlasoruIcindeBosIcerik_Yolu + "\\" + ProjeIcerik_D4 + "\\" + AltKlasor_D4_2);
                    Directory.CreateDirectory(ProjeKlasoruIcindeBosIcerik_Yolu + "\\" + ProjeIcerik_D4 + "\\" + AltKlasor_D4_3);

                    Directory.CreateDirectory(ProjeKlasoruIcindeBosIcerik_Yolu + "\\" + ProjeIcerik_D5 + "\\" + AltKlasor_D5_1);
                    Directory.CreateDirectory(ProjeKlasoruIcindeBosIcerik_Yolu + "\\" + ProjeIcerik_D5 + "\\" + AltKlasor_D5_2);
                    Directory.CreateDirectory(ProjeKlasoruIcindeBosIcerik_Yolu + "\\" + ProjeIcerik_D5 + "\\" + AltKlasor_D5_3);
                    Directory.CreateDirectory(ProjeKlasoruIcindeBosIcerik_Yolu + "\\" + ProjeIcerik_D5 + "\\" + AltKlasor_D5_4);
                }

                return "OK!";
            }
            catch (Exception HATA)
            {
                return "ERR! - " + HATA.ToString();
            }
}


        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the source directory does not exist, throw an exception.
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory does not exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }


            // Get the file contents of the directory to copy.
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                // Create the path to the new copy of the file.
                string temppath = Path.Combine(destDirName, file.Name);

                // Copy the file.
                file.CopyTo(temppath, false);
            }

            // If copySubDirs is true, copy the subdirectories.
            if (copySubDirs)
            {

                foreach (DirectoryInfo subdir in dirs)
                {
                    // Create the subdirectory.
                    string temppath = Path.Combine(destDirName, subdir.Name);

                    // Copy the subdirectories.
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        public string Create_YeniRevizyon(string MusteriNo, string MusteriAdi, string ProjeKodu, string RevizyonNo, out string Status)
        {
                  Status                    = "";
           string OncekiRevKlasor_Yolu      = "";
           string YeniRevKlasor_Yolu        = "";
           string ArsivKayit_Yolu           = "";
           string ProjeKlasor_Yolu          = "";
           string CopKlasoru_Yolu           = "";
           string Str_OncekiRevNo           = "";
            string YeniRevNo = "";
            string RevNo = "";
           int    value                     = 0;
            try
            {
                switch (value)
                {
                    case 0:
                        Status = "Yeni Revizyon oluşturma işlemi Başladı. Önceki Revizyon No'u aranıyor...";

                        // Önceki Revizyon No'su Hesapla
                        RevNo = RevizyonNo; //.Substring(1, 2);
                        YeniRevNo = "R" + RevizyonNo;
                        int OncekiRevNo = int.Parse(RevNo) - 1;
                       
                        if (OncekiRevNo < 10)
                        {
                            Str_OncekiRevNo = "R0" + OncekiRevNo.ToString();
                        }
                        else
                        {
                            Str_OncekiRevNo = "R" + OncekiRevNo.ToString();
                        }


                        goto case 1;
                    case 1:
                        Status = "Gerekli değişkenler oluşturuluyor.";
                        ProjeKlasor_Yolu        = ProjeAnadizin + "\\" + MusteriNo + " " + MusteriAdi + "\\" + ProjeKodu;
                        OncekiRevKlasor_Yolu    = ProjeAnadizin + "\\" + MusteriNo + " " + MusteriAdi + "\\" + ProjeKodu + "\\" + Str_OncekiRevNo.ToString();
                        YeniRevKlasor_Yolu      = ProjeAnadizin + "\\" + MusteriNo + " " + MusteriAdi + "\\" + ProjeKodu + "\\" + YeniRevNo;
                        ArsivKayit_Yolu         = ProjeAnadizin + "\\" + MusteriNo + " " + MusteriAdi + "\\" + ProjeKodu + "\\" + Str_OncekiRevNo.ToString() + ".zip";
                        CopKlasoru_Yolu         = ProjeAnadizin + "\\9999 COP\\" + ProjeKodu + " - " + Str_OncekiRevNo.ToString() + "\\" + Str_OncekiRevNo.ToString();

                        goto case 2;
                    case 2:
                        if (!Directory.Exists(YeniRevKlasor_Yolu))
                        {
                            Directory.CreateDirectory(YeniRevKlasor_Yolu);
                            
                            DirectoryCopy(OncekiRevKlasor_Yolu, YeniRevKlasor_Yolu, true);
                            Status = "Yeni Revizyon klasörü oluşturuldu. İşlem tamamlandı.";
                        }


                        goto case 3;
                    case 3:
                        Status = "Bir önceki revizyon dosyaları arşivleniyor.";
                        ZipFile.CreateFromDirectory(OncekiRevKlasor_Yolu, ArsivKayit_Yolu, CompressionLevel.Optimal, true);//, CompressionLevel.Optimal, false);
                        Status = "Arşivleme işlemi tamamlandı. Dosyalar kaldırılıyor.";

                   


                        goto case 4;
                    case 4:
                        if (!Directory.Exists(ProjeAnadizin + "\\9999 COP"))
                        {
                            Directory.CreateDirectory(ProjeAnadizin + "\\9999 COP");
                            Directory.Move(OncekiRevKlasor_Yolu, CopKlasoru_Yolu);
                        }
                        else
                        {
                            if (!Directory.Exists(ProjeAnadizin + "\\" + ProjeKodu + " - " + Str_OncekiRevNo.ToString()))
                            {
                                Directory.CreateDirectory(ProjeAnadizin +  "\\9999 COP\\" + ProjeKodu + " - " + Str_OncekiRevNo.ToString());
                                Directory.Move(OncekiRevKlasor_Yolu, CopKlasoru_Yolu);
                            }
                            else
                            {
                                Directory.Move(OncekiRevKlasor_Yolu, CopKlasoru_Yolu);
                            }
                              
                        }


                       
                    
                        goto case 5;
                    case 5:
                      Directory.CreateDirectory(OncekiRevKlasor_Yolu);
                     


                        goto case 6;
                    case 6:
                     File.Move(ArsivKayit_Yolu, OncekiRevKlasor_Yolu + "\\" + Str_OncekiRevNo.ToString() + ".zip");
                        Status = "Arşivleme işlemi tamamlandı";

                        goto case 7;
                    case 7:
                        //if (!Directory.Exists(YeniRevKlasor_Yolu))
                        //{
                        //    Directory.CreateDirectory(YeniRevKlasor_Yolu);
                        //    Status = "Yeni Revizyon klasörü oluşturuldu. İşlem tamamlandı.";
                        //}

                        goto case 8;
                    case 8:


                        goto case 50;
                    case 50:
                        break;
                }



                return "OK!";
            }
            catch (Exception HATA)
            {
                MessageBox.Show(HATA.Message.ToString(), "HATA");
                return "ERR! - " + HATA.ToString();
            }
        }

        public void Create()
        {

            //Dizin_Musteri_Firma = Anadizin + CB_Proje_Olustur_Musteri_Firma.Text;

            //string Proje_Olustur_Bolum_Knt;
            //if (TB_Proje_Olustur_Bölüm.Text != "")
            //{ Proje_Olustur_Bolum_Knt = TB_Proje_Olustur_Bölüm.Text + " "; }
            //else { Proje_Olustur_Bolum_Knt = TB_Proje_Olustur_Bölüm.Text; }

            //Dizin_Proje = Dizin_Musteri_Firma + "\\" + TB_Proje_Olustur_Proje_Kodu_Simgesi.Text + Num_Proje_Olustur_Proje_Kodu_NO.Text + " " + CB_Proje_Olustur_Musteri_Firma.Text + " - " + Proje_Olustur_Bolum_Knt + TB_Proje_Olustur_Proje_Adi.Text;







            //Dizin_Proje = Dizin_ProjeRoot + "\\" + MusteriNo;


            if (!Directory.Exists(Dizin_Proje))
            {

                Dizin_Proje = Dizin_ProjeRoot;

                Directory.CreateDirectory(Dizin_Proje);







                Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri); //P1 Musteriden Gelenler
                Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri + "\\E-Mailler");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri + "\\Musteri Talebi ve Degisiklikleri");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri + "\\Musteriden Gelen Belgeler");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri + "\\Musteriden Gelen Belgeler");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri + Dizin_Teklif_Belgeleri);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri + Dizin_Teklif_Belgeleri + "\\Musteriden Alinan Teklif Onayi");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri + Dizin_Teklif_Belgeleri + "\\Musteriye Verilen Teklifler");

                Directory.CreateDirectory(Dizin_Proje + Dizin_IsZaman_Plani);

                Directory.CreateDirectory(Dizin_Proje + Dizin_Elektrik_Projesi);

                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PLC_Program);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PLC_Program + "\\00 Guncel");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PLC_Program + "\\01 Yedek");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PLC_Program + "\\02 IO Listesi");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_HMI_Program);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_HMI_Program + "\\00 Guncel");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_HMI_Program + "\\01 Yedek");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_HMI_Program + "\\02 Inport-Export");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_SCADA_Program);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_SCADA_Program + "\\00 Guncel");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_SCADA_Program + "\\01 Yedek");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_SCADA_Program + "\\02 Inport-Export");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PC_Program);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PC_Program + "\\00 Guncel");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PC_Program + "\\01 Yedek");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PC_Program + "\\02 Dokumanlar Ornekler");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_Yardimci_Program);

                Directory.CreateDirectory(Dizin_Proje + Dizin_Servis_Egitim_Formlari);

                Directory.CreateDirectory(Dizin_Proje + Dizin_Dokumanlar);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Dokumanlar + Dizim_Kullanim_Kilavuzlari);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Dokumanlar + Dizin_Cizim);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Dokumanlar + Dizin_Diger_Dokumanlar);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Dokumanlar + Dizin_FotografVideo);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Dokumanlar + Dizin_Malzeme_Listesi);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Dokumanlar + Dizim_Toplanti_Notlari);


              //  Lb_Uyari.Text = "Oluşturulan Yeni Proje Dizini: " + Dizin_Proje;


                //if (XLComm == null)
                //{
                //    MessageBox.Show("Galiba Excel yüklü değil. Proje Künyesi 'Excel' dosyasına kaydedilir. Bilgisayarınıza 'Excel' yükledikten sonra işlemi tekrar deneyiniz.");
                //    return;
                //}

                //Excel.Workbook xlWorkBook;
                //Excel.Worksheet xlWorkSheet;
                //object misValue = System.Reflection.Missing.Value;

                //xlWorkBook = XLComm.Workbooks.Add(misValue);
                //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                //xlWorkSheet.Cells[1, 1] = "NO"; xlWorkSheet.Cells[2, 1] = "1";
                //xlWorkSheet.Cells[1, 2] = "TARİH"; xlWorkSheet.Cells[2, 2] = DateTime.Now.ToLongDateString();
                //xlWorkSheet.Cells[1, 3] = "YETKİLİ"; xlWorkSheet.Cells[2, 3] = TB_Kullanici.Text;
                //xlWorkSheet.Cells[1, 4] = "İŞLEM"; xlWorkSheet.Cells[2, 4] = "Yeni Proje Oluşturma";
                //xlWorkSheet.Cells[1, 5] = "AÇIKLAMA"; xlWorkSheet.Cells[2, 5] = "Yeni Proje Oluşturuldu. Proje için gereken klasörler hazırlandı.";

                //xlWorkBook.SaveAs(Dizin_Proje + "\\" + "PROJE KUNYESI - " + "P" + Num_Proje_Olustur_Proje_Kodu_NO.Text + " " + TB_Proje_Olustur_Proje_Adi.Text + ".xls",
                //                 Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                //                 Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                //xlWorkBook.Close(true, misValue, misValue);
                //XLComm.Quit();

                //try
                //{
                //    System.Runtime.InteropServices.Marshal.ReleaseComObject(XLComm);
                //    XLComm = null;
                //}
                //catch (Exception ex)
                //{
                //    XLComm = null;
                //    MessageBox.Show("Hata " + ex.ToString());
                //}
                //finally
                //{
                //    GC.Collect();
                //}
                YeniExcelDosyasiOlustur();

            }
            else
            {
              //  Lb_Uyari.Text = "Yazdığınız Proje adı kullanılıyor. \nLütfen kontrol ederek tekrar deneyiniz.";
            }

        }


        void YeniExcelDosyasiOlustur()
        {
            //DataTable TempDT = new DataTable();
            //TempDT.Columns.Clear();
            //TempDT.Columns.Add("NO");
            //TempDT.Columns.Add("TARIH");
            //TempDT.Columns.Add("YETKILI");
            //TempDT.Columns.Add("ISLEM");
            //TempDT.Columns.Add("ACIKLAMA");

            //DataRow rowlar = TempDT.NewRow();
            //rowlar[0] = "1";
            //rowlar[1] = DateTime.Now.ToLongDateString();
            //rowlar[2] = TB_Kullanici.Text;
            //rowlar[3] = "Yeni Proje Oluşturma";
            //rowlar[4] = "Yeni Proje Oluşturuldu. Proje için gereken klasörler hazırlandı.";
            //TempDT.Rows.Add(rowlar);

            //DataGridView TempDGV = new DataGridView();

            //TempDGV.DataSource = TempDT;
            //string Status = "";

            //string KayitYolu = Dizin_Proje + "\\";
            //string ExcelFileName = "PROJE KUNYESI - " + TB_Proje_Olustur_Proje_Kodu_Simgesi.Text + Num_Proje_Olustur_Proje_Kodu_NO.Text + " " + TB_Proje_Olustur_Bölüm.Text + " " + TB_Proje_Olustur_Proje_Adi.Text;

            //SAVE_EXCEL(KayitYolu, ExcelFileName, "xls", TempDGV, false, out Status);
        }




        public string ingilizcelestir(string kelimecik)
        {
            kelimecik = kelimecik.Replace('ö', 'o');
            kelimecik = kelimecik.Replace('ü', 'u');
            kelimecik = kelimecik.Replace('ğ', 'g');
            kelimecik = kelimecik.Replace('ş', 's');
            kelimecik = kelimecik.Replace('ı', 'i');
            kelimecik = kelimecik.Replace('ç', 'c');
            kelimecik = kelimecik.Replace('Ö', 'O');
            kelimecik = kelimecik.Replace('Ü', 'U');
            kelimecik = kelimecik.Replace('Ğ', 'G');
            kelimecik = kelimecik.Replace('Ş', 'S');
            kelimecik = kelimecik.Replace('İ', 'I');
            kelimecik = kelimecik.Replace('Ç', 'C');

            return kelimecik;
        }
        void Karakter_TRtoENG()
        {
            //TB_Proje_Olustur_Bölüm.Text = ingilizcelestir(TB_Proje_Olustur_Bölüm.Text);
            //TB_Proje_Olustur_Proje_Adi.Text = ingilizcelestir(TB_Proje_Olustur_Proje_Adi.Text);
        }


    }
}
