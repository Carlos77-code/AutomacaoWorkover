using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace AutomacaoWorkover
{
    internal class CadastroUser : Begin
    {
        [Test]
        public void Teste()
        {
            driver.FindElement(By.ClassName("btn-login")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.FindElement(By.Id("identifier")).SendKeys("qaordev@hotmail.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.FindElement(By.XPath("//*[@id=\'recaptcha-anchor-label\']")).Click();
            driver.FindElement(By.XPath("//*[@id=\'loginModalElement\']/div/div/form/div[3]/div[1]/button")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
    }
}
