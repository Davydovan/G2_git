using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace WebDriver
{
    class TestingActions
    {
        [Test]
        public void TestingActionsAndAction()
        {
            IWebDriver driver = null;
            IWebElement element = null;
            IWebElement targetElement = null;

            Actions actions = new Actions(driver);

            //action.KeyDown(Keys.Control).KeyUp("A");
            //IAction action = actions.Click().MoveByOffset(4, 5).Click().Build();
            //action.Perform();

            actions.MoveToElement(element).ClickAndHold()
                .MoveToElement(targetElement).Release().Perform();

            actions.MoveToElement(element).ClickAndHold()
               .MoveToElement(targetElement, targetElement.Size.Width/2, 2).Release().Perform(); //пример
        }
    }
}
