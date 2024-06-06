namespace LunchTime
{
    internal class Program
    {
        static void Main()
        {
            Console.Title = "LunchTime";

            var timeoff = new TimeOff();
            TimeOff.GetMenu();

            var DownloadDirectory = "C:\\Users\\jakub.jaros\\Desktop\\Test";
            var names = Directory.GetFiles(DownloadDirectory);
            var FileName = names[0];
            Console.WriteLine(FileName);

            string text = TimeOff.ExtractTextFromPdf(FileName);
            Console.WriteLine(text);

            //var mlyn = new Mlyn();
            //mlyn.GetMenu();

            //var puor = new PUOR();
            //puor.GetMenu();

            //var kluci = new UKluku();
            //kluci.GetMenu();

            //Console.Clear();

            //Console.WriteLine("PUOR" + "\n" + "-----------------------" + "\n");
            //Console.WriteLine(puor.Menu);
            //Console.WriteLine("\n" + "U Kluků" + "\n" + "-----------------------" + "\n");
            //Console.WriteLine(kluci.Menu);
            //Console.WriteLine("\n" + "Třebovický mlýn" + "\n" + "-----------------------" + "\n");
            //Console.WriteLine(mlyn.Menu);

            //Console.WindowWidth = 140;
            //Console.WindowHeight = 60;

            //Console.WriteLine("\n"  + "-----------------------"+ "\n" + "Press any key to exit");
            //Console.SetCursorPosition(0, 0);
            //Console.ReadKey();
        }
    }
}