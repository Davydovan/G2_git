using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ClassLibrary1.PageObject
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        #region Locators
        private readonly By _nameInput = By.Id("id-input-login");
        private readonly By _passwordInput = By.Id("id-input-password");
        private readonly By _submit = By.CssSelector("button.form__submit");

        

        #endregion

        public void FillPage(string email, string password)
        {
                       // CommonLoggerInfo($"Type credentials: {email}, {password}");
            Type(_nameInput, email);
            Type(_passwordInput, password);
        }

        public void ClickRegistrationTab()
        {
            //CommonLoggerInfo("Click 'Registration' tab");
            Click(_submit);
        }

    }
}
