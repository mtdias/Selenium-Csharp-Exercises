using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        static IWebDriver driverFF = null;

        [TestMethod]
        public void desafio2()
        {
            String nome = "SENAC";
            String email = "teste@teste.com.br";
            String telefone = "51 9999 9999";

            driverFF = new FirefoxDriver();
            driverFF.Navigate().GoToUrl("http://eliasnogueira.com/arquivos_blog/selenium/desafio/2desafio/");

            IWebElement nomeDisplay = driverFF.FindElement(By.Id("name_rg_display_section"));
            nomeDisplay.Click();
            IWebElement elementoPessoa = driverFF.FindElement(By.Id("nome_pessoa"));
            elementoPessoa.Clear();
            elementoPessoa.SendKeys(nome);
            
            driverFF.FindElement(By.CssSelector("#name_hv_editing_section > input[value='Salvar']")).Click();

            WebDriverWait wait = new WebDriverWait(driverFF, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.Id("name_rg_display_section")));
            
            IWebElement emailDisplay = driverFF.FindElement(By.Id("email_rg_display_section"));
            emailDisplay.Click();
            IWebElement elementoEmail = driverFF.FindElement(By.Id("email_value"));
            elementoEmail.Clear();
            elementoEmail.SendKeys(email);
            driverFF.FindElement(By.CssSelector("#email_hv_editing_section > input[value='Salvar']")).Click();

            wait = new WebDriverWait(driverFF, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.TextToBePresentInElementValue(By.Id("email_rg_display_section"), email));
            
            IWebElement telefoneDisplay = driverFF.FindElement(By.Id("phone_rg_display_section"));
            telefoneDisplay.Click();
            IWebElement elementoTelefone = driverFF.FindElement(By.Id("phone_value"));
            elementoTelefone.Clear();
            elementoTelefone.SendKeys(telefone);
            
            driverFF.FindElement(By.CssSelector("#phone_hv_editing_section > input[value='Salvar']")).Click();

            wait = new WebDriverWait(driverFF, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.TextToBePresentInElementValue(By.Id("phone_hv_editing_section"), telefone));
            
            Assert.AreEqual(nome, driverFF.FindElement(By.Id("name_rg_display_section")).Text);
            Assert.AreEqual("Email: " + email, driverFF.FindElement(By.Id("email_rg_display_section")).Text);
            Assert.AreEqual("Telefone: " + telefone, driverFF.FindElement(By.Id("phone_rg_display_section")).Text);
            
        }
    }
}
