Feature: AmazonWebSiteSearch
	In order to buy something
	As a customer
	I want to search for some products 

Scenario: Search completed successfully
	Given I am on the Amazon home page
		And I enter <SearchTerm> into search bar
	When I click to search button
	Then I should see the search result page
		And I should see the <SearchTerm> in search term querystring
		And There should be at least one product on page
Examples:
 | SearchTerm |
 | Samsung    |

 Scenario: Category based search completed successfully
	Given I am on the Amazon home page
		And I select <SelectedCategory> from search dropdown
		And I enter <SearchTerm> into search bar
	When I click to search button
	Then I should see the search result page
		And I should see the <SearchTerm> in search term querystring
		And I should see <SelectedCategoryAlias> in category alias query string
		And There should be at least one product on page
Examples:
 | SearchTerm | SelectedCategory | SelectedCategoryAlias |
 | Samsung    | Electronics      | electronics-intl-ship |
