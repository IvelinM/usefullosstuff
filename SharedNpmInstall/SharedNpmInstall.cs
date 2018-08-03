using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedNpmInstall
{
    class SharedNpmInstall
    {
        static void Main(string[] args)
        {
            string ApplicationPath = @"C:\IVELIN\PROJECTS\LOS\src\Common\Los.Shared.UI";
            string nodeModules = @"C:\IVELIN\PROJECTS\LOS\src\Common\Los.Shared.UI\node_modules";
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
