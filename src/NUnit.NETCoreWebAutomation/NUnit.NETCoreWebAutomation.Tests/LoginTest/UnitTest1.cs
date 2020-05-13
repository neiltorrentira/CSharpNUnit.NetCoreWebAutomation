using NUnit.Framework;
using OpenQA.Selenium;
using NUnit.NETCoreWebAutomation.Services;
using NUnit.NETCoreWebAutomation.Helper;
using NUnit.NETCoreWebAutomation.Models;

namespace NUnit.NETCoreWebAutomation.Test.LoginTest
{
    [TestFixture]
    public class Tests : CommonService
    {
        private readonly LoginModel loginModel = new LoginModel()
        {
            EmailAddress = "gmailuser1@gmail.com",
            Password = "hunter1234"
        };

        [SetUp]
        public void Setup()
        {
            SetDriver = BrowserType.Chrome;
            Driver.Navigate().GoToUrl(Urls.BaseUrl);
            Wait(7000);
        }

        [Test(Description = "TC1234: Login Gmail User1")]
        public void LoginGmailUserTest1()
        {
            Screenshot.TakescreenShot(nameof(LoginGmailUserTest1));
            Wait(200);
            Action.Click(By.CssSelector(Urls.GmailUrlCss));
            Wait(2000);
            SwitchToNewTab("Mag-sign in");
            Wait(3000);
            Assert.IsTrue(Driver.FindElement(By.TagName("body")).Text.Contains
                ("Magpatuloy sa Gmail"));
            Action.EnterText(By.Id(LoginElement.emailAddress), loginModel.EmailAddress);
            Wait(500);
            Action.Click(By.Id(LoginElement.nextButtonEmail));
            Wait(5000);
            Screenshot.TakescreenShot(nameof(LoginGmailUserTest1) + "_EmailAddressInput_");
            Wait(200);
        }

        [TearDown]
        public void EndTest()
        {
            Wait(1000);
            CloseBrowser();
            DriverQuit();
        }
    }
}