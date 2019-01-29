using Common;
using System.Diagnostics;

namespace XComRunners
{
    class StartXComRunners
    {
        static void Main(string[] args)
        {
            //Process.Start(Constants.PATH_TO_LOS_FOLDER + @"\src\Los.Application\Infrastructure\Los.Application.XCom.Runner\bin\Debug\Los.Application.XCom.Runner.exe");
            //Process.Start(Constants.PATH_TO_LOS_FOLDER + @"\src\Los.ClientPortal\Infrastructure\Los.ClientPortal.XCom.Runner\bin\Debug\Los.ClientPortal.XCom.Runner.exe");
            //Process.Start(Constants.PATH_TO_LOS_FOLDER + @"\src\Microservices\Los.LoanFees\Infrastructure\Los.LoanFees.XCom.Runner\bin\Debug\Los.LoanFees.XCom.Runner.exe");
            //Process.Start(Constants.PATH_TO_LOS_FOLDER + @"\src\Microservices\Los.LoanRates\Infrastructure\Los.LoanRates.XCom.Runner\bin\Debug\Los.LoanRates.XCom.Runner.exe");
            //Process.Start(Constants.PATH_TO_LOS_FOLDER + @"\src\Microservices\Los.PFNET.Listener\Infrastructure\Los.PFNET.Listener.XCom.Runner\bin\Debug\Los.PFNET.Listener.XCom.Runner.exe");

            Process.Start(Constants.PATH_TO_THIS_SOLUTION + @"04-01-ApplicationXComRunner\bin\Debug\04-01-ApplicationXComRunner.exe");
            Process.Start(Constants.PATH_TO_THIS_SOLUTION + @"04-02-ClientPortalXComRunner\bin\Debug\04-02-ClientPortalXComRunner.exe");
            Process.Start(Constants.PATH_TO_THIS_SOLUTION + @"04-03-FeesXComRunner\bin\Debug\04-03-FeesXComRunner.exe");
            Process.Start(Constants.PATH_TO_THIS_SOLUTION + @"04-04-RatesXComRunner\bin\Debug\04-04-RatesXComRunner.exe");
        }
    }
}
