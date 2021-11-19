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

namespace SELENIUM_New.PageObjects
{
    class LoginPage
    {
        [FindsBy(How = How.CssSelector, Using = "#email")]
        public IWebElement emailElement;

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement passwordElement;

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        public IWebElement loginElement;

        // task 2.1
        [FindsBy(How = How.CssSelector, Using = "#create-account_form > div > p")]
        public IWebElement CreateAccountForm;
        // task 2.2
        [FindsBy(How = How.CssSelector, Using = "#login_form > h3")]
        public IWebElement LoginForm;
        // // task 2.3
        [FindsBy(How = How.CssSelector, Using = "#SubmitCreate > span:nth-child(1)")]
        public IWebElement SubmitCreate;




    }
}
