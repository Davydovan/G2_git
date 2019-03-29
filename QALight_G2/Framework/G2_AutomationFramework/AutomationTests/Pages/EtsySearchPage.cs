using G2_AutomationFramework.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace EtsyAutomationTests.Pages
{
    class EtsySearchPage : BasePage
    {
        public EtsySearchPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.XPath, Using = "//*[contains(@class, 'v2-listing-card__info') and not(contains(@class, 'flex'))]//h2")]
        public IList<IWebElement> searchResultTextItems;
    }
}
