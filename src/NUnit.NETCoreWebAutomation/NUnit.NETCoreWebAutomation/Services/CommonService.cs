using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using NUnit.NETCoreWebAutomation.Models;
using NUnit.NETCoreWebAutomation.Helper;
using Action = NUnit.NETCoreWebAutomation.Helper.Action;
using Screenshot = NUnit.NETCoreWebAutomation.Helper.Screenshot;

namespace NUnit.NETCoreWebAutomation.Services
{
    public class CommonService : Browser
    {
        public Action Action = new Action();
        public Screenshot Screenshot = new Screenshot();

        public void Wait(int time)
        {
            Thread.Sleep(time);
        }

        public void CloseBrowser()
        {
            try
            {
                Driver.Close();
            }
            catch
            {
                Console.WriteLine("Browser already close");
            }
        }

        public void DriverQuit()
        {
            Driver.Quit();
        }

        //Function to verify the redirected URL contains a portion of the url e.g. /dashboard/ for regular user
        public static Func<IWebDriver, bool> UrlContains(string fraction)
        {
            //return (Driver) =>
            //{
            //    return Driver.Url.ToLowerInvariant().Contains(fraction.ToLowerInvariant());
            //};
            return (Driver) => Driver.Url.Contains(fraction, StringComparison.InvariantCultureIgnoreCase);
        }

        public void AssertPageTitle(string title)
        {
            Assert.AreEqual(title, Driver.Title, "Title not matching!");
        }

        //Function to Assert messages e.g. Success or Fail  OR created Item e.g. Enterprise
        public void AssertPageSourceContains(string validateText, string failedMessage)
        {
            Wait(2000);
            Assert.That(Driver.PageSource.Contains(validateText), Is.EqualTo(true),
               failedMessage);
            Wait(1000);
        }

        public void SwitchTab()
        {
            ReadOnlyCollection<String> windowHandles = Driver.WindowHandles;
            String firstTab = (String)windowHandles[0];
            String lastTab = windowHandles[windowHandles.Count - 1];
            Driver.SwitchTo().Window(lastTab);
            //Assert.IsTrue(Driver.FindElement(By.TagName("body")).Text.Contains
            //    ("This is url link page"));
        }

        public void SwitchToNewTab(string validationText, string validationText2 = null)
        {
            ReadOnlyCollection<String> windowHandles = Driver.WindowHandles;
            String firstTab = (String)windowHandles[0];
            String lastTab = windowHandles[windowHandles.Count - 1];
            Driver.SwitchTo().Window(lastTab);
            Wait(6000);
            Assert.IsTrue(Driver.FindElement(By.TagName("body")).Text.Contains
                (validationText));
        }
    }
}
