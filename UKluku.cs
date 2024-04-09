using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchTime
{
    internal class UKluku
    {
        public string Menu { get; set; }


        public string GetMenu()
        {
            var url = "https://www.ukluku.cz/";
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(url);

            IWebElement element = driver.FindElement(By.CssSelector("#antilukas > div:nth-child(7) > table > tbody > tr:nth-child(4) > td:nth-child(2)"));

            if (element.Displayed)
            {
                Aestheticals.GreenMessage("YES");
                Menu = element.Text;
            }

            else
            {
                Aestheticals.RedMessage("NOPE");
            }

            Thread.Sleep(5000);

            driver.Quit();

            return Menu;
        }
    }
}
