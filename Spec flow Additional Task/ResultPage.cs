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
    class ResultPage
    {
        [FindsBy(How = How.CssSelector, Using = "#selectProductSort")]
        public IWebElement SortByButton;
        [FindsBy(How = How.CssSelector, Using = "#selectProductSort > option:nth-child(3)")]
        public IWebElement HighestFirst;
        [FindsBy(How = How.CssSelector, Using = "li.ajax_block_product:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(4) > a:nth-child(1) > span:nth-child(1)")]
        public IWebElement AddDressButton;
        [FindsBy(How = How.CssSelector, Using = ".shopping_cart > a:nth-child(1)")]
        public IWebElement Cart;
        /// <summary>
        /// /
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = ".continue > span:nth-child(1)")]
        public IWebElement ContinueShoppingButton;

        [FindsBy(How = How.CssSelector, Using = ".cross")]
        public IWebElement CloseWindow;

        [FindsBy(How = How.CssSelector, Using = ".lnk_view > span:nth-child(1)")]
        public IWebElement More;
       
        //  4

        [FindsBy(How = How.CssSelector, Using = "#quantity_wanted")]
        public IWebElement QuantityField;


        [FindsBy(How = How.CssSelector, Using = "#group_1")]
        public IWebElement SizeMenu;

        [FindsBy(How = How.CssSelector, Using = "#group_1 > option:nth-child(3)")]
        public IWebElement SizeL;

        [FindsBy(How = How.CssSelector, Using = "#color_8")]
        public IWebElement WhiteColorBlouse;

        [FindsBy(How = How.CssSelector, Using = "button.exclusive > span:nth-child(1)")]
        public IWebElement AddGood;

        [FindsBy(How = How.CssSelector, Using = "#search_query_top")]
        public IWebElement SearchFieldResoultPage;

        [FindsBy(How = How.CssSelector, Using = "button.btn:nth-child(5)")]
        public IWebElement ButtonSearch;

        [FindsBy(How = How.CssSelector, Using = "li.ajax_block_product:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(4) > a:nth-child(2) > span:nth-child(1)")]
        public IWebElement MoreButtonSecondBuy;

        [FindsBy(How = How.CssSelector, Using = "#group_1 > option:nth-child(2)")]
        public IWebElement SizeM;

        [FindsBy(How = How.CssSelector, Using = "#color_13")]
        public IWebElement OrangeColor;

        [FindsBy(How = How.CssSelector, Using = "a.btn:nth-child(2) > span:nth-child(1)")]
        public IWebElement ProceedButoon;

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div[2]/table/tbody/tr[2]/td[7]/div/a/i")]
        public IWebElement DeleteGood;

        [FindsBy(How = How.CssSelector, Using = ".layer_cart_product > h2:nth-child(2)")]
        public IWebElement TextProductSuccessfullyAdded;

        // my scenario


        [FindsBy(How = How.CssSelector, Using = "#color_2")]
        public IWebElement BlueColor;

        [FindsBy(How = How.CssSelector, Using = "#send_friend_button")]
        public IWebElement SendFriendButton;

        [FindsBy(How = How.CssSelector, Using = "#friend_name")]
        public IWebElement FriendNameField;

        [FindsBy(How = How.CssSelector, Using = "#friend_email")]
        public IWebElement FriendEmailField;
        // .fancybox-inner > p:nth-child(2)    Your e-mail has been sent successfully

        [FindsBy(How = How.CssSelector, Using = "#sendEmail")]
        public IWebElement SendEmailFriend;

        [FindsBy(How = How.CssSelector, Using = "#wishlist_button")]
        public IWebElement WishListButton;

        // .fancybox-error       You must be logged in to manage your wishlist.
    }
}

        
