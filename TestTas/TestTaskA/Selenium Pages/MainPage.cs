using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTaskA.Selenium_Pages
{
    class MainPage
    {
        [FindsBy(How = How.CssSelector, Using = "#search_form_input_homepage")]
        public IWebElement SearchFieldInput;

        [FindsBy(How = How.CssSelector, Using = "#search_button_homepage")]
        public IWebElement SearchButton;
    }
}
