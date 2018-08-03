using System.Diagnostics;
using System.IO;

namespace ClientPortalNpmInstall
{
    class ClientPortalNpmInstall
    {
        static void Main(string[] args)
        {
            string ClientPortalPath = @"C:\IVELIN\PROJECTS\LOS\src\Los.ClientPortal\Web\Los.ClientPortal.UI";
            string nodeModules = @"C:\IVELIN\PROJECTS\LOS\src\Los.ClientPortal\Web\Los.ClientPortal.UI\node_modules";

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
