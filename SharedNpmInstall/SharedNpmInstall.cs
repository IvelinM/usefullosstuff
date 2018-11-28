using Common;
using System.Diagnostics;
using System.IO;

namespace SharedNpmInstall
{
    class SharedNpmInstall
    {
        static void Main(string[] args)
        {
            string SharedPath = Constants.PATH_TO_LOS_FOLDER + @"\src\Common\Los.Shared.UI";
            string nodeModules = SharedPath + "\node_modules";
            var RunApplicationUI = new ProcessStartInfo
            {
                FileName = "cmd",
                RedirectStandardInput = true,
                WorkingDirectory = SharedPath,
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
