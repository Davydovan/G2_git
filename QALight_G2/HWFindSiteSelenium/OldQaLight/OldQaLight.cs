using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OldQaLight
{

    public class OldQaLight
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();            
            driver.Navigate().GoToUrl("http://old.qalight.com.ua/zapisatsya-na-kursy/");

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }


        [Category("Number of links to social networks")]
        [Test]
        public void CheckNumberOfLinksToSocialNetworks()
        {
            int recordsCount = driver.FindElement(By.XPath("//div[@id='footer_social']//ul"))
                .FindElements(By.XPath("//div[@id='footer_social']//ul//a")).Count;
            Assert.AreEqual(7, recordsCount);
        }
    }
}
