using OpenQA.Selenium;
using System;

namespace My_Framework.Utils
{
    public class CustomWaits
    {
        public void SetImplicitWaitTimeout(IWebDriver driver, int timeout)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
        }
    }
}
