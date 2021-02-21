using AmazonAutomation.Specs.Constant.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonAutomation.Specs.Page.ShoppingCartPage
{
    public class ShoppingCartPagePage : PageBase
    {
        public static void GoToShoppingCartPage()
        {
            _driver.Navigate().GoToUrl("https://www.amazon.com/gp/cart/view.html");
        }

        public static void AddProductToCart()
        {
            ShoppingCartConstants.AddToCartButton.Click();
        }

        public static void ClickCartButton()
        {
            ShoppingCartConstants.CartButton.Click();
        }

        public static int GetCartItemsCount()
        {
            return ShoppingCartConstants.CartItems.Count;
        }

        public static void DeleteCartItem()
        {
            ShoppingCartConstants.DeleteButton.Click();
            System.Threading.Thread.Sleep(2000);
        }
    }
}
