using AmazonAutomation.Specs.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonAutomation.Specs.Page
{
    public class PageBase
    {
        public static IWebDriver _driver;

        public static void Init(IWebDriver driver)
        {
            _driver = driver;
        }

    }
}
