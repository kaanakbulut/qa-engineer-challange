using AmazonAutomation.Specs.Constant;
using AmazonAutomation.Specs.Driver;
using AmazonAutomation.Specs.Page;
using AmazonAutomation.Specs.Page.HomePage;
using AmazonAutomation.Specs.Page.ResultPage;
using AmazonAutomation.Specs.Test;
using NUnit.Framework;
using TechTalk.SpecFlow;


namespace AmazonAutomation.Specs
{
    [Binding]
    public class AmazonWebSiteSearchSteps : StepsBase
    {

        public string ResultPageCurrentUrl { get { return ResultPagePage.GetURL(); } }


        [Given]
        public void GivenIAmOnTheAmazonHomePage()
        {
            HomePagePage.GoToHomePage();
        }
        
        [Given(@"I enter (.*) into search bar")]
        public void IEnterASearchTermIntoSearchBar(string searchTerm)
        {
            HomePagePage.EnterSearchTermIntoSearchBar(searchTerm);
        }
        
        [When]
        public void WhenIClickToSearchButton()
        {
            HomePagePage.ClickSearchButton();
        }
        
        [Then()]
        public void ThenIShouldSeeTheSearchResultPage()
        {
            var searchPageUrl = "www.amazon.com/s?";

            StringAssert.Contains(searchPageUrl.ToLower(), ResultPageCurrentUrl.ToLower());
        }

        [Then(@"I should see the (.*) in search term querystring")]
        public void ThenIShouldSeeTheInSearchTermQueryString(string searchTerm)
        {
            var searchTermQuerySring = "k=" + searchTerm;
            StringAssert.Contains(searchTermQuerySring.ToLower(), ResultPageCurrentUrl.ToLower());
        }

        [Then]
        public void ThenThereShouldBeAtLeastOneProductOnPage()
        {
            Assert.True(ResultPagePage.GetResultItemCount() > 0);
        }

        [Given(@"I select (.*) from search dropdown")]
        public void GivenISelectFromSearchDropdown(string selectedCategory)
        {
            HomePagePage.SelectCategoryFromSearchDropDown(selectedCategory);
        }

        [Then(@"I should see (.*) in category alias query string")]
        public void ThenIShouldSeeInCategoryAliasQueryString(string selectedCategoryAlias)
        {
            var categoryAliasQueryString = "i=" + selectedCategoryAlias;
            StringAssert.Contains(categoryAliasQueryString.ToLower(), ResultPageCurrentUrl.ToLower());
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            _driver.Dispose();
        }
    }
}
