using Common;
using System.Diagnostics;

namespace RunClientPortalCoreApp
{
    class RunClientPortalCoreApp
    {
        static void Main(string[] args)
        {
            string ApplicationPath = Constants.PATH_TO_LOS_FOLDER + @"\src\Los.Application\Web\Los.Application.Web";

            var RunApplicationNetCoreApp = new ProcessStartInfo
            {
                FileName = "cmd",
                RedirectStandardInput = true,
                WorkingDirectory = ApplicationPath,
                UseShellExecute = false,
                CreateNoWindow = false
            };
            var pRunApplicationNetCoreAppI = Process.Start(RunApplicationNetCoreApp);
            pRunApplicationNetCoreAppI.StandardInput.WriteLine("dotnet watch run");
            pRunApplicationNetCoreAppI.WaitForExit();
        }
    }
}
