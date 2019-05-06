using OpenQA.Selenium;
using System;
using WaitHelpers = SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace Waits
{
    public static class CustomWaits
    {
        public static void WaitForDataLoadingInAccomodation(IWebDriver driver)
        {
            driver.SetImplicitWait(1);
            var accommodationLoadingSpinnerLocator = By.CssSelector(".k-loading-image");
            driver.ExplicitWaitUntil(WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(accommodationLoadingSpinnerLocator), 5);
            driver.SetImplicitWait(10);
        }

        public static void WaitForDataLoadingInAdmission(IWebDriver driver)
        {
            driver.ExplicitWaitUntil(d => d.FindElements(By.Id("ContentPlaceHolder1_RadAjaxLoadingPanel1ctl00_ContentPlaceHolder1_RadAjaxPanel2")).Count == 0, 20);
        }

        public static void WaitForElementIsClickable(IWebDriver driver, IWebElement element, int timeout)
        {
            driver.ExplicitWaitUntil(WaitHelpers.ExpectedConditions.ElementToBeClickable(element), timeout);
        }

        public static void WaitForElementExist(IWebDriver driver, By locator, int timeout)
        {
            driver.ExplicitWaitUntil(WaitHelpers.ExpectedConditions.ElementExists(locator), timeout);
        }

        public static void WaitForElementIsVisible(IWebDriver driver, By locator, int timeout)
        {
            driver.ExplicitWaitUntil(WaitHelpers.ExpectedConditions.ElementIsVisible(locator), timeout);
        }

        public static void WaitForElementIsNotVisible(IWebDriver driver, By locator, int timeout)
        {
            driver.ExplicitWaitUntil(WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(locator), timeout);
        }

        public static void WaitForElementNotExist(IWebDriver driver, By locator)
        {
            Func<IWebDriver, bool> isElementNotPresent = (webDriver) =>
            {
                try
                {
                    driver.FindElement(locator);
                }
                catch (Exception ex)
                {
                    return true;
                }
                return false;
            };
            driver.ExplicitWaitUntil(isElementNotPresent);
        }

        public static void WaitForAlert(IWebDriver driver)
        {
            driver.ExplicitWaitUntil(WaitHelpers.ExpectedConditions.AlertIsPresent());
        }

        public static void WaitForDropdownFilterApplied(IWebDriver driver, IWebElement dropdown, string expectedItemXpath, string dropdownItemsXpath, int timeout = 5)
        {
            driver.ExplicitWaitUntil(webDriver => webDriver.FindElements(By.XPath(dropdownItemsXpath)).Count == 1
                && webDriver.FindElement(By.XPath(expectedItemXpath)).Displayed);
            dropdown.SendKeys(Keys.Enter);
        }

        public static void WaitForElementDisplayed(IWebElement element, int timeout = 3, double pollingInterval = 1)
        {
            var wait = CreateDefaultWait(element, timeout, pollingInterval);
            wait.Until(webElement => webElement != null && webElement.Displayed);
        }

        public static void WaitForElementEnabled(IWebElement element, int timeout = 3, double pollingInterval = 1)
        {
            var wait = CreateDefaultWait(element, timeout, pollingInterval);
            wait.Until(webElement => webElement != null && webElement.Enabled);
        }

        public static void WaitForClickElement(IWebElement control, int timeout = 5, int repeatActionInterval = 1)
        {
            var wait = CreateDefaultWait(control, timeout, repeatActionInterval);
            wait.IgnoreExceptionTypes(typeof(Exception));
            Func<IWebElement, bool> isElementClicked = (webElement) =>
            {
                if (webElement.Displayed)
                {
                    try
                    {
                        webElement.Click();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                return false;
            };
            wait.Until(isElementClicked);
        }

        public static void WaitForWebElementAttribute(IWebElement control, string attributeName, string expectedValue, int timeout = 5, int repeatActionInterval = 1)
        {
            var wait = CreateDefaultWait(control, timeout, repeatActionInterval);
            Func<IWebElement, bool> isElementHasAttribute = (webElement) =>
            {
                if (webElement.GetAttribute(attributeName) == expectedValue)
                {
                    return true;
                }
                return false;
            };
            wait.Until(isElementHasAttribute);
        }

        public static DefaultWait<T> CreateDefaultWait<T>(T element, int timeout, double pollingInterval)
        {
            var wait = new DefaultWait<T>(element)
            {
                Timeout = TimeSpan.FromSeconds(timeout),
                PollingInterval = TimeSpan.FromSeconds(pollingInterval)
            };
            return wait;
        }
    }
}
