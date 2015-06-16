using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace myFirstProject
{
    class Selenium 
    {
        static void Main(string[] arg)
        {
            System.Console.WriteLine("sddfsd");
                IWebDriver driver = new FirefoxDriver();
                driver.Navigate().GoToUrl("http:\\www.google.com");
                driver.Manage().Window.Maximize();
                IWebElement element = driver.FindElement(By.Id("lst-ib"));
                element.SendKeys("Hello world string");
                element.SendKeys(Keys.Enter);
                driver.Quit();

        }

    }
}
