using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Graphics;

namespace LunchTime
{
    public class TimeOff
    {
        //public string Menu { get; set; }

        public static void GetMenu()
        {
            var DownloadDirectory = "C:\\Users\\jakub.jaros\\Desktop\\Test";



            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("plugins.always_open_pdf_externally", true);
            options.AddUserProfilePreference("download.default_directory", DownloadDirectory);
            options.AddUserProfilePreference("download.prompt_for_download", false);
            options.AddUserProfilePreference("profile.default_content_setting_values.automatic_downloads", 0);

            var url = "https://timeoff.cz/";
            IWebDriver driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl(url);

            IWebElement DownloadLink = driver.FindElement(By.CssSelector("#post-25 > div > div > div > div > div.et_pb_row.et_pb_row_2 > div.et_pb_column.et_pb_column_1_3.et_pb_column_7.et_pb_css_mix_blend_mode_passthrough > div.et_pb_button_module_wrapper.et_pb_button_0_wrapper.et_pb_module > a"));
            DownloadLink.Click();

            Thread.Sleep(1000);

            var names = Directory.GetFiles(DownloadDirectory);
            var FileName = names[0];
            Console.WriteLine(FileName);

        }







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
