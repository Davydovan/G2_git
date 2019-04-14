using HW_AutomationFramework.Utils;
using HW_UkrNet.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW_UkrNet.Tests
{
    public class LoginNegativeTest
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            CustomWaits customWaits = new CustomWaits();
            customWaits.SetImplicitWaitTimeout(driver, 10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.ukr.net/");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void LogInNegativeTest()
        {
            HomePage homePage = new HomePage(driver);
            driver.SwitchTo().Frame(homePage.iframe);

            homePage.inputName.SetText("microniya@ukr.net");
            homePage.passwordName.SetText("1qaz2wsx");
            homePage.submitButton.Click();

            string errorMessage = homePage.errorMessage.Text;
            Assert.AreEqual(errorMessage, "Неправильні дані");

            driver.SwitchTo().DefaultContent();
        }
    }
}
