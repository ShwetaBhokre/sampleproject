using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject6
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;

        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.sportsadda.com/");

            driver.Manage().Window.Maximize();

            driver.Quit();




        }

    }
}
