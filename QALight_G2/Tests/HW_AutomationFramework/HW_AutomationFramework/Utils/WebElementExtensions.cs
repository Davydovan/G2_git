using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HW_AutomationFramework.Utils
{
    public static class WebElementExtensions
    {
        public static void SetText(this IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public static void SetDropdownOptioByText(this IWebElement element, string text)
        {
            new SelectElement(element).SelectByText(text);
        }
    }
}

