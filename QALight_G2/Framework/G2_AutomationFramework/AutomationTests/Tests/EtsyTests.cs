using EtsyAutomationTests.Pages;
using G2_AutomationFramework.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace EtsyAutomationTests.Tests
{
    public class EtsyTests
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
        public void TestSearch()
        {
            var searchText = "Martin Boots";
            EtsyMainPage etsyMainPage = new EtsyMainPage(driver);
            etsyMainPage.searchArea.searchFild.SetText(searchText);
            etsyMainPage.searchArea.searchButton.Click();

            EtsySearchPage etsysSearchPage = new EtsySearchPage(driver);

            var texts = etsysSearchPage.searchResultTextItems;

            foreach (var textItem in texts)
            {
                Console.WriteLine(textItem.Text);
                Assert.True(textItem.Text.Contains(searchText));
            }
            
           
        }
    }
}
