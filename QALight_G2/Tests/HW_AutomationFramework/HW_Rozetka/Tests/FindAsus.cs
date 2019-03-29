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
            //actions.MoveToElement(element).ClickAndHold()
            //   .MoveToElement(targetElement).Release().Perform();
            //EtsyMainPage etsyMainPage = new EtsyMainPage(driver);

            // actions.MoveToElement(element).ClickAndHold()
            //   .MoveToElement(targetElement, targetElement.Size.Width / 2, 2).Release().Perform()
            //, button.Size.Width/ 2, 2
            Actions actions = new Actions(driver);
            HomePage homePage = new HomePage(driver);
            
            actions.MoveToElement(homePage.searchArea.menuButton)
                .ClickAndHold()
                .MoveToElement(homePage.searchArea.menuLaptop)
                .MoveToElement(homePage.searchArea.asus)
                .Build().Perform();
            TimeSpan.FromSeconds(2000);
        }
    }
}
