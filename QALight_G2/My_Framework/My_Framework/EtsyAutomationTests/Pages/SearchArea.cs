using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace EtsyAutomationTests.Pages
{
    public class SearchArea
    {
        public SearchArea(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[@id='catnav-primary-link-10923']/parent::*")]
        public IWebElement searchMenuShoes;

        [FindsBy(How = How.XPath, Using = "//span[@id='side-nav-category-link-10936']")]
        public IWebElement menuButtonMens;
        
        [FindsBy(How = How.XPath, Using = "//a[@id='catnav-l3-10940']")]
        public IWebElement menuShoesButton;

        [FindsBy(How = How.CssSelector, Using = "button.footer-locale-settings-button")]
        public IWebElement popupChangeRegionLanguageCarrency;
    }
}
