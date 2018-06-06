using System.Diagnostics;

namespace RunApplicationUI
{
    class RunApplicationUI
    {
        static void Main(string[] args)
        {
            string ApplicationPath = @"C:\IVELIN\PROJECTS\LOS\src\Web\Los.Application.UI";
            var RunApplicationUI = new ProcessStartInfo
            {
                FileName = "cmd",
                RedirectStandardInput = true,
                WorkingDirectory = ApplicationPath,
                UseShellExecute = false,
                CreateNoWindow = false
            };
            var pRunApplicationUI = Process.Start(RunApplicationUI);
            pRunApplicationUI.StandardInput.WriteLine("npm start");
            pRunApplicationUI.WaitForExit();
        }
    }
}
