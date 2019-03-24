using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HWFindSiteSelenium
{

    public class FindSeleniumSite
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            BasePage basePage = new BasePage(driver);
            basePage.SetImplicitWaitTimeout(driver, 10);
            driver.Navigate().GoToUrl("https://www.google.com");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Category("HW_Find_Selenium_site")]
        [Test]
        public void CheckFindSeleniumSite()
        {
            BasePage basePage = new BasePage(driver);
            var searchSite = basePage.google;
            searchSite.SendKeys("Selenium");
            searchSite.Submit();
            basePage.elementForSiteSelenium.Click();
            var newPage = driver.Url;
            Assert.AreEqual("https://www.seleniumhq.org/", newPage);

        }
    }
}
