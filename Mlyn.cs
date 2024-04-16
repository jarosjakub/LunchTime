using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchTime
{
    internal class Mlyn
    {
        public string Menu { get; set; }


        public string GetMenu()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--headless=new");
            options.AddArguments("window-size=1920,1080");

            var url = "https://www.trebovickymlyn.cz/#menu";
            IWebDriver driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl(url);

            IWebElement polevka = driver.FindElement(By.CssSelector("#container > div:nth-child(5) > div > div > div:nth-child(1) > div > div > div.menu-box.owl-wrapper > div.item > div > div"));
            IWebElement jidlo1 = driver.FindElement(By.CssSelector("#container > div:nth-child(5) > div > div > div:nth-child(1) > div > div > div.menu-box.owl-wrapper > div.owl-carousel.owl-theme > div.owl-wrapper-outer > div > div:nth-child(1) > div > div:nth-child(1) > div"));
            IWebElement jidlo2 = driver.FindElement(By.CssSelector("#container > div:nth-child(5) > div > div > div:nth-child(1) > div > div > div.menu-box.owl-wrapper > div.owl-carousel.owl-theme > div.owl-wrapper-outer > div > div:nth-child(1) > div > div:nth-child(2) > div"));
            IWebElement jidlo3 = driver.FindElement(By.CssSelector("#container > div:nth-child(5) > div > div > div:nth-child(1) > div > div > div.menu-box.owl-wrapper > div.owl-carousel.owl-theme > div.owl-wrapper-outer > div > div:nth-child(1) > div > div:nth-child(3) > div"));
            IWebElement jidlo4 = driver.FindElement(By.CssSelector("#container > div:nth-child(5) > div > div > div:nth-child(1) > div > div > div.menu-box.owl-wrapper > div.owl-carousel.owl-theme > div.owl-wrapper-outer > div > div:nth-child(2) > div > div:nth-child(1) > div"));
            IWebElement jidlo5 = driver.FindElement(By.CssSelector("#container > div:nth-child(5) > div > div > div:nth-child(1) > div > div > div.menu-box.owl-wrapper > div.owl-carousel.owl-theme > div.owl-wrapper-outer > div > div:nth-child(2) > div > div:nth-child(2) > div"));

            if (polevka.Displayed && jidlo1.Displayed && jidlo2.Displayed && jidlo4.Displayed && jidlo5.Displayed)
            {
                Aestheticals.GreenMessage("YES");
            }

            else
            {
                Aestheticals.RedMessage("NOPE");
            }





            Menu = polevka.Text + "\n" + jidlo1.Text + "\n" + jidlo2.Text + "\n" + jidlo3.Text + "\n" + jidlo4.Text + "\n" + jidlo5.Text;
            driver.Quit();

            return Menu;


            //if (element.Displayed)
            //{
            //    Aestheticals.GreenMessage("YES");
            //    Menu = element.Text;
            //}

            //else
            //{
            //    Aestheticals.RedMessage("NOPE");
            //}

            //Thread.Sleep(5000);

            //driver.Quit();

            //return Menu;
        }
    }
}
