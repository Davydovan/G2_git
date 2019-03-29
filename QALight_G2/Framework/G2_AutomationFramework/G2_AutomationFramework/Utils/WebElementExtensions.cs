using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace G2_AutomationFramework.Utils
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
