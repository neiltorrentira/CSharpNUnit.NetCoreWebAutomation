using System;

namespace NUnit.NETCoreWebAutomation.Helper
{
    public static class Timestamps
    {
        public static string TimestampUTC_MMddyyyy_HHmmss = DateTime.UtcNow.ToString("MMddyyyy.HHmmss");
        public static string Timestamp_ddMMMyyyy_HHmmtt = DateTime.Now.ToString("ddMMMyyyy-HHmmtt");
        public static string Timestamp_MMMddyyyy_HHmm_sstt = DateTime.Now.ToString("MMMddyyyy.HHmm.sstt");
        public static string Timestamp_MMMddyyyy_HHmmtt = DateTime.Now.ToString("MMMddyyyy.HHmmtt");
        public static string TimestampLocalTime_MMddyyyy_HHmm = string.Format("{0:MMddyyyy.HHmm}", DateTime.Now.ToLocalTime());
    }
}
