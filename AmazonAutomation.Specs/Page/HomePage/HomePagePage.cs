using AmazonAutomation.Specs.Constant.HomePage;
using AmazonAutomation.Specs.Page.ResultPage;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace AmazonAutomation.Specs.Page.HomePage
{
    public class HomePagePage : PageBase
    {
        public static string SearchTerm { get; set; }
        public static void GoToHomePage()
        {
            _driver.Navigate().GoToUrl("https://www.amazon.com/");
        }

        public static void EnterSearchTermIntoSearchBar(string searchTerm)
        {
            SearchTerm = searchTerm;
            HomepageConstants.SearchBar.SendKeys(searchTerm);
        }

        public static void ClickSearchButton()
        {
            HomepageConstants.SearchButton.Click();

        }

        public static void SelectCategoryFromSearchDropDown(string selectedCategory)
        {
            var  dropdown = new SelectElement(HomepageConstants.SearchDropDown);
            dropdown.SelectByText(selectedCategory);

        }

    }
}
