using HW_AutomationFramework.Utils;
using HW_UkrNet.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW_UkrNet.Tests
{
    public class SendEmailWithFile
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
        public void SendEmailWithFIle()
        {
            HomePage homePage = new HomePage(driver);
            driver.SwitchTo().Frame(homePage.iframe);
            homePage.inputName.SendKeys("microniya@ukr.net");
            homePage.passwordName.SendKeys("*****");
            homePage.submitButton.Click();

            string accountEmail = homePage.accountEmail.Text;
            Assert.AreEqual(accountEmail, "microniya@ukr.net");
            homePage.buttonInputLetters.Click();
            driver.SwitchTo().DefaultContent();
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            string loginUser = homePage.loginUser.Text;
            Assert.AreEqual(loginUser, "microniya@ukr.net");
            homePage.buttonWriteLetter.Click();
            homePage.inputEmailWhomSend.SendKeys("terraco_kiev@ukr.net");
            homePage.inputTheme.SendKeys("Sending message - test");

            driver.SwitchTo().Frame(homePage.iframeLetter);
            homePage.inputText.SendKeys("Hello, Andrey!");
            driver.SwitchTo().DefaultContent();
            homePage.inputAddFile.SetText("C:/Users/Workstation/Desktop/galery/5529.jpg");
            homePage.buttonSendLetter.Click();
        }
    }
}
