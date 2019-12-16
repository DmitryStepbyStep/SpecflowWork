Feature:Test3Delete_Product_2
NW
Delete Product

@mytag
Scenario: Delete_Product_2
	Given I open "http://localhost:5000" p
	When  I login with "user" u and "user" pa
	And I Click button "All Product"  and delete product
	
	Then Product delete is succesful 

