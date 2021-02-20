using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonAutomation.Specs.Driver
{
    public class WebDriver
    {
        public IWebDriver Driver { get; private set; }

        public void Run()
        {
            if (Driver == null)
                Driver = new ChromeDriver();

            Driver.Manage().Window.Maximize();
        }

        public void Dispose()
        {
            Driver.Quit();
            if (Driver != null)
                Driver = null;
            
                
        }
    }
}
