﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace OldQaLight
{

    class OldQaLightPage
    {
        public IWebDriver driver;
        public OldQaLightPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "[name='_7c8289bf6b8e80c1749ef54ab01b92b8']")]
        public IWebElement course;

        [FindsBy(How = How.Id, Using = "z_sender0")]
        public IWebElement surnameField;

        [FindsBy(How = How.Id, Using = "z_text1")]
        public IWebElement NameField { get; private set; }

        [FindsBy(How = How.CssSelector, Using = "[type=submit]")]
        public IWebElement submitButton;
       
        [FindsBy(How =How.CssSelector, Using = ".alert.alert-error")]
        public IWebElement errorRegistrationPopup;

       

    }
}