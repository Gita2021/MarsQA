using MarsQAClassLibrary1.Pages;
using MarsQAClassLibrary1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace MarsQAClassLibrary1
{   
    [TestFixture]
     class Class1 : CommonDriver
    {
        //static void Main(string[] args)
        //{

        //}
        

       /**
        [Test]
        public void gotoProfilePg()
        {
            //define objects for HomePage
            HomePage homeObj = new HomePage();
            homeObj.navigateToProfile(driver);

        } 
       **/
        [Test]
        public void gotoProfilePg()
        {
            //define objects for HomePage
            HomePage homeObj = new HomePage();
            homeObj.navigateToProfile(driver);

            //define object for ProfilePage
            ProfilePage profileObj = new ProfilePage();
            profileObj.addLanguages(driver);
            profileObj.addSkills(driver);
            profileObj.addEducation(driver);
            profileObj.addCertifications(driver);
            profileObj.createProfile(driver);

        }
        



        
    }

}