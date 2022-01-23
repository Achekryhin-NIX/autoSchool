using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTaskA.Selenium_Pages
{
    class ResultPage
    {
        [FindsBy(How = How.CssSelector, Using = "#rld-1 > a")]
        public IWebElement MoreResultButton;
    }
}
