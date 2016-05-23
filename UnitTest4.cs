using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest4
    {
        static IWebDriver driverFF;

        [TestMethod]
        public void Desafio4()
        {
            driverFF = new FirefoxDriver();
            driverFF.Navigate().GoToUrl("http://eliasnogueira.com/arquivos_blog/selenium/desafio/4desafio/");

            IWebElement cep = driverFF.FindElement(By.Id("cep"));
            cep.SendKeys("01310200");
            
            driverFF.FindElement(By.Id("numero")).SendKeys("1578");
            driverFF.FindElement(By.Id("complemento")).SendKeys("MASP");
            
            WebDriverWait wait = new WebDriverWait(driverFF, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.TextToBePresentInElementValue(By.Id("rua"), "Avenida: Paulista"));
            //wait.Until(ExpectedConditions.TextToBePresentInElementValue(By.Id("bairro"), ""));
            
            Assert.AreEqual("Avenida: Paulista", driverFF.FindElement(By.Id("rua")).GetAttribute("value"));
            Assert.AreEqual("Bela Vista", driverFF.FindElement(By.Id("bairro")).GetAttribute("value"));
            Assert.AreEqual("São Paulo", driverFF.FindElement(By.Id("cidade")).GetAttribute("value"));
            Assert.AreEqual("SP", driverFF.FindElement(By.Id("estado")).GetAttribute("value"));
        }
    }
}
