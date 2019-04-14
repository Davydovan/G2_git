using OpenQA.Selenium;

namespace G2_AutomationFramework.Utils
{
    public static class WebDriverExtensions
    {
        const string path = "C:/Users/Workstation/QALight_G2/Screen/screen.png";

        public static void TakeScreenshot(this IWebDriver driver
            , ScreenshotImageFormat format = ScreenshotImageFormat.Png
            , string pathToFile = path)
        {
            ((ITakesScreenshot)driver)
                .GetScreenshot()
                .SaveAsFile(pathToFile, format);
        }

        public static void ExecuteJavascript(this IWebDriver driver, string jsScript, params object[] args)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript(jsScript, args);
        }
    }
}
