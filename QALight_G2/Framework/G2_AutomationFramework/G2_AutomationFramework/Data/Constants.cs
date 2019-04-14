using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace G2_AutomationFramework.Data
{
    public class Constants
    {

        public enum Browsers
        {
            Chrome, IE
        }

        public string Path => ConfigurationManager.AppSettings["PathToScreenshotFolder"];

        public void Test(Browsers browserType)
        {
        }

        public void Test1()
        {
            Test(Browsers.Chrome);
        }

       
    }
}
