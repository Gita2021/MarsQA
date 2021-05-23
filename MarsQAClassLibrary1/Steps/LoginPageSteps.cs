using MarsQAClassLibrary1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQAClassLibrary1.Steps
{
    [Binding]
    public class LoginPageSteps
    {
        private readonly IWebDriver driver;
        private LoginPage loginPage;
        public LoginPageSteps()
        {
            driver = new ChromeDriver(@"C:\SeleniumRepo");
            loginPage = new LoginPage(driver);
        }

        [AfterScenario]
        public void RunAfterEveryTest()
        {
            driver.Close();
        }
        
        [Given("i am at MarsQA portal")]
        public void GivenIAmAtMarsQAPortal()
        {

            bool isAtLoginPage = loginPage.validateThaYouAreLoginPage();
            Assert.IsTrue(isAtLoginPage);

        }

        [Given("i click signIn button")]
        public void GivenIClickSignInButton()
        {

            Console.WriteLine("I click signIn button");

        }
        [When("i enter valid creds")]
        public void WhenIValidCreds()
        {

            loginPage.enterGivenUsernameAndPasswordRefactored(null, null);

            Console.WriteLine("I enter valid creds");

        }

        [When(@"i login with username '(.*)'")]

        public void WhenILoginWithUsername(string username)
        {
            loginPage.enterGivenUsernameAndPasswordRefactored(username, null);
            Console.WriteLine("i login with username =" + username);
        }

        [When(@"i login with (.*) and with (.*)")]
        
        public void WhenILoginWithUsernameAndPassword(string username, string password)
        {

            loginPage.enterGivenUsernameAndPasswordRefactored(username, password);
            Console.WriteLine("i login with (.*) and with (.*)");
        }

        [Then(@"i should not be logged in")]
        public void ThenIShouldNotBeLoggedIn()
        {
            
            Console.WriteLine("i should not be logged in");
           
        }

        [Then("i should be logged in successfully")]
        public void ThenIShouldBeLoggedInSuccessfully()
        {
            
            Console.WriteLine("I should be logged in successfully");

           
        }
    }
}
