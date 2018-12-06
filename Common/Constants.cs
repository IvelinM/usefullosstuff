using System;
using System.IO;
using System.Reflection;

namespace Common
{
    public static class Constants
    {
        public static string PATH_TO_LOS_FOLDER = @"C:\IVELIN\PROJECTS\LOS"; 
        public static string PATH_TO_THIS_SOLUTION = Path.GetFullPath(Path.Combine(Assembly.GetExecutingAssembly().Location, "../../../../"));
    }
}
