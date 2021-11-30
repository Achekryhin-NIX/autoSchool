using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using SELENIUM_New.PageObjects;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SELENIUM_New
{
    [Binding]
    class Steps
    {
        private IWebDriver driver = new ChromeDriver();

        [Given(@"Internet Store;")]
        public void GivenInternetStore()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/");
            Thread.Sleep(3000);
        }

        [When(@"Enter ""(.*)""  in search field and click button Search ;")]
        public void WhenEnterInSearchFieldAndClickButtonSearch(string s1)
        {
            HomePage homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.SearchField.SendKeys(s1);
            Thread.Sleep(500);
            homePage.ButtonSearch.Click();
        }

        [When(@"Select blue color of the product, and click on the button Send to a friend")]
        public void WhenSelectBlueColorOfTheProductAndClickOnTheButtonSendToAFriend()
        {
            ResultPage resultPage = new ResultPage();
            PageFactory.InitElements(driver, resultPage);
            resultPage.BlueColor.Click();
            Thread.Sleep(2000);
            resultPage.SendFriendButton.Click();
            Thread.Sleep(1000);
        }

        [When(@"Input name ""(.*)"", and email ""(.*)"" on popup window, and click button send;")]
        public void WhenInputNameAndEmailOnPopupWindowAndClickButtonSend(string s2, string s3)
        {
            ResultPage resultPage = new ResultPage();
            PageFactory.InitElements(driver, resultPage);

            resultPage.FriendNameField.SendKeys(s2);

            resultPage.FriendEmailField.SendKeys(s3);

            resultPage.SendEmailFriend.Click();
        }

        [Then(@"Verify, pop up window  with notice    ""(.*)"" are display")]
        public void ThenVerifyPopUpWindowWithNoticeAreDisplay(string s4)
        {
            string s5 = driver.FindElement(By.CssSelector(".fancybox-inner > p:nth-child(2)")).Text;
            Console.WriteLine(s5);
            Assert.AreEqual(s4, s5);
        }
    }
}
