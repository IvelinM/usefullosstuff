using Common;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace RunUIClients
{
    class RunUIClients
    {
        static void Main(string[] args)
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            var asdasd = Path.GetDirectoryName(path);

            var app = Constants.PATH_TO_THIS_SOLUTION + @"RunApplicationUI\bin\Debug\RunApplicationUI.exe";
            var cp = Constants.PATH_TO_THIS_SOLUTION + @"RunClientPortalUI\bin\Debug\RunClientPortalUI.exe";
            Process.Start(app);
            Process.Start(cp);
        }
    }
}
