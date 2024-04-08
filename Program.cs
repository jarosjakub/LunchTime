using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.ComponentModel;

namespace SeleniumWD
{
    internal class Program
    {
        static void Main()
        {
            IWebDriver driver = new ChromeDriver();
            //var url = "https://www.trebovickymlyn.cz/#menu";
            //var url = "https://www.ukluku.cz/";
            var url = "https://www.slezska.com/?#poledni_menu";
            var csspath = "#post-108 > div > figure > img";
            var xpath = "//*[@id=\"post-108\"]/div/p";

            driver.Navigate().GoToUrl(url);

            //mlyn dnes
            //IWebElement element = driver.FindElement(By.CssSelector("#container > div:nth-child(5) > div > div > div:nth-child(1) > div > div > div.menu-box.owl-wrapper > div.owl-carousel.owl-theme > div.owl-wrapper-outer > div > div:nth-child(1)")); 
            //IWebElement element2 = driver.FindElement(By.CssSelector("#container > div:nth-child(5) > div > div > div:nth-child(1) > div > div > div.menu-box.owl-wrapper > div.owl-carousel.owl-theme > div.owl-wrapper-outer > div > div:nth-child(2)"));

            //IWebElement element = driver.FindElement(By.CssSelector("#container > div:nth-child(5) > div > div > div:nth-child(1) > div > div > div.menu-box.owl-wrapper > div.owl-carousel.owl-theme > div.owl-wrapper-outer > div > div:nth-child(1) > div > div:nth-child(1) > div"));
            //IWebElement element2 = driver.FindElement(By.CssSelector("#container > div:nth-child(5) > div > div > div:nth-child(1) > div > div > div.menu-box.owl-wrapper > div.owl-carousel.owl-theme > div.owl-wrapper-outer > div > div:nth-child(1) > div > div:nth-child(2) > div"));
            //IWebElement element3 = driver.FindElement(By.CssSelector("#container > div:nth-child(5) > div > div > div:nth-child(1) > div > div > div.menu-box.owl-wrapper > div.owl-carousel.owl-theme > div.owl-wrapper-outer > div > div:nth-child(2) > div > div:nth-child(1) > div"));
            //IWebElement element4 = driver.FindElement(By.CssSelector("#container > div:nth-child(5) > div > div > div:nth-child(1) > div > div > div.menu-box.owl-wrapper > div.owl-carousel.owl-theme > div.owl-wrapper-outer > div > div:nth-child(2) > div > div:nth-child(2) > div"));

            //u kluku čtvrtek
            //IWebElement element = driver.FindElement(By.CssSelector("#post-223 > div > div:nth-child(17) > div > div"));

            //slezska VIP dnes
            IWebElement element = driver.FindElement(By.CssSelector("#antilukas > div:nth-child(7) > table > tbody > tr:nth-child(4) > td:nth-child(2)"));

            if (element.Displayed) 
                //&& element2.Displayed && element3.Displayed && element4.Displayed)
            {
                Aestheticals.GreenMessage("YES");
            }
            else
            {
                Aestheticals.RedMessage("NOPE");
            }

            Aestheticals.GreenMessage(element.Text);
            //Aestheticals.GreenMessage(element2.Text);
            //Aestheticals.GreenMessage(element3.Text);
            //Aestheticals.GreenMessage(element4.Text);

            Thread.Sleep(5000);

            driver.Quit();
        }
    }
}