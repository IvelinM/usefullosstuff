using Common;
using System.Diagnostics;
using System.Threading.Tasks;

namespace RunUIClients
{
    class RunUIClients
    {
        static void Main(string[] args)
        {
            Process.Start(Constants.PATH_TO_THIS_SOLUTION + @"\RunApplicationUI\bin\Debug\RunApplicationUI.exe");
            Process.Start(Constants.PATH_TO_THIS_SOLUTION + @"\RunClientPortalUI\bin\Debug\RunClientPortalUI.exe");
        }
    }
}
