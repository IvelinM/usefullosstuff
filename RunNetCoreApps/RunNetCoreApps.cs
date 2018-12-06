using Common;
using System.Diagnostics;

namespace RunNetCoreApps
{
    class RunNetCoreApps
    {
        static void Main(string[] args)
        {
            Process.Start(Constants.PATH_TO_THIS_SOLUTION + @"RunApplicationCoreApp\bin\Debug\RunApplicationCoreApp.exe");
            Process.Start(Constants.PATH_TO_THIS_SOLUTION + @"RunClientPortalCoreApp\bin\Debug\RunClientPortalCoreApp.exe");
        }
    }
}
