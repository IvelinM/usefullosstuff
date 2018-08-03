using System.Diagnostics;
using System.IO;

namespace ApplicationNpmInstall
{
    class ApplicationNpmInstall
    {
        static void Main(string[] args)
        {
            string ApplicationPath = @"C:\IVELIN\PROJECTS\LOS\src\Los.Application\Web\Los.Application.UI";
            string nodeModules = @"C:\IVELIN\PROJECTS\LOS\src\Los.Application\Web\Los.Application.UI\node_modules";
            var RunApplicationUI = new ProcessStartInfo
            {
                FileName = "cmd",
                RedirectStandardInput = true,
                WorkingDirectory = ApplicationPath,
                UseShellExecute = false,
                CreateNoWindow = false
            };
            var pRunApplicationUI = Process.Start(RunApplicationUI);
            try
            {
                Directory.Delete(nodeModules, true);
            }
            catch (System.Exception)
            {
            }
            pRunApplicationUI.StandardInput.WriteLine("npm install");
            pRunApplicationUI.WaitForExit();
        }
    }
}
