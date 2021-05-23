using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using MarsQAClassLibrary1.Utilities;

namespace MarsQAClassLibrary1.Pages
{
    class LoginPage
    {
        private IWebDriver driver;
        private IWebElement signIn => driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
        private IWebElement username => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
        private IWebElement password => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        private IWebElement rememberMe => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[3]/div/input"));
        private IWebElement loginButton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        public LoginPage(IWebDriver driver) 
        {
            this.driver = driver;
        }
        
        public LoginPage()
        {
        }
       
        public void loginSteps(IWebDriver driver)
        {

            //launch MarsQA portal
            driver.Navigate().GoToUrl("http://localhost:5000/");

            //maximise window
            driver.Manage().Window.Maximize();

            try
            {

                //Wait.ElementExists(driver, "XPath", "//*[@id='home']/div/div/div[1]/div/a", 5);

                //click on Sign In button
                signIn.Click();
                // identify and enter username
                username.SendKeys("gitabtechit@gmail.com");
                // identify and enter password
                password.SendKeys("Keerthi19121983");
                //click Remember Me
                rememberMe.Click();
                // identify and click login button
                loginButton.Click();
            }
            catch (Exception msg)
            {
                Assert.Fail("Test failed at login page", msg.Message);
            }
        }

            public void enterGivenUsernameAndPasswordRefactored(string usernameValue, string passwordValue)
            {
                try
                {
                    //Wait.ElementExists(driver, "Id", "UserName", 5);


                    if (usernameValue != null)
                    {
                        Console.WriteLine("enterUsername " + usernameValue);

                        username.SendKeys(usernameValue);
                    }
                    else
                    {
                        Console.WriteLine("enterUsername " + "gitabtechit@gmail.com");

                        username.SendKeys("gitabtechit@gmail.com");
                    }


                    if (passwordValue != null)
                    {
                        Console.WriteLine("passwordValue " + passwordValue);
                        // enter password
                        password.SendKeys(passwordValue);
                    }
                    else
                    {

                        Console.WriteLine("passwordValue " + "Keerthi19121983");
                        // enter default password
                        password.SendKeys("Keerthi19121983");

                    }


                }
                catch (Exception msg)
                {
                    Assert.Fail("Test failed at login page", msg.Message);
                }
            }

            public void login(string usernameValue, string passwordValue)
            {
                navigateToLoginPage();
                enterGivenUsernameAndPasswordRefactored(usernameValue, passwordValue);
                clickLoginButton();
                
            }

            public void navigateToLoginPage()
            {
                driver.Navigate().GoToUrl("http://localhost:5000/");
                // maximize browser
                driver.Manage().Window.Maximize();
            }

            public bool validateThaYouAreLoginPage()
            {
                return loginButton.Displayed;
            }


            public void clickLoginButton()
            {
                loginButton.Click();
            }
        
       



    }
}
