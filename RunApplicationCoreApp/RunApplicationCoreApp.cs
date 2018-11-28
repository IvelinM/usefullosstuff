using Common;
using System.Diagnostics;

namespace RunApplicationCoreApp
{
    class RunApplicationCoreApp
    {
        static void Main(string[] args)
        {
            string ClientPortalPath = Constants.PATH_TO_LOS_FOLDER + @"\LOS\src\Los.ClientPortal\Web\Los.ClientPortal.Web";

            var RunClientPortalNetCoreApp = new ProcessStartInfo
            {
                FileName = "cmd",
                RedirectStandardInput = true,
                WorkingDirectory = ClientPortalPath,
                UseShellExecute = false,
                CreateNoWindow = false
            };
            var pRunClientPortalNetCoreApp = Process.Start(RunClientPortalNetCoreApp);
            pRunClientPortalNetCoreApp.StandardInput.WriteLine("dotnet watch run");
            pRunClientPortalNetCoreApp.WaitForExit();
        }
    }
}
