using System;
using System.IO;

namespace NUnit.NETCoreWebAutomation.Models
{
    public static class ProjectDirectory
    {
        public static string ProjectDir =
            Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
    }
}
