using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace G2_AutomationFramework.Driver
{
    public  class CustomDriver
    {
        public static IWebDriver Driver
        {
            get
            {
                if (ConfigurationManager.AppSettings["PathToScreenshotFolder"] == "Chrome")
                {
                    return new ChromeDriver();
                }
                else
                {
                    return new ChromeDriver();
                }
            }

        }
    }
}
