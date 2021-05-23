using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using MarsQAClassLibrary1.Pages;
using MarsQAClassLibrary1.Steps;
using MarsQAClassLibrary1.FeatureFiles;
using MarsQAClassLibrary1.Utilities;


namespace MarsQAClassLibrary1.Utilities
{
    class waits
    {

        
        
            // (fluent wait) - generic function to wait - element exists
            public static void ElementExists(IWebDriver driver, String locator, String locatorValue, int seconds)
            {
                try
                {
                    if (locator == "Id")
                    {
                        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("locatorValue")));
                    }
                    if (locator == "XPath")
                    {
                        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("locatorValue")));
                    }
                    if (locator == "CssSelector")
                    {
                        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("locatorValue")));
                    }

                }
                catch (Exception ex)
                {
                    Assert.Fail("Test failed waiting for element to exists", ex.Message);
                }

            }


            // (fluent wait) - generic function to wait - element clickable
            public static void ElementClickable(IWebDriver driver, String locator, String locatorValue, int seconds)
            {
                try
                {
                    if (locator == "Id")
                    {
                        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("locatorValue")));
                    }
                    if (locator == "XPath")
                    {
                        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("locatorValue")));
                    }
                    if (locator == "CssSelector")
                    {
                        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("locatorValue")));
                    }

                }
                catch (Exception ex)
                {
                    Assert.Fail("Test failed waiting for element to exists", ex.Message);
                }

            }



        
    }
}
