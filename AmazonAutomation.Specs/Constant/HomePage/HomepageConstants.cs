using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonAutomation.Specs.Constant.HomePage
{
    public class HomepageConstants : ConstantsBase
    {
        public static IWebElement SearchBar { get { return _driver.FindElement(By.Id("twotabsearchtextbox")); } }
        public static IWebElement SearchButton { get { return _driver.FindElement(By.Id("nav-search-submit-button")); } }

        public static IWebElement SearchDropDown { get { return _driver.FindElement(By.Id("searchDropdownBox")); } }

        

    }
}
