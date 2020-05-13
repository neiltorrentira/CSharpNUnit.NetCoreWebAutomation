using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using NUnit.NETCoreWebAutomation.Models;

namespace NUnit.NETCoreWebAutomation.Services
{
    public class Browser : WebDriver
    {
        public BrowserType SetDriver
        {
            set
            {
                if (value == BrowserType.Chrome)
                {
                    Driver = new ChromeDriver(DriverDirectory.DriverPath);
                    Driver.Manage().Window.Maximize();
                }

                else if (value == BrowserType.Firefox)
                {
                    Driver = new FirefoxDriver(DriverDirectory.DriverPath);
                    Driver.Manage().Window.Maximize();
                }

                else
                {
                    throw new Exception("Driver not found");
                }
            }
        }
    }

    public enum BrowserType
    {
        Chrome,
        IE,
        Firefox
    }
}
