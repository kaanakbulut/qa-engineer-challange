Feature: AmazonWebSiteCart
	In order to buy something
	As a customer
	I want to add some products to cart 

Scenario: Product added to cart successfully
	Given I am on the Today's Deals page
		And I see <DealsAndPromotionsPageTitle> title on the page
	When I click first Add To Cart button on the page
	Then I should see the number is increased on cart logo
Examples:
 | DealsAndPromotionsPageTitle |
 | Deals and Promotions        |

 Scenario: Product deleted from cart successfully
	Given I am on the Shopping Cart page
		And I add product to cart
		And I click Cart button
		And I see products listed on the page
	When I click delete button
	Then I should see that product is deleted