using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.ComponentModel;

namespace LunchTime
{
    internal class Program
    {
        static void Main()
        {
            //TEST

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--headless=new");

            var url = "https://www.trebovickymlyn.cz/#menu";
            IWebDriver driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl(url);

            IWebElement jidlo = driver.FindElement(By.CssSelector("#menureveal > div.owl-carousel.owl-theme > div.owl-wrapper-outer"));

            Console.WriteLine(jidlo.Text);
            driver.Quit();

            //TEST


            //var mlyn = new Mlyn();
            //mlyn.GetMenu();
            ////Console.WriteLine(mlyn.Menu);



            //var puor = new PUOR();
            //puor.GetMenu();

            ////Aestheticals.GreenMessage(puor.Menu);

            //var kluci = new UKluku();
            //kluci.GetMenu();

            //Console.Clear();

            //Console.WriteLine("PUOR" + "\n" + "-----------------------" + "\n");
            //Console.WriteLine(puor.Menu);
            //Console.WriteLine("\n" + "U Kluků" + "\n" + "-----------------------" + "\n");
            //Console.WriteLine(kluci.Menu);
            //Console.WriteLine("\n" + "Třebovický mlýn" + "\n" + "-----------------------" + "\n");
            //Console.WriteLine(mlyn.Menu);

        }
    }
}