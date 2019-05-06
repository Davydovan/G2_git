using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Waits
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = null;
            IWebElement element = null;

            driver.JavaScriptClick(element);

            driver.SetImplicitWait(10);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));

            CustomWaits.WaitForElementIsClickable(driver,element,3);            
        }
    }
}
