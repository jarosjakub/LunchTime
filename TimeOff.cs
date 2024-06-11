using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using UglyToad.PdfPig;
using WindowsInput;
using WindowsInput.Native;



namespace LunchTime
{
    public class TimeOff
    {
        //public string Menu { get; set; }

        public void DownloadMenu()
        {
            var DownloadDirectory = "C:\\Users\\jakub.jaros\\Desktop\\Test";



            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("plugins.always_open_pdf_externally", true);
            options.AddUserProfilePreference("download.default_directory", DownloadDirectory);
            options.AddUserProfilePreference("download.prompt_for_download", false);
            options.AddUserProfilePreference("profile.default_content_setting_values.automatic_downloads", 0);
            options.AddArguments("--headless=new");

            var url = "https://timeoff.cz/";
            IWebDriver driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl(url);

            IWebElement DownloadLink = driver.FindElement(By.CssSelector("#post-25 > div > div > div > div > div.et_pb_row.et_pb_row_2 > div.et_pb_column.et_pb_column_1_3.et_pb_column_7.et_pb_css_mix_blend_mode_passthrough > div.et_pb_button_module_wrapper.et_pb_button_0_wrapper.et_pb_module > a"));
            DownloadLink.Click();
            Thread.Sleep(1000);

            driver.Quit();
        }

        public void GetText()
        {
            var filePath = "C:\\Users\\jakub.jaros\\Desktop\\Test\\test.txt";
            var filePath2 = "C:\\Users\\jakub.jaros\\Desktop\\Test\\tyden24OR.pdf";

            var notepad = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                }
            };

            var menu = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = filePath2,
                    UseShellExecute = true
                }
            };

            notepad.Start();
            menu.Start();
            

            [DllImport("user32.dll")]
            static extern bool SetForegroundWindow(IntPtr hWnd);

            [DllImport("user32.dll")]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

            var file = "C:\\Users\\jakub.jaros\\Desktop\\Test\\tyden24OR.pdf";
            var file2 = "C:\\Users\\jakub.jaros\\Desktop\\Test\\test.txt";
            var sim = new InputSimulator();

            System.Threading.Thread.Sleep(2000);
            IntPtr hWnd = FindWindow(null, "tyden24OR.pdf - Adobe Acrobat Reader (32-bit)");

            if (hWnd == IntPtr.Zero)
            {
                Console.WriteLine("Window not found!");
                return;
            }

            // Set the window as foreground
            SetForegroundWindow(hWnd);

            sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_A);
            sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_C);

            System.Threading.Thread.Sleep(2000);
            hWnd = FindWindow(null, "test.txt - Notepad");

            if (hWnd == IntPtr.Zero)
            {
                Console.WriteLine("Window not found!");
                return;
            }

            // Set the window as foreground
            SetForegroundWindow(hWnd);

            System.Threading.Thread.Sleep(2000);
            sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
            //System.Threading.Thread.Sleep(2000);
            //sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_A);
            //sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.DELETE);
            System.Threading.Thread.Sleep(2000);
            sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_S);
            System.Threading.Thread.Sleep(2000);

            menu.Kill();
            notepad.Kill();
        }

        //private void Select() { 
        //    SendKeys.Send("^a");
        //    Thread.Sleep(1000);

        //    var names = Directory.GetFiles(DownloadDirectory);
        //    var FileName = names[0];
        //    Console.WriteLine(FileName);








        ////pdfpig
        public static string ExtractTextFromPdf(string FileName)
        {
            StringBuilder text = new StringBuilder();

            using (PdfDocument pdf = PdfDocument.Open(FileName))
            {
                foreach (var page in pdf.GetPages())
                {
                    text.Append(page.Text);
                }
            }

            return text.ToString();

        }

        //File.Delete(FileName);
    }
}
