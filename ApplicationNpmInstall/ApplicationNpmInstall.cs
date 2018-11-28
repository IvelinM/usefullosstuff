using Common;
using System.Diagnostics;
using System.IO;

namespace ApplicationNpmInstall
{
    class ApplicationNpmInstall
    {
        static void Main(string[] args)
        {
            string ApplicationPath = Constants.PATH_TO_LOS_FOLDER + @"\src\Los.Application\Web\Los.Application.Web\ClientApp";
            string nodeModules = ApplicationPath + "\node_modules";
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
