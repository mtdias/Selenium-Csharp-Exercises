using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest5
    {
        static IWebDriver driverFF;
        
        [TestMethod]
        public void desafio5()
        {
            driverFF = new FirefoxDriver();

            driverFF.Navigate().GoToUrl("http://eliasnogueira.com/arquivos_blog/selenium/desafio/5desafio/");
            
            driverFF.FindElement(By.XPath("//label[text() = 'Username']/following-sibling::div/input")).SendKeys("eliasn");
            driverFF.FindElement(By.XPath("//label[text() = 'Username (repetir)']/following-sibling::div/input")).SendKeys("elias");
            driverFF.FindElement(By.XPath("//label[text() = 'Password']/following-sibling::div/input")).SendKeys("12345");
            driverFF.FindElement(By.XPath("//label[text() = 'Password (repetir)']/following-sibling::div/input")).SendKeys("12345");

            driverFF.FindElement(By.Id("submitBtn2")).Click();

            Assert.AreEqual("Os campos não tem o mesmo valor!", driverFF.FindElement(By.Id("errorDiv2")).Text);
        }
    }
}
