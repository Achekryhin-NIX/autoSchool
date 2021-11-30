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
    class HomePage
    {
        // Task 1  Input "Summer" and click button "Search"
        
        // Search field 1.1
        [FindsBy(How = How.CssSelector, Using = "#search_query_top")]
        public IWebElement SearchField;
        // Button "search" 1.2
        [FindsBy(How = How.CssSelector, Using = "button.btn:nth-child(5)")]
        public IWebElement ButtonSearch;

        // My Scenario

        [FindsBy(How = How.CssSelector, Using = "#newsletter-input")]
        public IWebElement NewsLetterField;

        [FindsBy(How = How.CssSelector, Using = "button.btn:nth-child(2)")]
        public IWebElement NewsLetterButton;

        //  css[FindsBy(How = How.CssSelector, Using = ".alert")]
       // public IWebElement NewsLetterNoticeSubscribed;Selector   .alert     Notice  Newsletter : You have successfully subscribed to this newsletter.
        // Task 2 

        

















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
