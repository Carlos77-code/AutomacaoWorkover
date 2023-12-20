using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomacaoWorkover
{
    public class PlatEducaTi
    {
        public IWebDriver Driver;

        [SetUp]
        public void InicioTeste()
        {
            
        }

        [Test]
        public void Teste()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://workover.com.br/");
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void FimDoTeste()
        {
            
        }
    }
}
