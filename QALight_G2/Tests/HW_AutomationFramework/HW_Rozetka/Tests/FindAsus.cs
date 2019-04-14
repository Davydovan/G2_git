using HW_AutomationFramework.Utils;
using HW_Rozetka.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

namespace HW_Rozetka.Tests
{

    public class FindAsus
    {
        IWebDriver driver;
        

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            CustomWaits customWaits = new CustomWaits();
            customWaits.SetImplicitWaitTimeout(driver, 10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://rozetka.com.ua");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void TestActionAsus()
        {
            Actions actions = new Actions(driver);
            HomePage homePage = new HomePage(driver);
            CustomWaits customWaits = new CustomWaits();
            actions.MoveToElement(homePage.searchArea.menuLaptop).Perform();            
            customWaits.SetImplicitWaitTimeout(driver, 40);

            actions.MoveToElement(homePage.searchArea.asus).Click().Perform();
            customWaits.SetImplicitWaitTimeout(driver, 40);                       
            var newPage = driver.Url;
            Assert.AreEqual("https://rozetka.com.ua/notebooks/c80004/filter/producer=asus/", newPage);
            TimeSpan.FromSeconds(2000);
        }
    }
}
