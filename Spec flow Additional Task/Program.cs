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
        
        //Scenario 1

        // 1. Go to http://automationpractice.com/

        // 2. Enter "T Shirt"  in search field and click button Search

        // 3. Select blue color of the product

        // 4. Click on the button "Send to a friend"

        // 5. Input name "Ann", and email "qqq@gmail.com" on popup window, and click button send

        // 6.  Verify, pop up window  with notice    "Your e-mail has been sent successfully" are display.


        public static void Main()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/");
            HomePage homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.SearchField.SendKeys("T Shirt");
            Thread.Sleep(500);
            homePage.ButtonSearch.Click();

            ResultPage resultPage = new ResultPage();
            PageFactory.InitElements(driver, resultPage);
            resultPage.BlueColor.Click();
            Thread.Sleep(2000);

            resultPage.SendFriendButton.Click();
            Thread.Sleep(1000);

            resultPage.FriendNameField.SendKeys("Ann@gmail.com");

            resultPage.FriendEmailField.SendKeys("Ann");

            resultPage.SendEmailFriend.Click();
        }

        /// Scenario 2 

        /// 1. Go to  http://automationpractice.com/
        /// 2. Enter "evening" in search field and click button Search.
        /// 3. click button More on the first dress.
        /// 4. Add dress to the wishlist (clic button "wishlist") 
        /// 5. Verify, pop-up window with text "You must be logged in to manage your wishlist." are display.
        /// 6. Send pop-up window  notice  "You must be logged in to manage your wishlist." in console.


        public static void MyScenario2()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/");
            HomePage homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.SearchField.SendKeys("evening");
            Thread.Sleep(500);
            homePage.ButtonSearch.Click();
            Thread.Sleep(1000);

            ResultPage resultPage = new ResultPage();
            PageFactory.InitElements(driver, resultPage);
            resultPage.More.Click();

            resultPage.WishListButton.Click();
            Thread.Sleep(1000);
            string s3 = driver.FindElement(By.CssSelector(".fancybox-error")).Text;

            Console.WriteLine(s3);
        }


            // Scenario 3.

            //1/ Go to http://automationpractice.com/
            //2. Input email "TTT@gmail.com" in the field News letter and click the button.
            //3. Result text display on console.

            public static void MyScenario3n()
            {
                

                var driver = new ChromeDriver();
                driver.Navigate().GoToUrl("http://automationpractice.com/");
                HomePage homePage = new HomePage();
                PageFactory.InitElements(driver, homePage);
                homePage.NewsLetterField.SendKeys("wwew@gmail.com");
                Thread.Sleep(500);
                homePage.NewsLetterButton.Click();
                Thread.Sleep(3000);
                string s5 = driver.FindElement(By.CssSelector(".alert")).Text;
                Console.WriteLine(s5);


            }
        }
    }














































































































