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

    public class Steps
    {
        private IWebDriver driver = new ChromeDriver();



        [Given(@"Internet Store")]
        public void GivenInternetStore()
        {

            driver.Navigate().GoToUrl("http://automationpractice.com/");
            Thread.Sleep(3000);

        }

        [When(@"Enter ""(.*)"" in search field and click button search, and click button More")]
        public void WhenEnterInSearchFieldAndClickButtonSearchAndClickButtonMore(string s1)
        {


            HomePage homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.SearchField.SendKeys(s1);
            Thread.Sleep(500);
            homePage.ButtonSearch.Click();
            Thread.Sleep(1000);
            ResultPage resultPage = new ResultPage();
            PageFactory.InitElements(driver, resultPage);
            resultPage.More.Click();
            Thread.Sleep(1000);
        }

        [When(@"On details of the product Input : Quantity = ""(.*)"" , Size = L, Color = white, and click button Add to cart")]
        public void WhenOnDetailsOfTheProductInputQuantitySizeLColorWhiteAndClickButtonAddToCart(int a)
        {
            ResultPage resultPage = new ResultPage();
            PageFactory.InitElements(driver, resultPage);
            resultPage.QuantityField.SendKeys(Keys.Backspace);
            Thread.Sleep(500);

            resultPage.QuantityField.SendKeys(a.ToString());

            resultPage.SizeMenu.Click();
            Thread.Sleep(500);

            resultPage.SizeL.Click();
            Thread.Sleep(500);

            resultPage.WhiteColorBlouse.Click();
            Thread.Sleep(500);



            resultPage.AddGood.Click();
            Thread.Sleep(1000);
        }

        [Then(@"text ""(.*)"" are displayed in console")]
        public void ThenTextAreDisplayedInConsole(string s2)
        {
            Thread.Sleep(8000);
            string s3 = driver.FindElement(By.CssSelector(".layer_cart_product > h2:nth-child(2)")).Text;
            Console.WriteLine(s3);

            Assert.AreEqual(s2, s3);

        }
            // 2     

            [Given(@"Int Store")]
            public void GivenIntStore()
            {
            driver.Navigate().GoToUrl("http://automationpractice.com/");
            Thread.Sleep(3000);
        }

            [When(@"Enter ""(.*)"" in search field and click button search")]
            public void WhenEnterInSearchFieldAndClickButtonSearch(string s4)
            {
            HomePage homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.SearchField.SendKeys(s4);
            Thread.Sleep(500);
            homePage.ButtonSearch.Click();
            Thread.Sleep(8000);
        }

            [Then(@"text ""(.*)"" are visible on top of the list of products;")]
            public void ThenTextAreVisibleOnTopOfTheListOfProducts(string s5)
            {
                ScenarioContext.Current.Pending();
            
            string s6 = driver.FindElement(By.CssSelector(".lighter  summer")).Text;
            Console.WriteLine(s6);

            Assert.AreEqual(s5, s6);
        }




        }
    }
