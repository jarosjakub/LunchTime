using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
            IWebElement jidlo1 = driver.FindElement(By.CssSelector("#antilukas > div:nth-child(7) > table > tbody > tr:nth-child(5)"));
            IWebElement jidlo2 = driver.FindElement(By.CssSelector("#antilukas > div:nth-child(7) > table > tbody > tr:nth-child(6)"));
            IWebElement jidlo3 = driver.FindElement(By.CssSelector("#antilukas > div:nth-child(7) > table > tbody > tr:nth-child(7)"));
            IWebElement LCjidlo = driver.FindElement(By.CssSelector("#antilukas > div:nth-child(7) > table > tbody > tr:nth-child(8)"));

            if (Polevka.Displayed && VIPjidlo.Displayed && jidlo1.Displayed && jidlo2.Displayed && jidlo3.Displayed && LCjidlo.Displayed)
            {
                Aestheticals.GreenMessage("YES");
            }

            else
            {
                Aestheticals.RedMessage("NOPE");
            }

            string[] menu = new string[] { Polevka.Text, VIPjidlo.Text, jidlo1.Text, jidlo2.Text, jidlo3.Text, LCjidlo.Text };
            driver.Quit();

            Menu = string.Join("\n\n", menu);

            return Menu;




        }
    }
}