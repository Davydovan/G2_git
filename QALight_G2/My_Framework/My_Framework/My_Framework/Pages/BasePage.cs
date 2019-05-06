using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace G2_AutomationFramework.Pages
{
    public class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
