using EtsyAutomationTests.Pages;
using My_Framework.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

namespace EtsyAutomationTests.Tests
{
    class ChangeCarrencyTest
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.etsy.com/c/shoes/mens-shoes/boots?explicit=1");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void CheckCangeCarrency()
        {
            var searchText = "Price (PLN)";
            EtsyMensShoesPage etsyMensShoesPage = new EtsyMensShoesPage(driver);
            CustomWaits customWaits = new CustomWaits();
            etsyMensShoesPage.searchArea.popupChangeRegionLanguageCarrency.Click();
            PopupUpdateSettings popupUpdateSettings = new PopupUpdateSettings(driver);

            popupUpdateSettings.currencyDropDown.Click();
            customWaits.SetImplicitWaitTimeout(driver, 5);
            popupUpdateSettings.currencyPLN.Click();
            customWaits.SetImplicitWaitTimeout(driver,5);

            popupUpdateSettings.saveButton.Click();
            customWaits.SetImplicitWaitTimeout(driver, 5);
            var texts = etsyMensShoesPage.checkPrice.Text;
            Assert.True(texts.Contains(searchText));
        }
    }
}
