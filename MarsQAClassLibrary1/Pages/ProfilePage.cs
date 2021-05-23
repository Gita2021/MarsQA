using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsQAClassLibrary1.Pages
{
    class ProfilePage
    {
        private IWebDriver driver;
        private IWebElement lang_addNewButton => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
        private IWebElement lang_txtbx => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > input[type=text]"));
        private IWebElement langLevel_drpdwn => driver.FindElement(By.CssSelector("# account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select"));
        private IWebElement langLevel_select => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select"));
        private IWebElement lang_addButton => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div.six.wide.field > input.ui.teal.button"));
        private IWebElement skills_tab => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(2)"));
        private IWebElement skills_addNewButton => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
        private IWebElement skills_txtbx => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > input[type=text]"));
        private IWebElement skillLevel_drpdwn => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select"));
        private IWebElement skillLevel_select => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select"));
        private IWebElement skill_addButton => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > span > input.ui.teal.button"));
        private IWebElement education_tab => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a.item.active"));
        private IWebElement edu_addNewButton => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
        private IWebElement edu_collegeTxtbx => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > div.ten.wide.field > input[type=text]"));
        private IWebElement edu_countryDrpdwn => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > div.six.wide.field > select"));
        private IWebElement edu_countrySelect => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > div.six.wide.field > select"));
        private IWebElement edu_titleDrpdwn => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div:nth-child(1) > select"));
        private IWebElement edu_titleSelect => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div:nth-child(1) > select"));
        private IWebElement edu_degreeTxtbx => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div:nth-child(2) > input[type=text]"));
        private IWebElement edu_yearDrpdwn => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.four.wide.field > select"));
        private IWebElement edu_yearSelect => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.four.wide.field > select"));
        private IWebElement edu_addButton => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(3) > div > input.ui.teal.button"));
        private IWebElement certification_tab => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a.item.active"));
        private IWebElement cert_addNewButton => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
        private IWebElement certName_Txtbx => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > div > input"));
        private IWebElement certFrom_Txtbx => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.eight.wide.field > input"));
        private IWebElement cert_yearDrpdwn => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.three.wide.field > select"));
        private IWebElement cert_yearSelect => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.three.wide.field > select"));
        private IWebElement cert_addButton => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div.five.wide.field > input.ui.teal.button"));

        public ProfilePage(IWebDriver driver) 
        {
            this.driver = driver;
        }

        public ProfilePage()
        {
        }

        public void addLanguages(IWebDriver driver)
        {
            try
            {
                //click add new button
                lang_addNewButton.Click();
                Thread.Sleep(1500);
                //enter language
                lang_txtbx.SendKeys("English");
                Thread.Sleep(1500);
                //enter language level
                langLevel_drpdwn.Click();
                langLevel_select.Click();
                Thread.Sleep(1500);
                //click add button
                lang_addButton.Click();
                Thread.Sleep(1500);
            }
            catch (Exception msg)
            {
                Assert.Fail("Test failed at addLanguages tab", msg.Message);
            }
            
                        
        }

        
        public void addSkills(IWebDriver driver)
        {
            try
            {
                //click skills tab
                skills_tab.Click();
                Thread.Sleep(1500);
                //click add new button
                skills_addNewButton.Click();
                Thread.Sleep(1500);
                //enter skill
                skills_txtbx.SendKeys("Selenium");
                Thread.Sleep(1500);
                //choose skill from dropdown
                skillLevel_drpdwn.Click();
                skillLevel_select.Click();
                Thread.Sleep(1500);
                //click add button
                skill_addButton.Click();
                Thread.Sleep(1500);

            }
            catch (Exception msg)
            {
                Assert.Fail("Test failed at addSkills tab", msg.Message);
            }
            
            
        }

        public void addEducation(IWebDriver driver)
        {
            try
            {
                //click education tab
                education_tab.Click();
                Thread.Sleep(1500);
                //click add new button
                edu_addNewButton.Click();
                Thread.Sleep(1500);
                //enter uni name
                //switch to iframe to avoid exception
                driver.SwitchTo().Frame(driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > div.ten.wide.field > input[type=text]")));
                edu_collegeTxtbx.SendKeys("IIT");
                Thread.Sleep(1500);
                //select country of college/uni  from dropdown
                edu_countryDrpdwn.Click();
                Thread.Sleep(1500);
                edu_countrySelect.Click();
                Thread.Sleep(1500);
                //select title from dropdown
                edu_titleDrpdwn.Click();
                Thread.Sleep(1500);
                edu_titleSelect.Click();
                Thread.Sleep(1500);
                //enter degree
                edu_degreeTxtbx.SendKeys("science");
                Thread.Sleep(1500);
                //select year of graduation from dropdown
                edu_yearDrpdwn.Click();
                Thread.Sleep(1500);
                edu_yearSelect.Click();
                Thread.Sleep(1500);
                //click add button
                edu_addButton.Click();
                Thread.Sleep(1500);
            }
            catch (Exception msg)
            {
                Assert.Fail("Test failed at addEducation tab", msg.Message);
            }
            
        }

        public void addCertifications(IWebDriver driver)
        {
            try
            {
                //click certification tab
                certification_tab.Click();
                Thread.Sleep(1500);
                //click add new button
                cert_addNewButton.Click();
                Thread.Sleep(1500);
                //enter certificate name
                certName_Txtbx.SendKeys("Azure");
                Thread.Sleep(1500);
                //enter institute name
                certFrom_Txtbx.SendKeys("Microsoft");
                Thread.Sleep(1500);
                //select year from dropdown 
                cert_yearDrpdwn.Click();
                cert_yearSelect.Click();
                Thread.Sleep(1500);
                //click addbutton
                cert_addButton.Click();
                Thread.Sleep(1500);

            }
            catch (Exception msg)
            {
                Assert.Fail("Test failed at addCertifications tab", msg.Message);
            }

            
        }
              
       
       

        public void createProfile(IWebDriver driver)
        {

            try
            {
                //******Add Profile Details*******
                //click on dropdown (near displayed name) to edit username

                //driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i")).Click();
                driver.FindElement(By.XPath("//*[@ class ='ui fluid accordion']/div[1]/i")).Click();

                Thread.Sleep(2000);
                //enter first name
                //driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[1]")).SendKeys("Lily");
                IWebElement firstName = driver.FindElement(By.XPath("//*[@class = 'ui form transition visible']/div[1]/input"));
                firstName.Clear();
                firstName.SendKeys("Rose");

                Thread.Sleep(2000);
                //enter last name
                //driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[2]")).SendKeys("Jackson");
                IWebElement lastName = driver.FindElement(By.XPath("//*[@class = 'ui form transition visible']/div[1]/input[2]"));
                lastName.Clear();
                lastName.SendKeys("Thomson");
                //lastName.SendKeys(Keys.PageDown);
                Thread.Sleep(2000);

                //click save button
                var element = driver.FindElement(By.XPath("//*[@class = 'ui form transition visible']/div[1]/input[2]"));
                Actions actions = new Actions(driver);
                actions.MoveToElement(element).Perform();
                Thread.Sleep(2000);
                driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.content.active > div > div:nth-child(2) > button")).Click();
                Thread.Sleep(2000);
                //Enter Availablility
                driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span > i")).Click();
                Thread.Sleep(1500);
                driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span > select")).Click();
                Thread.Sleep(1500);
                driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span")).Click();
                Thread.Sleep(2000);
                //Enter Hours
                driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span > i")).Click();
                Thread.Sleep(1500);
                driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span > select")).Click();
                Thread.Sleep(1500);
                driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div")).Click();
                Thread.Sleep(2000);
                //Enter 'Earn Target'
                driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > i")).Click();
                Thread.Sleep(1500);
                driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > select")).Click();
                Thread.Sleep(1500);
                driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span")).Click();
                Thread.Sleep(2000);
            }
            catch (Exception msg)
            {
                Assert.Fail("Test failed at createProfile tab", msg.Message);
            }
            
        }
        


    }
}
