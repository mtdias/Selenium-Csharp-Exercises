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

            //driverFF.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            Thread.Sleep(5000);

            //WebDriverWait wait = new WebDriverWait(driverFF, TimeSpan.FromSeconds(10));
            //wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.LinkText("Selenium - Web Browser Automation")));
            
            driverFF.Navigate().GoToUrl("http://www.google.com");
        }

        [TestMethod]
        public void TestChromeDriver()
        {
            driverGC = new ChromeDriver({{path_to_chrome_driver}});
            driverGC.Navigate().GoToUrl("http://www.google.com");
            driverGC.FindElement(By.Id("lst-ib")).SendKeys("Selenium");
            driverGC.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
        }
    }
}
