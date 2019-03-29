using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace OldQaLight
{

    public class OldQaLight
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            //driver.Manage().Window.Minimize();
            SetImplicitWaitTimeout(driver, 10);
            driver.Navigate().GoToUrl("http://old.qalight.com.ua/zapisatsya-na-kursy/");
            
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Category("Smoke")]
        [Test]
        public void SmokeTestWithPaGeObject_Negative()
        {

            //Act
            OldQaLightPage oldQaLightPage = new OldQaLightPage(driver);
            var course = oldQaLightPage.course;

            SelectElement courseDropdown = new SelectElement(course);
            courseDropdown.SelectByIndex(3);
            oldQaLightPage.surnameField.SendKeys("surname");
            oldQaLightPage.NameField.SendKeys("Name");
            oldQaLightPage.submitButton.Click();


            //Assert
            Assert.True(IsElementPresent(oldQaLightPage.errorRegistrationPopup),
                 $"Element {nameof(oldQaLightPage.errorRegistrationPopup)} is not present on the page as expected.");

            
            //Assert

        }

        public bool IsElementPresent(IWebElement element)
        {
            SetImplicitWaitTimeout(driver, 2);
            try
            {
                var result = element.Displayed;
                SetImplicitWaitTimeout(driver, 10);
                return true;
            }
            catch (NoSuchElementException)
            {
                SetImplicitWaitTimeout(driver, 10);
                return false;
            }

            throw new Exception("Unexpected exception.");
        }

        //TODO move metod to Utils
        public void SetImplicitWaitTimeout(IWebDriver driver, int timeout)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
        }

        //}

        //[Category("Smoke")]
        //[Test]
        //public void SmokeTest()
        //{
        //    //Arrange
        //    string expectedElementLocator = ".alert.alert-error";

        //    //Act
        //    IWebElement course = driver.FindElement(By.CssSelector("[name='_7c8289bf6b8e80c1749ef54ab01b92b8']"));
        //    SelectElement courseDropdown = new SelectElement(course);
        //    courseDropdown.SelectByIndex(3);

        //    IWebElement surnameField = driver.FindElement(By.Id("z_sender0"));
        //    surnameField.SendKeys("surname");

        //    IWebElement nameField = driver.FindElement(By.Id("z_text1"));
        //    nameField.SendKeys("name");

        //    IWebElement phoneField = driver.FindElement(By.Id("z_text0"));
        //    phoneField.SendKeys("0663520765");

        //    IWebElement emailField = driver.FindElement(By.Id("z_sender1"));
        //    emailField.SendKeys("test@i.ua");

        //    IWebElement skypeField = driver.FindElement(By.Id("z_text2"));
        //    skypeField.SendKeys("nata_test");

        //    IWebElement sourseInfo = driver.FindElement(By.CssSelector("[name='_e926ba2b2813f56de8fc13877057e908']"));
        //    SelectElement sourseInfoDropdown = new SelectElement(sourseInfo);
        //    sourseInfoDropdown.SelectByIndex(4);

        //    IWebElement submitButton = driver.FindElement(By.CssSelector("[type=submit]"));
        //    submitButton.Click();

        //    //Assert
        //    Assert.True(IsElementPresent(driver, expectedElementLocator), 
        //        $"Element with locator {expectedElementLocator} is not present on the page as expected");


        //    //IWebElement successElement = driver.FindElement(By.CssSelector(".alert.alert-success"));


        //    //.alert.alert-success
        //    //.alert.alert-error

        //    Thread.Sleep(2000);

        //}

        //public bool IsElementPresent(IWebDriver driver, string cssSelector)
        //{

        //    var elements = driver.FindElements(By.CssSelector(cssSelector));

        //    if (elements.Count == 1)
        //    {
        //        return true;
        //    }

        //    else if (elements.Count == 0)
        //    {
        //        return false;
        //    }

        //    else
        //    {
        //        throw new Exception("Unexcected exception");
        //    }

        //}

    }
}
