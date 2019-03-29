using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace HW_Rozetka.Pages
{
    public class SearchArea
    {
        public SearchArea(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "cart_popup_header")]
        public IWebElement basket;

        [FindsBy(How = How.Id, Using = "empty_cart_popup_header")]
        public IWebElement popUp;

        [FindsBy(How = How.Id, Using = "fat_menu_btn")]
        public IWebElement menuButton;

        [FindsBy(How = How.XPath, Using = "//li[@id='2416']")]
        public IWebElement menuLaptop;

        [FindsBy(How = How.XPath, Using = "//a[@href='https://rozetka.com.ua/notebooks/asus/c80004/v004/']/parent::*")]
        public IWebElement asus;
    }
}
