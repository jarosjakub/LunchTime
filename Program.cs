using System;
using System.Runtime.InteropServices;
using WindowsInput;
using WindowsInput.Native;

namespace LunchTime
{
    internal class Program
    {
        static void Main()
        {
            Console.Title = "LunchTime";
            var timeoff = new TimeOff();
            timeoff.GetText();



            //var file = "C:\\Users\\jakub.jaros\\Desktop\\Test\\tyden23OR.pdf";
            //var file2 = "C:\\Users\\jakub.jaros\\Desktop\\Test\\temp.txt";
            //var sim = new InputSimulator();

            //System.Threading.Thread.Sleep(2000);
            //IntPtr hWnd = FindWindow(null, "tyden23OR.pdf - Adobe Acrobat Reader (32-bit)");

            //if (hWnd == IntPtr.Zero)
            //{
            //    Console.WriteLine("Window not found!");
            //    return;
            //}

            //// Set the window as foreground
            //SetForegroundWindow(hWnd);

            //sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_A);
            //sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_C);
            ////sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.MENU, VirtualKeyCode.F4);

            //System.Threading.Thread.Sleep(2000);
            //hWnd = FindWindow(null, "test.txt - Notepad");

            //if (hWnd == IntPtr.Zero)
            //{
            //    Console.WriteLine("Window not found!");
            //    return;
            //}

            //// Set the window as foreground
            //SetForegroundWindow(hWnd);

            //System.Threading.Thread.Sleep(2000);
            //sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
            //sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_A);

            //sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.DELETE);
            //System.Threading.Thread.Sleep(2000);
            //sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_S);






            //----------------------------------------------------------pdfpig
            //var timeoff = new TimeOff();
            //TimeOff.GetMenu();

            //var DownloadDirectory = "C:\\Users\\jakub.jaros\\Desktop\\Test";
            //var names = Directory.GetFiles(DownloadDirectory);
            //var FileName = names[0];
            //Console.WriteLine(FileName);

            //string text = TimeOff.ExtractTextFromPdf(FileName);
            //Console.WriteLine(text);
            //------------------------------------------------------------



            ///-------------------------------------------------------------goodcode
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
            //------------------------------------------------------------------goodcode
        }
    }
}