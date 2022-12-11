using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using NUnit.NETCoreWebAutomation.Models;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

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
                    /*Driver = new ChromeDriver(DriverDirectory.DriverPath);*/
                    Console.WriteLine("Setup Driver... : " + BrowserType.Chrome);
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    Driver = new ChromeDriver();
                    PrepareBrowser();
                }

                else if (value == BrowserType.Firefox)
                {
                    /*Driver = new FirefoxDriver(DriverDirectory.DriverPath);*/
                    Console.WriteLine("Setup Driver... : " + BrowserType.Firefox);
                    new DriverManager().SetUpDriver(new FirefoxConfig());
                    Driver = new FirefoxDriver();
                    PrepareBrowser();
                }

                else if (value == BrowserType.Edge)
                {
                    Console.WriteLine("Setup Driver... : " + BrowserType.Edge);
                    new DriverManager().SetUpDriver(new EdgeConfig());
                    Driver = new EdgeDriver();
                    PrepareBrowser();
                }

                else
                {
                    throw new Exception("Driver not found");
                }
            }
        }

        public static void PrepareBrowser()
        {
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);
        }
    }

    public enum BrowserType
    { Chrome, Firefox, Edge }

}
