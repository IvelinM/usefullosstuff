using Common;
using System.Diagnostics;
using System.IO;

namespace ClientPortalNpmInstall
{
    class ClientPortalNpmInstall
    {
        static void Main(string[] args)
        {
            string ClientPortalPath = Constants.PATH_TO_LOS_FOLDER + @"\src\Los.ClientPortal\Web\Los.ClientPortal.Web\ClientApp";
            string nodeModules = ClientPortalPath + "\node_modules";

            var RunClientPortalUI = new ProcessStartInfo
            {
                FileName = "cmd",
                RedirectStandardInput = true,
                WorkingDirectory = ClientPortalPath,
                UseShellExecute = false,
                CreateNoWindow = false
            };
            var pRunClientPortalUI = Process.Start(RunClientPortalUI);
            try
            {
                Directory.Delete(nodeModules, true);
            }
            catch (System.Exception)
            {
            }
            pRunClientPortalUI.StandardInput.WriteLine("npm install");
            pRunClientPortalUI.WaitForExit();
        }
    }
}
