Feature: NW
	As NorthWind user
	I want to verify login to the application


Scenario: Login with valid credentials

	Given I open "http://localhost:5000" url
	When I login with "user" username and "user" password
	Then Login is successfull

Scenario: Login with invalid credentials

	Given I open "http://localhost:5000" url
	When I login with "user" username and "user1" password
	Then Login is failed



