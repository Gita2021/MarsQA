Feature: LoginPage
	In order to test the login functionality
	As a user
	I want to be able to validate the login works

	@mytag
	Scenario: When valid credentials are used should result in successfull login
	Given i am at MarsQA portal
	And i click signIn button
	When i enter valid creds
	Then i should be logged in successfully

	@mytag
	Scenario: When invalid username is used should result in failure to login
	Given i am at MarsQA portal
	And i click signIn button
	When i login with username '(.*)'
	Then i should not be logged in

	@mytag
	Scenario: When password is not valid should result in failure to login
	Given i am at MarsQA portal
	And i click signIn button
	When i login with <username> and with <password>
	Then i should not be logged in 
	Examples:
	| username              | password        |
	| gitabtechit@gmail.com | Keerthi19121983 |
	| gitabtechit@gmail.com | xxxdddd         |