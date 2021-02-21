using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonAutomation.Specs.Constant.ShoppingCart
{
    public class ShoppingCartConstants : ConstantsBase
    {
        public static IWebElement AddToCartButton { get { return _driver.FindElements(By.Name("submit.addToCart"))[0]; } }
        public static IWebElement CartButton { get { return _driver.FindElement(By.Id("hlb-view-cart-announce")); } }
        public static IReadOnlyCollection<IWebElement> CartItems { get { return _driver.FindElements(By.CssSelector("div[data-asin]")); } }
        public static IWebElement DeleteButton { get { return _driver.FindElements(By.CssSelector("input[value='Delete']"))[0]; } }
    }
}
