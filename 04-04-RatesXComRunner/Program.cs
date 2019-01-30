using Common;
using System.Diagnostics;

namespace _04_04_RatesXComRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            string RatesXComRunnerPath = Constants.PATH_TO_LOS_FOLDER + @"\src\Microservices\Los.LoanRates\Infrastructure\Los.LoanRates.XCom.Runner";

            var RunRatesXComRunner = new ProcessStartInfo
            {
                FileName = "cmd",
                RedirectStandardInput = true,
                WorkingDirectory = RatesXComRunnerPath,
                UseShellExecute = false,
                CreateNoWindow = false
            };
            var pRunRatesXComRunner = Process.Start(RunRatesXComRunner);
            pRunRatesXComRunner.StandardInput.WriteLine("dotnet run");
            pRunRatesXComRunner.WaitForExit();
        }
    }
}
