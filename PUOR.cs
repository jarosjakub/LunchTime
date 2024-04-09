using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchTime
{
    public class PUOR
    {
        public string Menu { get; set; }


        public string GetMenu()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--headless=new");


            var url = "https://www.slezska.com/?#poledni_menu";
            IWebDriver driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl(url);

            IWebElement Polevka = driver.FindElement(By.CssSelector("#antilukas > div:nth-child(7) > table > tbody > tr:nth-child(3)"));

            IWebElement VIPjidlo = driver.FindElement(By.CssSelector("#antilukas > div:nth-child(7) > table > tbody > tr:nth-child(4)"));
            IWebElement Jidlo1 = driver.FindElement(By.CssSelector("#antilukas > div:nth-child(7) > table > tbody > tr:nth-child(5)"));
            IWebElement Jidlo2 = driver.FindElement(By.CssSelector("#antilukas > div:nth-child(7) > table > tbody > tr:nth-child(6)"));
            IWebElement Jidlo3 = driver.FindElement(By.CssSelector("#antilukas > div:nth-child(7) > table > tbody > tr:nth-child(7)"));
            IWebElement LCjidlo = driver.FindElement(By.CssSelector("#antilukas > div:nth-child(7) > table > tbody > tr:nth-child(8)"));

            if (Polevka.Displayed && VIPjidlo.Displayed && Jidlo1.Displayed && Jidlo2.Displayed && Jidlo3.Displayed && LCjidlo.Displayed)
            {
                Aestheticals.GreenMessage("YES");
            }

            else
            {
                Aestheticals.RedMessage("NOPE");
            }

            string [] menu = new string[] { Polevka.Text, VIPjidlo.Text, Jidlo1.Text, Jidlo2.Text, Jidlo3.Text, LCjidlo.Text };
            Menu = string.Join("\n\n", menu);

            return Menu;

            Thread.Sleep(5000);

            driver.Quit();

            
        }
    }
}
