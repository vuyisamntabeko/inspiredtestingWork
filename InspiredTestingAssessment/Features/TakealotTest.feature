Feature: TakealotTest
	Simple calculator for adding two numbers

@mytag
Scenario: Checkout an item
	Given I launch Takealot Site
	Then I should see Takealot Home Page
	When I Click on the Item
	Then I should see Item Page
	When I Click on add To Cart
	And I Click on Go To Cart
	Then I should See Cart Screen
	Then I Click on Proceed To Checkout
	#Then I should Checkout

