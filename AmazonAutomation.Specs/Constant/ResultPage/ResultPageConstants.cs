using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonAutomation.Specs.Constant.ResultPage
{
    public class ResultPageConstants : ConstantsBase
    {
        public static string Url { get { return _driver.Url; } }
        public static  IReadOnlyCollection<IWebElement> ResultItems { get { return _driver.FindElements(By.CssSelector("[data-component-type='s-search-result']")); } }
        
    }
}
