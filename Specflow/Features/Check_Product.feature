Feature:Test2Check_Product
NW
Check Product

@mytag
Scenario: Check_Product
	Given I open "http://localhost:5000" pag
	When  I login with "user" us and "user" pas
	And I Check product
	
	Then product exists
