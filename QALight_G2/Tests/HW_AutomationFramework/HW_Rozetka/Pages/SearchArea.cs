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

        [FindsBy(How = How.CssSelector, Using = "li.header-actions__item.header-actions__item_type_cart")]
        public IWebElement basket;

        [FindsBy(How = How.XPath, Using = "//div[@class='js-rz-cart']//div[@class='header-actions__dummy-content header-actions__dummy-content_type_cart']")]
        public IWebElement popUp;

        [FindsBy(How = How.XPath, Using = "//li[@class='menu-categories__item']//a[@href='https://rozetka.com.ua/computers-notebooks/c80253/']")]
        public IWebElement menuLaptop;

        [FindsBy(How = How.XPath, Using = "//div[@class='menu__hidden-content']//a[@href='https://rozetka.com.ua/notebooks/asus/c80004/v004/']")]
        public IWebElement asus;


    }
}
