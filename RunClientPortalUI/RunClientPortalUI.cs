using System.Diagnostics;

namespace RunClientPortalUI
{
    class RunClientPortalUI
    {
        static void Main(string[] args)
        {
            string ClientPortalPath = @"C:\IVELIN\PROJECTS\LOS\src\Web\Los.ClientPortal.UI";

            var RunClientPortalUI = new ProcessStartInfo
            {
                FileName = "cmd",
                RedirectStandardInput = true,
                WorkingDirectory = ClientPortalPath,
                UseShellExecute = false,
                CreateNoWindow = false
            };
            var pRunClientPortalUI = Process.Start(RunClientPortalUI);
            pRunClientPortalUI.StandardInput.WriteLine("npm start");
            pRunClientPortalUI.WaitForExit();
        }
    }
}
