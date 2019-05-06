using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace Waits
{
    public static class WebDriverExtentions
    {
        public static void TakeScreenshotForSpecFlowScenario(this IWebDriver driver, string fullTestName)
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(Path.Combine("test path", $"{fullTestName}{DateTime.Now.Ticks}.jpg"));
        }

        public static void JavaScriptClick(this IWebDriver driver, IWebElement control)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", control);
        }

        public static void OpenAndSwitchToNewWindow(this IWebDriver driver)
        {
            var parentHandles = driver.WindowHandles;
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            var allHandles = driver.WindowHandles;

            foreach (var handle in allHandles)
            {
                if (!parentHandles.Contains(handle))
                {
                    driver.SwitchTo().Window(handle);
                }
            }
        }

        public static void SetTextUsingActions(this IWebDriver driver, string text)
        {
            new Actions(driver).SendKeys(text).Perform();
        }

        public static void SetValueInDropdown(this IWebDriver driver, string value, int openingDropdownDelay) =>
            SetValueInWebElement(driver, value, openingDropdownDelay, $"//li[text()=\"{value}\"]");

        public static void SetValueInDropdownWithCheckboxes(this IWebDriver driver, string value, int openingDropdownDelay) =>
            SetValueInWebElement(driver, value, openingDropdownDelay, $"//label[text()=\"{value}\"]/input[@type='checkbox']");

        private static void SetValueInWebElement(this IWebDriver driver, string value, int openingDropdownDelay, string xpathToFind)
        {
            var dropdownItems = driver.FindElements(By.XPath(xpathToFind));
            if (!dropdownItems.Any())
            {
                throw new Exception($"Element with text {value} is not present in dropdown");
            }

            ClickWebElement(driver, dropdownItems, openingDropdownDelay);
        }

        public static void SetValueToMultiselectDropdown(this IWebDriver driver, IWebElement dropdown, string value)
        {
            var itemXpath = $"//ul[not(@id)]//li[text()=\"{value}\"]";
            var itemsXpath = $"//li[text()=\"{value}\"]//parent::ul[not(@id)]//li";
            dropdown.SendKeys(value);
            CustomWaits.WaitForDropdownFilterApplied(driver, dropdown, itemXpath, itemsXpath);
        }

        private static void ClickWebElement(this IWebDriver driver, ReadOnlyCollection<IWebElement> webItems, int delay)
        {
            foreach (var item in webItems)
            {
                try
                {
                    CustomWaits.WaitForElementIsClickable(driver, item, delay);
                    item.Click();

                    break;
                }
                catch (WebDriverTimeoutException)
                {
                }
            }
        }

        public static void DragAndDrop(this IWebDriver driver, IWebElement sourceElement, IWebElement targetElement)
        {
            new Actions(driver).ClickAndHold(sourceElement).MoveToElement(targetElement).MoveByOffset(0, 3).Release().Perform();
        }

        public static void SetImplicitWait(this IWebDriver driver, int timeout)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
        }

        public static void ExplicitWaitUntil<TResult>(this IWebDriver driver, Func<TResult> conditon, int timeout = 5, Type TWebDriverException = null)
            => ExplicitWaitUntil(driver, d => conditon(), timeout, TWebDriverException);


        public static void ExplicitWaitUntil<TResult>(this IWebDriver driver, Func<IWebDriver, TResult> conditon, int timeout = 5, Type TWebDriverException = null)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            if (TWebDriverException != null)
            {
                wait.IgnoreExceptionTypes(TWebDriverException);
            }
            wait.Until(conditon);
        }
    }
}
