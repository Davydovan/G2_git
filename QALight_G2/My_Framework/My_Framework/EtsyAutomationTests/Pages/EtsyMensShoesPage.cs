using G2_AutomationFramework.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace EtsyAutomationTests.Pages
{
    class EtsyMensShoesPage : BasePage
    {
        public EtsyMensShoesPage(IWebDriver driver) : base(driver)
        {
            searchArea = new SearchArea(driver);
        }

        public SearchArea searchArea;

        [FindsBy(How = How.XPath, Using = "//input[@name='is_discounted']/following-sibling::*")]
        public IWebElement checkBoxSale;

        [FindsBy(How = How.XPath, Using = "//*[contains(@class,'text-truncate wt-bg-slime-tint v2-listing-card__badge v2-listing-card__badge-taller')]")]
        public IList<IWebElement> freeShipping;

        [FindsBy(How = How.CssSelector, Using = "span.text-body-smaller.promotion-price.normal.no-wrap")]
        public IList<IWebElement> salePrice;

        [FindsBy(How = How.XPath, Using = "//*[contains(@class,'currency-symbol')]")]
        public IList<IWebElement> carrencySymbol;

        [FindsBy(How = How.CssSelector, Using = "div.mb-xs-3:nth-child(6) h3")]
        public IWebElement checkPrice;
    }
}
