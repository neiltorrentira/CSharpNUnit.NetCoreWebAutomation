using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading;
using NUnit.NETCoreWebAutomation.Services;
using NUnit.NETCoreWebAutomation.Models;

namespace NUnit.NETCoreWebAutomation.Helper
{
    public class Action : CommonService
    {
        public void Click(By by)
        {
            Driver.FindElement(by).Click();
        }

        public void ClickLinkText(string linkTextName)
        {
            Driver.FindElement(By.LinkText(linkTextName)).Click();
        }

        public void EnterText(By by, string value)
        {
            Thread.Sleep(500);
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException();
            Driver.FindElement(by).SendKeys(value);
        }
    }
}
