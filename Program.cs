using System;
using System.Runtime.InteropServices;
using WindowsInput;
using WindowsInput.Native;

namespace LunchTime
{
    //TODO
    //timeoff: auto pdf name detect
    //timeoff: splitter polevka x cervencova akce
    //timeoff: standardize loading console text
    //timeoff: remove debug fluff
    //add basta u reky
    //UI

    internal class Program
    {
        static void Main()
        {
            Config.Setup();
            Console.Title = "LunchTime";
            var timeoff = new TimeOff();
            timeoff.DownloadMenu();
            timeoff.Setup();
            timeoff.GetText();
            timeoff.GetMenu();
            timeoff.Cleanup();




            // -------------------------------------------------------------goodcode
            var mlyn = new Mlyn();
            mlyn.GetMenu();

            var puor = new PUOR();
            puor.GetMenu();

            var kluci = new UKluku();
            kluci.GetMenu();

            Console.Clear();

            Console.WriteLine("TimeOff" + "\n" + "-----------------------" + "\n");
            Console.WriteLine(timeoff.Menu);
            Console.WriteLine("\n" + "PUOR" + "\n" + "-----------------------" + "\n");
            Console.WriteLine(puor.Menu);
            Console.WriteLine("\n" + "U Kluků" + "\n" + "-----------------------" + "\n");
            Console.WriteLine(kluci.Menu);
            Console.WriteLine("\n" + "Třebovický mlýn" + "\n" + "-----------------------" + "\n");
            Console.WriteLine(mlyn.Menu);

            Console.WindowWidth = 140;
            Console.WindowHeight = 60;

            Console.WriteLine("\n" + "-----------------------" + "\n" + "Press any key to exit");
            Console.SetCursorPosition(0, 0);
            Console.ReadKey();
            //------------------------------------------------------------------goodcode
        }
    }
}