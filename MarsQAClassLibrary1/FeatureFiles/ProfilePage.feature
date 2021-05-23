Feature: ProfilePage
	In order to test the add profile details functionality
	As a seller
	I want to be able to validate my profile details

@mytag
Scenario:  seller is able to add the profile details 
	Given i signed in the MarsQA portal
	And i am at the profile page
	When i enter the details 
	Then i save my details on the profile page

