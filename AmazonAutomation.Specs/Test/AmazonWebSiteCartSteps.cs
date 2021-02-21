using AmazonAutomation.Specs.Constant;
using AmazonAutomation.Specs.Driver;
using AmazonAutomation.Specs.Page;
using AmazonAutomation.Specs.Page.HomePage;
using AmazonAutomation.Specs.Page.ShoppingCartPage;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AmazonAutomation.Specs.Test
{
    [Binding]
    public class AmazonWebSiteCartSteps : StepsBase
    {
        public int CartItemCount { get; set; }

        [Given(@"I am on the Today's Deals page")]
        public void GivenIAmOnTheTodaySDealsPage()
        {
            TodaysDealsPagePage.GoToTodaysDealsPage();
        }
     
        [Given(@"I see (.*) title on the page")]
        public void GivenISeeTitleOnThePage(string dealsAndPromotionsPageTitle)
        {
            var pageTitle = TodaysDealsPagePage.GetDealsAndPromotionsPageTitle();

            StringAssert.AreEqualIgnoringCase(dealsAndPromotionsPageTitle, pageTitle);
        }
        
        [When(@"I click first Add To Cart button on the page")]
        public void WhenIClickFirstButtonOnThePage()
        {
            TodaysDealsPagePage.ClickFirstAddToCartButton();
        }
        
        [Then(@"I should see the number is increased on cart logo")]
        public void ThenIShouldSeeTheNumberIsIncreasedOnCartLogo()
        {
            var currentItemCountInCart = TodaysDealsPagePage.GetItemCountInCart();
            Assert.Greater(currentItemCountInCart, 0);
        }

        [Given(@"I am on the Shopping Cart page")]
        public void GivenIAmOnTheShoppingCartPage()
        {
            ShoppingCartPagePage.GoToShoppingCartPage();
        }

        [Given(@"I add product to cart")]
        public void GivenIAddProductToCart()
        {
            ShoppingCartPagePage.AddProductToCart();
        }

        [Given(@"I click Cart button")]
        public void GivenIClickCartButton()
        {
            ShoppingCartPagePage.ClickCartButton();
        }

        
        [Given(@"I see products listed on the page")]
        public void GivenISeeProductsListedOnThePage()
        {
            CartItemCount =  ShoppingCartPagePage.GetCartItemsCount();

            Assert.Greater(CartItemCount, 0);

        }
        
        [When(@"I click delete button")]
        public void WhenIClickDeleteButton()
        {
            ShoppingCartPagePage.DeleteCartItem();
        }
        
        [Then(@"I should see that product is deleted")]
        public void ThenIShouldSeeThatProductIsDeleted()
        {
            var currentCartItemCount = ShoppingCartPagePage.GetCartItemsCount();

            Assert.Less(currentCartItemCount, CartItemCount);
        }


        [AfterScenario]
        public void DisposeWebDriver()
        {
            _driver.Dispose();
        }
    }
}
