using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonAutomation.Specs.Constant.HomePage
{
    public class TodaysDealsPageConstants : ConstantsBase
    {
        public static IWebElement DealsAndPromotionsPageTitle { get { return _driver.FindElement(By.XPath("//div[@class='fst-h1-st pageBanner']/h1")); } }
        public static IWebElement AddToCartButton { get { return _driver.FindElements(By.CssSelector("span[class='a-button a-button-normal a-button-span12 a-button-primary fixedWidth210']"))[0]; } }
        public static IWebElement ItemCountInCart { get { return _driver.FindElement(By.Id("nav-cart-count")); } }

    }
}
