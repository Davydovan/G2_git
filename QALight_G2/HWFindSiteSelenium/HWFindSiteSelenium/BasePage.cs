using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace HWFindSiteSelenium
{
    class BasePage
    {
        public IWebDriver driver;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@class='gLFyf gsfi']")]
        public IWebElement google;

        [FindsBy(How = How.XPath, Using = "//a[@href='https://www.seleniumhq.org/']")]
        public IWebElement elementForSiteSelenium;

        public void SetImplicitWaitTimeout(IWebDriver driver, int timeout)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
        }
    }
}
