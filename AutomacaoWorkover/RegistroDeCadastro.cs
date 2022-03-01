using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutomacaoWorkover
{

    [TestClass]
    public class RegistroDeCadastro
    {
        public IWebDriver Driver { get; set; }

        [SetUp]
        public void SetUpTest()
        {
            ChromeOptions optionsChrome = new ChromeOptions();
            optionsChrome.AddArgument("--start-maximized");
            Driver = new ChromeDriver(optionsChrome);
            Driver.Navigate().GoToUrl("https://alunos.workover.com.br/login");
            System.Threading.Thread.Sleep(5000);
        }

        [TearDown]
        public void TearDownTest()
        {
            Driver.Quit();
        }

        [Test]
        public void RealizandoCadastroNoSite()
        {
            Driver.FindElement(By.ClassName("btn-secondary")).Click();
        }
    }
}
