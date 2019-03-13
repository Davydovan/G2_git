using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriver
{
 
    public class UiTests
    {
        [Test]
        public void TestWebDriverMethods()
        {
            IWebDriver driver = new ChromeDriver();
        }
        
    }
}
