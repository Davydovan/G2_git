using G2_AutomationFramework.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace EtsyAutomationTests.Pages
{
    class PopupUpdateSettings : BasePage
    {
        public PopupUpdateSettings(IWebDriver driver) : base(driver)
        {
            searchArea = new SearchArea(driver);
        }

        public SearchArea searchArea;

        [FindsBy(How = How.Id, Using = "locale-overlay-save")]
        public IWebElement saveButton;

        [FindsBy(How = How.Id, Using = "locale-overlay-select-currency_code")]
        public IWebElement currencyDropDown;

        [FindsBy(How = How.CssSelector, Using = "option[value = PLN]")]
        public IWebElement currencyPLN;
    }
}
