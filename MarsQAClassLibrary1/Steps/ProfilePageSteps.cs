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
    public class ProfilePageSteps
    {
        private readonly IWebDriver driver;
        private LoginPage loginPage;
        private HomePage homePage;
        private ProfilePage profilePage;


        public ProfilePageSteps()
        {
            driver = new ChromeDriver(@"C:\SeleniumRepo");
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            profilePage = new ProfilePage(driver);
        }

        [Given(@"i signed in the MarsQA portal")]
        public void GivenISignedInMarsQAPortal()
        {
            loginPage.loginSteps(driver);
            Console.WriteLine("I signed in the MarsQA portal");
        }

        [Given(@"i am at the profile page")]
        public void GivenIAmAtProfilePage()
        {
            homePage.navigateToProfile(driver);
            Console.WriteLine("I am at the profile page");
        }

        [When(@"i enter the details")]
        public void WhenIEnterDetails()
        {
            profilePage.addLanguages(driver);
            profilePage.addSkills(driver);
            profilePage.addEducation(driver);
            profilePage.addCertifications(driver);
            profilePage.createProfile(driver);
            Console.WriteLine("I enter the details");
        }
        
        [Then(@"i save my details on the profile page")]
        public void ThenISaveMyProfileDetailsOnProfilePage()
        {
            Console.WriteLine("I save my details on the profile page");
           // Assert.IsFalse(true);
        }

        
        
    }
}

