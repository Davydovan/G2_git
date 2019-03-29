using HW_AutomationFramework.Pages;
using OpenQA.Selenium;

namespace HW_Rozetka.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
            searchArea = new SearchArea(driver);
        }

        public SearchArea searchArea;
    }
}
