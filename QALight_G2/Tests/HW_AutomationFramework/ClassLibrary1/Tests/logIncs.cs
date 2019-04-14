using ClassLibrary1.PageObject;
using NUnit.Framework;
using System;


namespace ClassLibrary1.Tests
{

    public class ProjectXLoginDesktopTest : BaseClass
    {
        public static string email = "microniya@ukr.net";
        public static string password = "1qaz2wsx";

        //[SetUp]
        //public void SetUp()
        //{
        //    //Driver = new ChromeDriver();
        //    //CustomWaits customWaits = new CustomWaits();
        //    //customWaits.SetImplicitWaitTimeout(driver, 10);
        //    Driver.Manage().Window.Maximize();
        //    Driver.Navigate().GoToUrl("https://www.ukr.net/");
        //}

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void LogInNegativeTest()
        {
            OpenUrl("https://www.ukr.net/");
            var homePage = new HomePage(Driver);
            homePage.FillPage(email,password);
            homePage.ClickRegistrationTab();
            TimeSpan.FromSeconds(2000);

            
    }

    }
    
}


