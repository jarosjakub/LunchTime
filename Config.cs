﻿namespace LunchTime
{
    public static class Config 
    {
        public static void Setup()
        {
            var ted = DateTime.Now;
            Config.DenDnes = ted.ToString("ddd");
        }


        public static string DenDnes = "po";

        public static string DirPath = "C:\\Windows\\Temp\\LunchTime";
        public static string DownloadDirPath = "C:\\Users\\jakub.jaros\\Desktop\\Test\\Download";
        public static string TxtPath = "C:\\Users\\jakub.jaros\\Desktop\\Test\\temp.txt";
        public static string PdfPath = "C:\\Users\\jakub.jaros\\Desktop\\Test\\tyden28OR.pdf";
        public static string TxtWindow = "temp.txt - Notepad";
        public static string PdfWindow = "tyden28OR.pdf - Adobe Acrobat Reader (32-bit)";




    }
}