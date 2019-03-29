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

        [FindsBy(How = How.Id, Using = "search-query")]
        public IWebElement searchFild;

        [FindsBy(How = How.CssSelector, Using = "button[value = Search]")]
        public IWebElement searchButton;
    }
}
