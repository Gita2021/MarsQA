using MarsQAClassLibrary1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsQAClassLibrary1.Utilities
{
    class CommonDriver
    {
        public IWebDriver driver;



        [OneTimeSetUp]
        public void gotoLoginPg()

        {
            Console.WriteLine("Hello World!");

            //define driver for all classes

            driver = new ChromeDriver(@"C:\SeleniumRepo");
            
            //define object for LoginPage
            LoginPage loginObj = new LoginPage();
            loginObj.loginSteps(driver);

            /*****
             //define object for home page
             HomePage homeObj = new HomePage();
             homeObj.navigateToProfile(driver);

            //define object for profile page
            ProfilePage profileObj = new ProfilePage();
            profileObj.addCertifications(driver);
            profileObj.addEducation(driver);
            profileObj.addLanguages(driver);
            profileObj.addSkills(driver);
            *****/

        }

        [OneTimeTearDown]
        public void FinalSteps()
        {
            //driver.Close();

        }
    }
}


