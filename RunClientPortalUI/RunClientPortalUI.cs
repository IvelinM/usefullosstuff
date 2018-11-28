using Common;
using System.Diagnostics;

namespace RunClientPortalUI
{
    class RunClientPortalUI
    {
        static void Main(string[] args)
        {
            string ClientPortalPath = Constants.PATH_TO_LOS_FOLDER + @"\src\Los.ClientPortal\Web\Los.ClientPortal.Web\ClientApp";

            var RunClientPortalUI = new ProcessStartInfo
            {
                FileName = "cmd",
                RedirectStandardInput = true,
                WorkingDirectory = ClientPortalPath,
                UseShellExecute = false,
                CreateNoWindow = false
            };
            var pRunClientPortalUI = Process.Start(RunClientPortalUI);
            pRunClientPortalUI.StandardInput.WriteLine("ng serve --port 3001");
            pRunClientPortalUI.WaitForExit();
        }
    }
}
