Feature: Test1AddNewProduct
	In order to avoid mistakes sum of two numbers

@mytag
Scenario: Add New 
	Given I open "http://localhost:5000" pages
	When  I login with "user" username and "user" passwoord
	And I Click button "All Product" and "Create new"
	And I have entered product with product "Charlotte" and "163" UnitPrice and CLick Send button
	Then Product added is succesful add
