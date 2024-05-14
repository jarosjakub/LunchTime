using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LunchTime;

internal class UKluku
{
    public string Menu { get; set; }


    public string GetMenu()
    {

        ChromeOptions options = new ChromeOptions();
        options.AddArguments("--headless=new");

        var url = "https://www.ukluku.cz/";
        IWebDriver driver = new ChromeDriver(options);

        driver.Navigate().GoToUrl(url);

        var ted = DateTime.Now;
        var dnes = ted.ToString("ddd");

        IWebElement tydenMenu = driver.FindElement(By.CssSelector("#post-223 > div > div:nth-child(9) > div > div"));
        IWebElement denMenu = null;

        switch (dnes)
        {
            case "po":
                denMenu = driver.FindElement(By.CssSelector("#post-223 > div > div:nth-child(11) > div > div"));
                break;
            case "út":
                denMenu = driver.FindElement(By.CssSelector("#post-223 > div > div:nth-child(13) > div > div"));
                break;
            case "st":
                denMenu = driver.FindElement(By.CssSelector("#post-223 > div > div:nth-child(15) > div > div"));
                break;
            case "čt":
                denMenu = driver.FindElement(By.CssSelector("#post-223 > div > div:nth-child(17) > div > div"));
                break;
            case "pá":
                denMenu = driver.FindElement(By.CssSelector("#post-223 > div > div:nth-child(19) > div > div"));
                break;
            case "so":
                Console.WriteLine("sobota");
                break;
            case "ne":
                Console.WriteLine("nedele");
                break;
        }
        if (tydenMenu.Displayed && denMenu.Displayed)
        {
            Aestheticals.GreenMessage("YES");
        }

        else
        {
            Aestheticals.RedMessage("NOPE");
        }


        Menu = tydenMenu.Text + "\n" + "--------" + "\n" + denMenu.Text;
        driver.Quit();

        return Menu;
    }
}
