using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium; 
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI; 



namespace SimpleTestLinecart
{
    [TestClass]
    public class SimpleTestLitecartClass
    {
        private IWebDriver driver;
        private WebDriverWait wait;


        [TestInitialize]
        public void Init()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }


        [TestMethod]
        public void LoginTest()
        {
            driver.Url = "http://litecart/admin/";

            driver.FindElement(By.Name("username")).SendKeys("admin");
            driver.FindElement(By.Name("password")).SendKeys("admin");

            //driver.FindElement(By.Name("remember_me")).Click();
            driver.FindElement(By.Name("login")).Click();

            wait.Until(ExpectedConditions.TitleIs("My Store"));
        }


        [TestCleanup]
        public void Finish()
        {
            driver.Quit();
            //driver = null;
        }
    }
}
