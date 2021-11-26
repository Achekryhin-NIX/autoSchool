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
namespace SELENIUM_New
{
    class Program
    {
        public static void Main()
        {
        }

        //  Task 1

        public static void Task1()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/");
            HomePage homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.SearchField.SendKeys("Summer");
            Thread.Sleep(500);
            homePage.ButtonSearch.Click();
        }

        //  Task 2

        public static void Task2()
            {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/");
            HomePage homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.SearchField.SendKeys("Summer");
            Thread.Sleep(500);
            homePage.ButtonSearch.Click();

            ResultPage resultPage = new ResultPage();
            PageFactory.InitElements(driver, resultPage);
            resultPage.SortByButton.Click();
            Thread.Sleep(500);
            resultPage.HighestFirst.Click();
        }

        //  Task 3


        public static void Task3()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/");
            HomePage homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.SearchField.SendKeys("Summer");
            Thread.Sleep(500);
            homePage.ButtonSearch.Click();
            
            ResultPage resultPage = new ResultPage();
            PageFactory.InitElements(driver, resultPage);
            resultPage.SortByButton.Click();
            Thread.Sleep(500);
            resultPage.HighestFirst.Click();
            
            resultPage.AddDressButton.Click();
            Thread.Sleep(2000);

            resultPage.ContinueShoppingButton.Click();

            resultPage.Cart.Click();
        }


        //  Task 4


        public static void Task4()
        {
            
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/");
            HomePage homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.SearchField.SendKeys("Blouse");
            Thread.Sleep(500);
            homePage.ButtonSearch.Click();
            Thread.Sleep(1000);
            

            ResultPage resultPage = new ResultPage();
            PageFactory.InitElements(driver, resultPage);
            resultPage.More.Click();
            Thread.Sleep(500);
            resultPage.QuantityField.SendKeys(Keys.Backspace);
            Thread.Sleep(500);

            resultPage.QuantityField.SendKeys("3");

            resultPage.SizeMenu.Click();
            Thread.Sleep(500);

            resultPage.SizeL.Click();
            Thread.Sleep(500);

            resultPage.WhiteColorBlouse.Click();
            Thread.Sleep(500);



            resultPage.AddGood.Click();

            Thread.Sleep(1000);
        }
        //    string s1 = driver.FindElement(By.CssSelector(".layer_cart_product > h2:nth-child(2)")).Text;
        //    Console.WriteLine(s1);


        //  Task 5

        public static void Task5()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/");
            HomePage homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.SearchField.SendKeys("Blouse");
            Thread.Sleep(500);
            homePage.ButtonSearch.Click();
            Thread.Sleep(1000);


            ResultPage resultPage = new ResultPage();
            PageFactory.InitElements(driver, resultPage);
            resultPage.More.Click();
            Thread.Sleep(500);
            resultPage.QuantityField.SendKeys(Keys.Backspace);
            Thread.Sleep(500);

            resultPage.QuantityField.SendKeys("3");

            resultPage.SizeMenu.Click();
            Thread.Sleep(500);

            resultPage.SizeL.Click();
            Thread.Sleep(500);

            resultPage.WhiteColorBlouse.Click();
            Thread.Sleep(500);

            resultPage.AddGood.Click();
            Thread.Sleep(2000);



            resultPage.ContinueShoppingButton.Click();
            Thread.Sleep(500);

            resultPage.SearchFieldResoultPage.Clear();

            Thread.Sleep(500);

            resultPage.SearchFieldResoultPage.SendKeys("Printed summer dress");
            Thread.Sleep(500);
            resultPage.ButtonSearch.Click();

            Thread.Sleep(500);
            resultPage.MoreButtonSecondBuy.Click();
            Thread.Sleep(500);

            resultPage.QuantityField.Clear();
            Thread.Sleep(500);

            resultPage.QuantityField.SendKeys("5");
            Thread.Sleep(500);

            resultPage.SizeMenu.Click();
            Thread.Sleep(500);

            resultPage.OrangeColor.Click();
            Thread.Sleep(500);

            resultPage.AddGood.Click();
            Thread.Sleep(1000);

            resultPage.ProceedButoon.Click();
        }


        //  Task 6

        public static void Task6()
        {

            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/");
            HomePage homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.SearchField.SendKeys("Blouse");
            Thread.Sleep(500);
            homePage.ButtonSearch.Click();
            Thread.Sleep(1000);


            ResultPage resultPage = new ResultPage();
            PageFactory.InitElements(driver, resultPage);
            resultPage.More.Click();
            Thread.Sleep(500);
            resultPage.QuantityField.SendKeys(Keys.Backspace);
            Thread.Sleep(500);

            resultPage.QuantityField.SendKeys("3");

            resultPage.SizeMenu.Click();
            Thread.Sleep(500);

            resultPage.SizeL.Click();
            Thread.Sleep(500);

            resultPage.WhiteColorBlouse.Click();
            Thread.Sleep(500);

            resultPage.AddGood.Click();
            Thread.Sleep(2000);

            // Tas 5

            resultPage.ContinueShoppingButton.Click();
            Thread.Sleep(500);

            resultPage.SearchFieldResoultPage.Clear();

            Thread.Sleep(500);

            resultPage.SearchFieldResoultPage.SendKeys("Printed summer dress");
            Thread.Sleep(500);
            resultPage.ButtonSearch.Click();

            Thread.Sleep(500);
            resultPage.MoreButtonSecondBuy.Click();
            Thread.Sleep(500);

            resultPage.QuantityField.Clear();
            Thread.Sleep(500);

            resultPage.QuantityField.SendKeys("5");
            Thread.Sleep(500);

            resultPage.SizeMenu.Click();
            Thread.Sleep(500);

            resultPage.OrangeColor.Click();
            Thread.Sleep(500);

            resultPage.AddGood.Click();
            Thread.Sleep(2000);

            resultPage.ProceedButoon.Click();
            Thread.Sleep(500);


            resultPage.DeleteGood.Click();


        }
    }
}




































    










































































