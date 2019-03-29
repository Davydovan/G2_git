using OpenQA.Selenium;
using System;

namespace HW_AutomationFramework.Utils
{
    public class CustomWaits
    {
        public void SetImplicitWaitTimeout(IWebDriver driver, int timeout)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
        }
    }
}
