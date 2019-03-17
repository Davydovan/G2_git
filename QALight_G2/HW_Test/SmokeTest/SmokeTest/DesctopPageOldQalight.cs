using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace SmokeTest
{
    [TestFixture]
    public class DesctopPageOldQalight
    {
        #region Locators
        //Header
        private readonly By _logoHeader = By.CssSelector(".header.innerpages .logo");
        private readonly By _homePage = By.XPath("//div[@id='navbar-collapse-1'] //*[contains(text(),'вна')]");
        private readonly By _aboutAs = By.XPath("//div[@id='navbar-collapse-1'] //*[contains(text(),'нас')]");
        private readonly By _aboutQaLight = By.XPath("//div[@id='navbar-collapse-1'] //*[contains(text(),'Про QALight')]");
        private readonly By _courses = By.XPath("//div[@id='navbar-collapse-1'] //*[contains(text(),'Курс')]");
        private readonly By _news = By.XPath("//div[@id='navbar-collapse-1'] //*[contains(text(),'Нов')]");

        private readonly By _knowledgeBase = By.XPath("//div[@id='navbar-collapse-1'] //*[contains(text(),'База знан')]");
        private readonly By _faq = By.XPath("//div[@id='navbar-collapse-1'] //*[contains(text(),'FAQ')]");
        private readonly By _contacts = By.XPath("//div[@id='navbar-collapse-1'] //*[contains(text(),'Контакт')]");
        private readonly By _signUpForCourseButton = By.XPath("//div[@id='navbar-collapse-1'] //*[contains(text(),'Записат')]");

        private readonly By _changeTheLanguageButtonRu = By.CssSelector(".lang-inline li:nth-child(1) a");
        private readonly By _changeTheLanguageButtonUa = By.CssSelector(".lang-inline li:nth-child(2) a");

        //Midle
        private readonly By _pagenationBackToHome = By.CssSelector(".pagenation a");
        private readonly By _coursesInput = By.CssSelector("#foxcontainer_m135 div:first-child div select");
        private readonly By _surnameInput = By.CssSelector("#foxcontainer_m135 input#z_sender0");
        private readonly By _nameInput = By.CssSelector("#foxcontainer_m135 input#z_text1");

        private readonly By _phoneInput = By.CssSelector("#foxcontainer_m135 input#z_text0");
        private readonly By _emailInput = By.CssSelector("#foxcontainer_m135 input#z_sender1");
        private readonly By _skypeInput = By.CssSelector("#foxcontainer_m135 input#z_text2");
        private readonly By _howDidYouHearAboutQALightInput = By.CssSelector("#foxcontainer_m135 div select[name=_e926ba2b2813f56de8fc13877057e908]");

        private readonly By _questionsAndCommentsInput = By.CssSelector("#foxcontainer_m135 textarea");
        private readonly By _submitButton = By.CssSelector("[type=submit]");
        private readonly By _resetButton = By.CssSelector("[type=reset]");


        //Footer
        private readonly By _logoFooter = By.CssSelector("#footer_logo");
        private readonly By _viewAllCoursesButton = By.CssSelector("#footer_social .my_btn");
        private readonly By _facebookButton = By.XPath("//i[@class='fa fa-facebook']/parent::*");
        private readonly By _twitterButton = By.XPath("//i[@class='fa fa-twitter']/parent::*");

        private readonly By _youtubeButton = By.XPath("//i[@class='fa fa-youtube']/parent::*");
        private readonly By _googlePlusButton = By.XPath("//i[@class='fa fa-google-plus']/parent::*");
        private readonly By _linkedinButton = By.XPath("//i[@class='fa fa-linkedin']/parent::*");
        private readonly By _vkButton = By.XPath("//i[@class='fa fa-vk']/parent::*");

        private readonly By _instagramButton = By.XPath("//i[@class='fa fa-instagram']/parent::*");

        //another pages
        private readonly By _massegAfterSendForm = By.XPath("//div[@id='foxcontainer_m135'] //li");
        private readonly By _backToHomePage = By.XPath("//div[@id='mp_first_block']");
        private readonly By _faqPage = By.CssSelector(".site_wrapper");
        #endregion

        #region Constanta
        const string HomePage = "http://old.qalight.com.ua/";
        const string HomePageWheneClickHeaderMenu = "http://comingsoon.qalight.com.ua/";
        const string HomePageLogoHeader = "http://old.qalight.com.ua/index.php";
        const string CoursesPage = "http://old.qalight.com.ua/course.html";
        const string NewsPage = "http://old.qalight.com.ua/news.html";
        const string KnowlegePage = "http://old.qalight.com.ua/knowledge.html";
        const string FaqPage = "http://old.qalight.com.ua/faq-page.html";
        const string ContactsPage = "http://old.qalight.com.ua/contacts.html";

        const string FacebookPage = "https://www.facebook.com/QALight?fref=ts";
        const string TwitterPage = "https://twitter.com/QA_Light";
        const string YoutubePage = "https://www.youtube.com/channel/UCYcjZ9X2WOtGHgxTsg-n5zQ/feed";
        const string GooglePlusPage = "https://plus.google.com/107789004049043978933";
        const string LinkedinPage = "https://www.linkedin.com/company/qa-light";
        const string VkPage = "https://vk.com/qalighttrainingcentre";
        const string InstagramPage = "https://www.instagram.com/qalight_kiev/";

        #endregion

        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://old.qalight.com.ua/zapisatsya-na-kursy/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }


        [Test, Description("Fill in the form")]
        public void CheckFillInTheForm()
        {
            // driver.FindElement(_courses).SendKeys();
            driver.FindElement(_surnameInput).SendKeys("Davydova");
            driver.FindElement(_nameInput).SendKeys("Natalia");
            driver.FindElement(_phoneInput).SendKeys("0663120736");

            driver.FindElement(_emailInput).SendKeys("microniya@ukr.net");
            driver.FindElement(_skypeInput).SendKeys("Nataha_davydova");
            driver.FindElement(_howDidYouHearAboutQALightInput).SendKeys(Keys.Down + Keys.Enter);

            driver.FindElement(_questionsAndCommentsInput).SendKeys("Question test");
            driver.FindElement(_submitButton).Click();

            string windowHandle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(windowHandle);
            var result = driver.FindElement(_massegAfterSendForm).Displayed;

            Assert.IsTrue(result);
        }

        [Test, Description("Clean form")]
        public void CheckCleanTheForm()
        {
            // driver.FindElement(_courses).SendKeys();
            driver.FindElement(_surnameInput).SendKeys("Davydova");
            driver.FindElement(_nameInput).SendKeys("Natalia");
            driver.FindElement(_phoneInput).SendKeys("0663120736");

            driver.FindElement(_emailInput).SendKeys("microniya@ukr.net");
            driver.FindElement(_skypeInput).SendKeys("Nataha_davydova");
            driver.FindElement(_howDidYouHearAboutQALightInput).SendKeys(Keys.Down + Keys.Enter);
            driver.FindElement(_questionsAndCommentsInput).SendKeys("Question test");

            driver.FindElement(_resetButton).Click();
        }

        [Test, Description("Pagination")]
        public void CheckPagination()
        {
            driver.FindElement(_pagenationBackToHome).Click();
            var newPage = driver.Url;

            Assert.AreEqual(HomePage, newPage);
        }

        [Test, Description("Go to home page whene click header logo")]
        public void CheckGoHomeWheneClickHeaderLogo()
        {
            driver.FindElement(_logoHeader).Click();
            var newPage = driver.Url;

            Assert.AreEqual(HomePageLogoHeader, newPage);
        }


        [Test, Description("Go to home page whene click footer logo")]
        public void CheckGoHomeWheneClickFooterLogo()
        {
            driver.FindElement(_logoFooter).Click();
            var newPage = driver.Url;

            Assert.AreEqual(HomePage, newPage);
        }

        [Test, Description("Go to home page whene click footer logo")]
        public void CheckHome()
        {
            driver.FindElement(_homePage).Click();
            var newPage = driver.Url;

            Assert.AreEqual(HomePageWheneClickHeaderMenu, newPage);

        }

        [Test, Description("Go to home page whene click footer logo")]
        public void CheckAboutAs()
        {
            driver.FindElement(_aboutQaLight).Click();
            var newPage = driver.Url;

            Assert.AreEqual("http://old.qalight.com.ua/about/pro-qalight.html", newPage);

        }

        [Test, Description("Go to home page whene click footer logo")]
        public void CheckNewsPage()
        {
            driver.FindElement(_news).Click();
            var newPage = driver.Url;

            Assert.AreEqual(NewsPage, newPage);

        }

        [Test, Description("Go to home page whene click footer logo")]
        public void CheckKnowledgePage()
        {
            driver.FindElement(_knowledgeBase).Click();
            var newPage = driver.Url;

            Assert.AreEqual(KnowlegePage, newPage);
        }

        [Test, Description("Go to home page whene click footer logo")]
        public void CheckGoFaqPage()
        {
            driver.FindElement(_faq).Click();
            var newPage = driver.Url;

            Assert.AreEqual(FaqPage, newPage);
        }

        [Test, Description("Go to home page whene click footer logo")]
        public void CheckContactsPage()
        {
            driver.FindElement(_contacts).Click();
            string windowHandle = driver.CurrentWindowHandle;
            var alert = driver.SwitchTo().Alert();
            alert.Accept();
            var newPage = driver.Url;

            Assert.AreEqual(ContactsPage, newPage);
        }

        [Test, Description("Go to home page whene click footer logo")]
        public void CheckSingUpFoCourse()
        {
            driver.FindElement(_signUpForCourseButton).Click();
            var newPage = driver.Url;

            Assert.AreEqual("http://old.qalight.com.ua/zapisatsya-na-kursy.html", newPage);
        }

        [Test, Description("Go to home page whene click footer logo")]
        public void CheckViewAllCourses()
        {
            driver.FindElement(_viewAllCoursesButton).Click();
            var newPage = driver.Url;

            Assert.AreEqual("http://old.qalight.com.ua/course.html", newPage);
        }


        [Test, Description("Go to home page whene click footer logo")]
        public void CheckChangeTheLanguageRu()
        {
            driver.FindElement(_changeTheLanguageButtonRu).Click();
            var newPage = driver.Url;

            Assert.AreEqual("http://old.qalight.com.ua/", newPage);

        }


        [Test, Description("Go to home page whene click footer logo")]
        public void CheckChangeTheLanguageUa()
        {
            driver.FindElement(_changeTheLanguageButtonUa).Click();
            var newPage = driver.Url;

            Assert.AreEqual("http://old.qalight.com.ua/ua/zapisatsya-na-kursy-2.html", newPage);

        }

        [Test, Description("Go to home page whene click footer logo")]
        public void CheckFacebook()
        {
            driver.FindElement(_facebookButton).Click();
            var allWindowHandels = driver.WindowHandles;
            var newPage = driver.SwitchTo().Window(allWindowHandels[1]).Url;

            Assert.AreEqual(FacebookPage, newPage);

        }

        [Test, Description("Go to home page whene click footer logo")]
        public void CheckTwitter()
        {
            driver.FindElement(_twitterButton).Click();
            var allWindowHandels = driver.WindowHandles;
            var newPage = driver.SwitchTo().Window(allWindowHandels[1]).Url;

            Assert.AreEqual(TwitterPage, newPage);
        }

        [Test, Description("Go to home page whene click footer logo")]
        public void CheckYoutube()
        {
            driver.FindElement(_youtubeButton).Click();
            var allWindowHandels = driver.WindowHandles;
            var newPage = driver.SwitchTo().Window(allWindowHandels[1]).Url;

            Assert.AreEqual(YoutubePage, newPage);
        }

        [Test, Description("Go to home page whene click footer logo")]
        public void CheckGooglePlus()
        {
            driver.FindElement(_googlePlusButton).Click();
            var allWindowHandels = driver.WindowHandles;
            var newPage = driver.SwitchTo().Window(allWindowHandels[1]).Url;

            Assert.AreEqual(GooglePlusPage, newPage);
        }

        [Test, Description("Go to home page whene click footer logo")]
        public void CheckLinkedin()
        {
            driver.FindElement(_linkedinButton).Click();
            var allWindowHandels = driver.WindowHandles;
            var newPage = driver.SwitchTo().Window(allWindowHandels[1]).Url;

            Assert.AreEqual(LinkedinPage, newPage);
        }

        [Test, Description("Go to home page whene click footer logo")] //пока не рабочий тест
        public void CheckVk()
        {
            driver.FindElement(_vkButton).Click();
            var allWindowHandels = driver.WindowHandles;
            var newPage = driver.SwitchTo().Window(allWindowHandels[1]).Url;

            Assert.AreEqual(VkPage, newPage);
        }

        [Test, Description("Go to home page whene click footer logo")]
        public void CheckInstagram()
        {
            driver.FindElement(_instagramButton).Click();
            var allWindowHandels = driver.WindowHandles;
            var newPage = driver.SwitchTo().Window(allWindowHandels[1]).Url;

            Assert.AreEqual(InstagramPage, newPage);
        }

    }
}
