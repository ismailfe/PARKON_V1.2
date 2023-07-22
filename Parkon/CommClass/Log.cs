using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkon
{
    public class Log
    {

        public CLS CLS;


        //public void LOGYAZ(string FileName, RichTextBox box, string text, Color color, bool addNewLine, bool Bold)
        //{
        //    try
        //    {
        //        string Tarih = DateTime.Now.ToShortDateString();
        //        string Saat = DateTime.Now.ToLongTimeString();
        //        string mesaj;

        //        if (addNewLine)
        //        { mesaj = "\n" + Tarih + " " + Saat + ": " + text; }
        //        else
        //        { mesaj = text; }

        //        if (Bold)
        //        { box.SelectionFont = new Font(box.Font, FontStyle.Bold); }
        //        else
        //        { box.SelectionFont = new Font(box.Font, FontStyle.Regular); }

        //        box.SuspendLayout();
        //        box.SelectionColor = color;
        //        box.AppendText(mesaj);
        //        box.ScrollToCaret();
        //        box.ResumeLayout();

        //        string path = Application.ExecutablePath;   // App. exe yolu
        //        string path2 = Application.StartupPath;     // App. exe klasör yolu
        //        string path3 = path2 + "\\" + FileName + ".txt";
        //        StreamWriter Dosya = File.AppendText(path3);
        //        Dosya.WriteLine(mesaj, RichTextBoxStreamType.PlainText);
        //        Dosya.Close();
        //    }
        //    catch (Exception HATA)
        //    {
        //        string ht = HATA.ToString();
        //    }


        //}

        //public void Log_Save(RichTextBox RTB, string RTB_FilesName)
        //{
        //    string path = Application.ExecutablePath;   // App. exe yolu
        //    string path2 = Application.StartupPath;     // App. exe klasör yolu
        //    string path3 = path2 + "\\" + RTB_FilesName + ".txt";

        //    //  RTB.SaveFile(path3, RichTextBoxStreamType.PlainText);
        //    //  StreamWriter Dosya = File.AppendText(path3);
        //    //  Dosya.WriteLine(RTB.Text, RichTextBoxStreamType.PlainText);
        //    //  Dosya.Close();
        //}

        //public void ERR_LOGS(string HataMesaji)
        //{
        //    if (HataMesaji == null)
        //    {
        //        HataMesaji = "";
        //    }
        //    RichTextBox RTB_LogsError = new RichTextBox();
        //    LOGYAZ("Logs_Error", RTB_LogsError, " HATA: " + HataMesaji, Color.Black, true, false);

        //}



    }
}
