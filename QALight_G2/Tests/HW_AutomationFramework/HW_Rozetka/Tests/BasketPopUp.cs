using HW_AutomationFramework.Utils;
using HW_Rozetka.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

namespace HW_Rozetka.Tests
{
    public class BasketPopUp
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
        public void ConsoleWriteTextFromBasketPopUp()
        {
            Actions actions = new Actions(driver);
            HomePage homePage = new HomePage(driver);

            actions.MoveToElement(homePage.searchArea.basket).Build()
               .Perform();

            
            
            TimeSpan.FromSeconds(2000);
        }
    }
}
