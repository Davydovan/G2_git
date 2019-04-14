using HW_AutomationFramework.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace HW_UkrNet.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "id-input-login")]
        public IWebElement inputName;

        [FindsBy(How = How.Id, Using = "id-input-password")]
        public IWebElement passwordName;

        [FindsBy(How = How.CssSelector, Using = "button.form__submit")]
        public IWebElement submitButton;

        [FindsBy(How = How.CssSelector, Using = "div#login-frame-wraper iframe")]
        public IWebElement iframe;

        [FindsBy(How = How.CssSelector, Using = "p.form__error.form__error_wrong.form__error_visible")]
        public IWebElement errorMessage;

        [FindsBy(How = How.Id, Using = "id-user-email")]
        public IWebElement accountEmail;

        [FindsBy(How = How.CssSelector, Using = "a.service__entry_mail")]
        public IWebElement buttonInputLetters;

        [FindsBy(How = How.CssSelector, Using = "button.default.compose")]
        public IWebElement buttonWriteLetter;

        [FindsBy(How = How.CssSelector, Using = "input[name = toFieldInput]")]
        public IWebElement inputEmailWhomSend;

        [FindsBy(How = How.CssSelector, Using = "input[name=subject]")]
        public IWebElement inputTheme;

        [FindsBy(How = How.Id, Using = "tinymce")]
        public IWebElement inputText;

        [FindsBy(How = How.CssSelector, Using = "button.default.send")]
        public IWebElement buttonSendLetter;

        [FindsBy(How = How.Id, Using = "mce_0_ifr")]
        public IWebElement iframeLetter;

        [FindsBy(How = How.CssSelector, Using = "button.action.attachments-file-button")]
        public IWebElement attachments;

        [FindsBy(How = How.CssSelector, Using = "p.login-button__user")]
        public IWebElement loginUser;

        [FindsBy(How = How.XPath, Using = "//input[@type='file']")]
        public IWebElement inputAddFile;        
    }
}
