using AmazonAutomation.Specs.Constant.HomePage;
using System;

namespace AmazonAutomation.Specs.Page.HomePage
{
    public class TodaysDealsPagePage : PageBase
    {
        public static string SearchTerm { get; set; }
        public static void GoToTodaysDealsPage()
        {
            _driver.Navigate().GoToUrl("https://www.amazon.com/international-sales-offers/b/?ie=UTF8&node=15529609011");
        }

        public static string GetDealsAndPromotionsPageTitle()
        {
            return TodaysDealsPageConstants.DealsAndPromotionsPageTitle.Text;
        }

        public static void ClickFirstAddToCartButton()
        {

            TodaysDealsPageConstants.AddToCartButton.Click();
            System.Threading.Thread.Sleep(2000);
        }

        public static byte GetItemCountInCart()
        {
            var itemCount = Convert.ToByte(TodaysDealsPageConstants.ItemCountInCart.Text);
            
            return itemCount;
        }
    }
}
