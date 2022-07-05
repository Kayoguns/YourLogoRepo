Feature: YourLogo1
	Simple calculator for adding two numbers

@mytag
Scenario: Printed Summer Dress
	Given I Navigate to the website "http://automationpractice.com/index.php"
	And   I search For "Printed Summer Dress"
	And   I click On search Button
	And  I click on printed summer dress
	And  I click on blue color
	And  I click on drop down 
	And  I select medium
	And  I click on plus sign to add two quatities to basket	
	And  I click on Add to cart
	Then I should be able to see product suceesfully added
	When I click on proceed to check out
	Then I validate total value in the basket
	When I click on the plus sign Button to add three quantities to basket
	Then I confirm the quanties in the basket has been updated sucessfully