using EtsyAutomationTests.Pages;
using My_Framework.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

namespace EtsyAutomationTests.Tests
{
    public class FindMensShoesTest
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.etsy.com/");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void TestFindMensShoes()
        {
            Actions actions = new Actions(driver);
            EtsyMainPage etsyMainPage = new EtsyMainPage(driver);
            CustomWaits customWaits = new CustomWaits();
            actions.MoveToElement(etsyMainPage.searchArea.searchMenuShoes).Perform();              
            customWaits.SetImplicitWaitTimeout(driver, 10);

            actions.MoveToElement(etsyMainPage.searchArea.menuButtonMens).Perform();
            customWaits.SetImplicitWaitTimeout(driver, 10);
            actions.MoveToElement(etsyMainPage.searchArea.menuShoesButton).Click().Perform();
            customWaits.SetImplicitWaitTimeout(driver, 40);
            var newPage = driver.Url;

            Assert.AreEqual("https://www.etsy.com/c/shoes/mens-shoes?ref=catnav-10923", newPage);
        }

    }
}
