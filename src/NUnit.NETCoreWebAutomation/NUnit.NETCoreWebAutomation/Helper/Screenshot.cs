using System;
using OpenQA.Selenium;
using NUnit.NETCoreWebAutomation.Models;
using NUnit.NETCoreWebAutomation.Services;

namespace NUnit.NETCoreWebAutomation.Helper
{
    public class Screenshot : CommonService
    {
        public void Screenshots(string testgroupname)
        {
            ((ITakesScreenshot)Driver).GetScreenshot()
                .SaveAsFile(GetFileName(testgroupname), ScreenshotImageFormat.Png);
        }

        public void TakescreenShot(string testgroupname)
        {
            try
            {
                var ss = ((ITakesScreenshot)Driver).GetScreenshot();
                ss.SaveAsFile(GetFileName(testgroupname), ScreenshotImageFormat.Png);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public static string Timestamp_MMMddyyyy_HHmm_sstt()
        {
            return DateTime.Now.ToString("MMMddyyyy.HHmm.sstt");
        }

        public static string GetFileName(string testgroupname)
        {
            return $"{ScreenshotDirectory.ScreenshotDir}\\{testgroupname}_Screenshots_{Timestamp_MMMddyyyy_HHmm_sstt()}.png";
        }
    }
}
