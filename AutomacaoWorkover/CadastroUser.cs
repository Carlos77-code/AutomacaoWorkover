using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace AutomacaoWorkover
{
    internal class CadastroUser : Begin
    {
        [Test]
        public void Teste()
        {
            driver.FindElement(By.ClassName("btn-login")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\'loginModalElement\']/div/div/form/div[3]/div[2]/p/a/strong")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("name")).SendKeys("QAorDev");
            driver.FindElement(By.Id("email")).SendKeys("qa@teste.com");
            driver.FindElement(By.XPath("//*[@id=\'loginModalElement\']/div/div/form/div[3]/div[1]/button")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("password")).SendKeys("qa1234");
            driver.FindElement(By.XPath("//*[@id=\'loginModalElement\']/div/div/form/div[3]/div[1]/button")).Click();
        }
    }
}
