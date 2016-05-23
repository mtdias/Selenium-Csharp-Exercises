using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver driverFF;
        static IWebDriver driverGC;

        [TestMethod]
        public void TestFirefoxDriver()
        {
            driverFF = new FirefoxDriver();
            driverFF.Navigate().GoToUrl("http://www.google.com");
            driverFF.FindElement(By.Id("lst-ib")).SendKeys("Selenium");
            driverFF.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);

            Thread.Sleep(5000);

            driverFF.Navigate().GoToUrl("http://www.google.com");
        }

        [TestMethod]
        public void TestChromeDriver()
        {
            /* TODO: Include here your ChromeDriver directory */
            driverGC = new ChromeDriver(@"C:\Users\mtdias\");
            driverGC.Navigate().GoToUrl("http://www.google.com");
            driverGC.FindElement(By.Id("lst-ib")).SendKeys("Selenium");
            driverGC.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
        }
    }
}
