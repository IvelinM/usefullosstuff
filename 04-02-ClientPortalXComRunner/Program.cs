using Common;
using System.Diagnostics;

namespace _04_02_ClientPortalXComRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            string ClientPortalXComRunnerPath = Constants.PATH_TO_LOS_FOLDER + @"\src\Los.ClientPortal\Infrastructure\Los.ClientPortal.XCom.Runner";

            var RunClientPortalXComRunner = new ProcessStartInfo
            {
                FileName = "cmd",
                RedirectStandardInput = true,
                WorkingDirectory = ClientPortalXComRunnerPath,
                UseShellExecute = false,
                CreateNoWindow = false
            };
            var pRunClientPortalXComRunner = Process.Start(RunClientPortalXComRunner);
            pRunClientPortalXComRunner.StandardInput.WriteLine("dotnet watch run");
            pRunClientPortalXComRunner.WaitForExit();
        }
    }
}
