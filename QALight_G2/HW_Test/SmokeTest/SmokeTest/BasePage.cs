//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SmokeTest
//{

//    public abstract class BasePage
//    {
//        #region Locators
//        //Header
//        private readonly By _logoHeader = By.CssSelector(".header.innerpages .logo"); private readonly By _homePage = By.XPath("//div[@id='navbar-collapse-1'] //*[contains(text(),'вна')]");
//        private readonly By _aboutAs = By.XPath("//div[@id='navbar-collapse-1'] //*[contains(text(),'нас')]");
//        private readonly By _courses = By.XPath("//div[@id='navbar-collapse-1'] //*[contains(text(),'Курс')]");
//        private readonly By _news = By.XPath("//div[@id='navbar-collapse-1'] //*[contains(text(),'Нов')]");

//        private readonly By _knowledgeBase = By.XPath("//div[@id='navbar-collapse-1'] //*[contains(text(),'База знан')]");
//        private readonly By _faq = By.XPath("//div[@id='navbar-collapse-1'] //*[contains(text(),'FAQ')]");
//        private readonly By _contacts = By.XPath("//div[@id='navbar-collapse-1'] //*[contains(text(),'Контакт')]");
//        private readonly By _signUpForCourseButton = By.XPath("//div[@id='navbar-collapse-1'] //*[contains(text(),'Записат')]");

//        private readonly By _changeTheLanguageButtonRu = By.CssSelector(".lang-inline li:nth-child(1) a");
//        private readonly By _changeTheLanguageButtonUa = By.CssSelector(".lang-inline li:nth-child(2) a");

//        //Midle
//        private readonly By _pagenationBackToHome = By.CssSelector(".pagenation a");
//        private readonly By _coursesInput = By.CssSelector("#foxcontainer_m135 div:first-child div select");
//        private readonly By _surnameInput = By.CssSelector("#foxcontainer_m135 input#z_sender0");
//        private readonly By _nameInput = By.CssSelector("#foxcontainer_m135 input#z_text1");

//        private readonly By _phoneInput = By.CssSelector("#foxcontainer_m135 input#z_text0");
//        private readonly By _emailInput = By.CssSelector("#foxcontainer_m135 input#z_sender1");
//        private readonly By _skypeInput = By.CssSelector("#foxcontainer_m135 input#z_text2");
//        private readonly By _howdidyouhearaboutQALightInput = By.CssSelector("#foxcontainer_m135 div select[name=_e926ba2b2813f56de8fc13877057e908]");

//        private readonly By _questionsAndCommentsInput = By.CssSelector("#foxcontainer_m135 textarea");
//        private readonly By _submitButton = By.CssSelector("[type=submit]");
//        private readonly By _resetButton = By.CssSelector("[type=reset]");


//        //Footer
//        private readonly By _logoFooter = By.CssSelector("#footer_logo");
//        private readonly By _viewAllCoursesButton = By.CssSelector("# footer_social .my_btn");
//        private readonly By _facebookButton = By.XPath("//i[@class='fa fa-facebook']/parent::*");
//        private readonly By _twitterButton = By.XPath("//i[@class='fa fa-twitter']/parent::*");

//        private readonly By _youtubeButton = By.XPath("//i[@class='fa fa-youtube']/parent::*");
//        private readonly By _googlePlusButton = By.XPath("//i[@class='fa fa-google-plus']/parent::*");
//        private readonly By _linkedinButton = By.XPath("//i[@class='fa fa-linkedin']/parent::*");
//        private readonly By _vkButton = By.XPath("//i[@class='fa fa-vk']/parent::*");

//        private readonly By _instagramButton = By.XPath("//i[@class='fa fa-instagram']/parent::*");
//        #endregion

//        IWebDriver driver;

//        //protected void FindElement(By locator)
//        //{
//        //    driver.FindElement(locator);
//        //    //IWebElement element = driver
//        //    //    .FindElement(By.CssSelector("test css"));
//        //}

//        // Type text in text field
//        protected void Type(By locator, string text)
//        {
//           // WaitForElementVisibility(locator, Configuration.ElementVisibilityTimeout);
//            var element = driver.FindElement(locator);
//            element.SendKeys(Keys.Control + "a");
//            element.SendKeys(Keys.Delete);
//            element.SendKeys(text);
//        }

//        public void FillPage(string name, string surname, string phone, string email, string skype,string questions)
//        {
//            //CommonLoggerInfo($"Type credentials: {email}, {password}");
//            Type(_nameInput, name);
//            Type(_submitButton, surname);
//            Type(_phoneInput, phone);
//            Type(_emailInput, email);
//            Type(_skypeInput, skype);
//            Type(_questionsAndCommentsInput, questions);
            
//        }
//    }
//}
