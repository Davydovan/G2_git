using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.PageObject
{
    public abstract class BaseClass
    {
        protected IWebDriver Driver;



        protected void Type(By locator, string text)
        {
            //WaitForElementVisibility(locator, Configuration.ElementVisibilityTimeout);
            var element = Driver.FindElement(locator);
            element.SendKeys(Keys.Control + "a");
            element.SendKeys(Keys.Delete);
            element.SendKeys(text);
        }

        protected void Click(By locator)
        {
            //WaitForElementAppiarence(locator, Configuration.ElementVisibilityTimeout);
            //WaitForElementToBeClickable(locator, Configuration.ElementVisibilityTimeout);
            //ScrollToView(locator);
            Driver.FindElement(locator).Click();
        }


        protected void OpenUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);

        }
    }
}
