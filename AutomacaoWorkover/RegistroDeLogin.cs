using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Assert = NUnit.Framework.Assert;

namespace AutomacaoWorkover
{

    [TestClass]
    public class RegistroDeLogin
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
        public void RealizandoLoginNoSite()
        {
            Driver.FindElement(By.Id("email")).SendKeys("carloslimafernandes@hotmail.com");
            Driver.FindElement(By.Id("password")).SendKeys("elohin77");
            Driver.FindElement(By.XPath("/html/body/section/div[2]/form/div[3]/button")).Click();
            Driver.FindElement(By.XPath("/html/body/section[1]/div/div/i")).Click();
            Driver.FindElement(By.Id("academy_avatar_menu_logout")).Click();


            Assert.AreEqual("Login | Workover", Driver.Title);
        }
    }
}
