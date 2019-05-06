using EtsyAutomationTests.Pages;
using My_Framework.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace EtsyAutomationTests.Tests
{
    public class CheckPriceSaleMensShoesTest 
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
        public void CheckSalePrice()
        {
            EtsyMensShoesPage etsyMensShoesPage = new EtsyMensShoesPage(driver);
            CustomWaits customWaits = new CustomWaits();
            etsyMensShoesPage.checkBoxSale.Click();
            customWaits.SetImplicitWaitTimeout(driver, 5);
            var saleText = etsyMensShoesPage.salePrice;
           
            foreach (var textItem in saleText)
            {
                Console.WriteLine(textItem.Text);
               
                Assert.AreEqual("rgba(46, 133, 57, 1)", textItem.GetCssValue("color"));
                
            }

        }
    }
}
