using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;
using TestTaskA.Selenium_Pages;

namespace TestTaskA
{    /*Task 1*/
    //1. Open WebPage "https://duckduckgo.com/".
    //2. Type any word in the search field.
    //3. Click "Search" button.
    //4. Check that a certain amount of search results are displayed on the page, remember the quantity of search results.
    //5. Scroll down and click "More Resulst" button.
    //6. Check that more test results are displayed.
    class Program
    {
    static void Main()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://duckduckgo.com/");
            
            MainPage mainPage = new MainPage();
            PageFactory.InitElements(driver, mainPage);
            mainPage.SearchFieldInput.SendKeys("Summer");
            
            mainPage.SearchButton.Click();
            Thread.Sleep(500);

            var resultPage = new ResultPage();
            resultPage.MoreResultButton.Click();
        }
    }
}

//Task 2

//    По автоматизации API задание пока затрудняюсь выполнить, так как в автоматизации тесты писал
//    только по UI. (На данный момент API тестировал только мануально).

//    ПС. В моём профиле ГИТа, при желании, можете посмотреть другие мои работы (тесты с использованием 
//    Spec Flow, Page Objects, применения Linq, OOP и т.д.).
    
//    Благодарю за внимание.
