using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace ClassLibrary1.PageObject
{
    public abstract class BasePage : BaseClass
    {
       

        protected BasePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            Driver = driver;
        }

        
    }
}
