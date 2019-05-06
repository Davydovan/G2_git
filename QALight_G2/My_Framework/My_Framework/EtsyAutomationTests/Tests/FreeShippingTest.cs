using EtsyAutomationTests.Pages;
using My_Framework.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace EtsyAutomationTests.Tests
{
    public class FreeShippingTest
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
        public void CountTheElementsWithFreeShippingTest()
        {
            var searchText = "FREE shipping";
            EtsyMensShoesPage etsyMensShoesPage = new EtsyMensShoesPage(driver);
            CustomWaits customWaits = new CustomWaits();
            var texts = etsyMensShoesPage.freeShipping;

            foreach (var textItem in texts)
            {
                Console.WriteLine(textItem.Text);
                Assert.True(textItem.Text.Contains(searchText));
            }
        }
    }
}
