using Common;
using System.Diagnostics;
using System.Threading.Tasks;

namespace RunUIClients
{
    class RunUIClients
    {
        static void Main(string[] args)
        {
            var app = Constants.PATH_TO_THIS_SOLUTION + @"\RunApplicationUI\bin\Debug\RunApplicationUI.exe";
            var cp = Constants.PATH_TO_THIS_SOLUTION + @"\RunClientPortalUI\bin\Debug\RunClientPortalUI.exe";
            Process.Start(app);
            Process.Start(cp);
        }
    }
}
