using MarsQAClassLibrary1.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQAClassLibrary1.Steps
{
    [Binding]
    public class HomePageSteps
    {
        private readonly IWebDriver driver;
        private LoginPage loginPage;
        private HomePage homePage;

        public HomePageSteps()
        {
            driver = new ChromeDriver(@"C:\SeleniumRepo");
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            
        }

        [Given(@"i signed in")]
        public void GivenISignedIn()
        {
            loginPage.loginSteps(driver);
            Console.WriteLine("I signed in");
        }
        
        [Given(@"i goto the profile page")]
        public void GivenIGotoTheProfilePage()
        {
            homePage.navigateToProfile(driver);
            Console.WriteLine("I click the profile page");
        }
    }
}
