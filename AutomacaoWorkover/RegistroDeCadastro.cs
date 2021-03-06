using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Assert = NUnit.Framework.Assert;

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
            System.Threading.Thread.Sleep(8000);
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
            Driver.FindElement(By.Id("name")).SendKeys("Fernando Medeiros");
            Driver.FindElement(By.Id("email")).SendKeys("teste@gmail.com");
            Driver.FindElement(By.Id("password")).SendKeys("12345678");
            Driver.FindElement(By.Id("phone")).SendKeys("11984546145");
            Driver.FindElement(By.ClassName("checkmark")).Click();
            Driver.FindElement(By.XPath("/html/body/section/div[2]/form/div[4]/button")).Click();

            Assert.AreEqual("Workover", Driver.Title);
        }
    }
}
