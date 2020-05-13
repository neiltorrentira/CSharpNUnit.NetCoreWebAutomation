using OpenQA.Selenium;

namespace NUnit.NETCoreWebAutomation.Services
{
    public class WebDriver
    {
        public static IWebDriver Driver { get; set; }
    }
    public enum PropertyType
    {
        Id,
        Name,
        XPath,
        CssSelector,
        CssName,
        Classname,
        LinkText
    }
}
