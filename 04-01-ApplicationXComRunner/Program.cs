using Common;
using System.Diagnostics;

namespace _04_01_ApplicationXComRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            string ApplicationXComRunnerPath = Constants.PATH_TO_LOS_FOLDER + @"\src\Los.Application\Infrastructure\Los.Application.XCom.Runner";

            var RunApplicationXComRunner = new ProcessStartInfo
            {
                FileName = "cmd",
                RedirectStandardInput = true,
                WorkingDirectory = ApplicationXComRunnerPath,
                UseShellExecute = false,
                CreateNoWindow = false
            };
            var pRunApplicationXComRunner = Process.Start(RunApplicationXComRunner);
            pRunApplicationXComRunner.StandardInput.WriteLine("dotnet run");
            pRunApplicationXComRunner.WaitForExit();
        }
    }
}
