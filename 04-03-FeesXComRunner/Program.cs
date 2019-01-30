using Common;
using System.Diagnostics;

namespace _04_03_FeesXComRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            string FeesXComRunnerPath = Constants.PATH_TO_LOS_FOLDER + @"\src\Microservices\Los.LoanFees\Infrastructure\Los.LoanFees.XCom.Runner";

            var RunFeesXComRunner = new ProcessStartInfo
            {
                FileName = "cmd",
                RedirectStandardInput = true,
                WorkingDirectory = FeesXComRunnerPath,
                UseShellExecute = false,
                CreateNoWindow = false
            };
            var pRunFeesXComRunner = Process.Start(RunFeesXComRunner);
            pRunFeesXComRunner.StandardInput.WriteLine("dotnet run");
            pRunFeesXComRunner.WaitForExit();
        }
    }
}
