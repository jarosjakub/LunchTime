﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LunchTime
{
    public static class Driver
    {
        public static IWebDriver driver = new ChromeDriver();
    }
}