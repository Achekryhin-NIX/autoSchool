using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SELENIUM_New
{
    class Program
    {

        // 1. Find Title
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com");
            string title = driver.Title;
            Console.WriteLine(title);
            Console.Read();
        }

        // 2. Get List 
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            try
            {
               
                driver.Navigate().GoToUrl("http://automationpractice.com/");

               
                IList<IWebElement> elements = driver.FindElements(By.CssSelector("#block_top_menu > ul"));
                foreach (IWebElement e in elements)
                {
                    System.Console.WriteLine(e.Text);
                }

            }
            finally
            { }


            // 3. Get Value Attribute "name"

            static void Main(string[] args)
            {
                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl("http://automationpractice.com/");
                String cssValue = driver.FindElement(By.CssSelector("#search_query_top")).GetAttribute("name");
                Console.WriteLine(cssValue);
                Console.Read();
            }
            // 4. Click button  "Best seller"

            static void Main(string[] args)
            {
                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl(@"http://automationpractice.com");
                IWebElement element = driver.FindElement(By.CssSelector("#home-page-tabs > li:nth-child(2) > a"));
                element.Click();
            }

            // 5. Input some value in the field "Search", and press button "Enter"
            static void Main(string[] args)
            {
                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl(@"http://automationpractice.com");
                IWebElement element = driver.FindElement(By.CssSelector("#search_query_top"));
                element.SendKeys("summer" + Keys.Enter);
            }















        }
    }
}
    

    





            



        

        
    



    


    

