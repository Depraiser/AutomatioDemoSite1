Feature: Register
	In order to have assess to all the benefits on the website 
	I will need to register first

@mytag
Scenario: Vaild registration
	Given I navigate to the website
	And Click on register button
	And I enter my first name
	And I enter my last name
	And I enter my address
	And I enter my email
	And I enter my phone number
	And I click on gender
	And I click on hobbies
	#And I click on languages
	#And I select language
	#And I click on country 
	#And I select country
	#And I click on yaer 
	#And I select year
	#And I click on month
	#And I select month
	#And I click on day
	#And I select day
	And I enter password
	And I enter confirm password
	When I click on submit
	#Then I should be able to register succefully