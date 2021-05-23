using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;

namespace MarsQAClassLibrary1.Pages
{
    class HomePage
    {
        private IWebDriver driver;
        private IWebElement profileButton => driver.FindElement(By.XPath("//*[@class = 'ui eight item menu']/a[2]"));
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public HomePage()
        {
        }

        public void navigateToProfile(IWebDriver driver)

        {
            //click Profile

            profileButton.Click();
            
            Thread.Sleep(1500);

        }
            
            
    }
}
