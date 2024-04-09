﻿using OpenQA.Selenium.Chrome;
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
            return Menu;
            //Thread.Sleep(5000);

            driver.Quit();

            
        }
    }
}
