using Common;
using System.Diagnostics;

namespace RunApplicationUI
{
    class RunApplicationUI
    {
        static void Main(string[] args)
        {
            string ApplicationPath = Constants.PATH_TO_LOS_FOLDER + @"\src\Los.Application\Web\Los.Application.Web\ClientApp";
            var RunApplicationUI = new ProcessStartInfo
            {
                FileName = "cmd",
                RedirectStandardInput = true,
                WorkingDirectory = ApplicationPath,
                UseShellExecute = false,
                CreateNoWindow = false
            };
            var pRunApplicationUI = Process.Start(RunApplicationUI);
            pRunApplicationUI.StandardInput.WriteLine("ng serve --port 3000");
            pRunApplicationUI.WaitForExit();
        }
    }
}
