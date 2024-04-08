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
          
        
        public string Menu()
        {
        var url = "https://www.slezska.com/?#poledni_menu";
        IWebDriver driver = new ChromeDriver();
            
            driver.Navigate().GoToUrl(url);





            return Menu;
            }
    }
}
