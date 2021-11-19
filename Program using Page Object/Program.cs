using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using SELENIUM_New.PageObjects;

namespace SELENIUM_New
{
    class Program
    {
        // 2.1
        static void Main()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            LoginPage loginPage = new LoginPage();
            PageFactory.InitElements(driver, loginPage);
            String text = loginPage.CreateAccountForm.Text;
            Console.WriteLine(text);
            Console.Read();
        }

        // 2.2
        static void main()

        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            LoginPage loginPage = new LoginPage();
            PageFactory.InitElements(driver, loginPage);
            String text = loginPage.LoginForm.Text;
            Console.WriteLine(text);
            Console.Read();
        }
        // Task 2.3

        static void Maiin()

        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            LoginPage loginPage = new LoginPage();
            PageFactory.InitElements(driver, loginPage);
            String text = loginPage.SubmitCreate.Text;
            Console.WriteLine(text);
            Console.Read();
        }

        // TASK 3

        class MainTest
        {
            static void Main()
            {
                var driver = new ChromeDriver();
                driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");

                LoginPage loginPage = new LoginPage();
                PageFactory.InitElements(driver, loginPage);

                loginPage.emailElement.SendKeys("Peter@UA");
                Thread.Sleep(500);

                loginPage.passwordElement.SendKeys("12345");
                Thread.Sleep(500);

                loginPage.loginElement.Click();

            }







        }




    }
}









        
    


