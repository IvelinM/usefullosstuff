using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameConnectionStrings
{
    class RenameConnectionStrings
    {
        static void Main(string[] args)
        {
            const string DEFAULT_CS = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Los;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\Los.mdf";
            const string CS_LOS_CHANGE = "Data Source=IMATEV10;Initial Catalog=LOS;Persist Security Info=True;User ID=los;Password=los";
            const string CS_LOS_clientPortal_CHANGE = "Data Source=IMATEV10;Initial Catalog=LOS.clientPortal;Persist Security Info=True;User ID=los;Password=los";
            const string CS_LOS_Fees_CHANGE = "Data Source=IMATEV10;Initial Catalog=LOS.Fees;Persist Security Info=True;User ID=los;Password=los";

            // Los.Application.WebAPI
            string stringsPathLosApplicationWebApi = @"C:\IVELIN\PROJECTS\LOS\src\Los.Application\Web\Los.Application.WebAPI\ConnectionStrings.Dev.config";
            string connectionStringsLosApplicationWebApi = File.ReadAllText(stringsPathLosApplicationWebApi);
            connectionStringsLosApplicationWebApi = connectionStringsLosApplicationWebApi.Replace(DEFAULT_CS, CS_LOS_CHANGE);
            File.WriteAllText(stringsPathLosApplicationWebApi, connectionStringsLosApplicationWebApi);

            // Los.Application.XCom.Runner
            string stringsPathLosApplicationXComRunner = @"C:\IVELIN\PROJECTS\LOS\src\Los.Application\Infrastructure\Los.Application.XCom.Runner\ConnectionStrings.Dev.config";
            string connectionStringsLosApplicationXComRunner = File.ReadAllText(stringsPathLosApplicationXComRunner);
            connectionStringsLosApplicationXComRunner = connectionStringsLosApplicationXComRunner.Replace(DEFAULT_CS, CS_LOS_CHANGE);
            File.WriteAllText(stringsPathLosApplicationXComRunner, connectionStringsLosApplicationXComRunner);

            // Los.ClientPortal.WebAPI
            string stringsPathLosClientPortalWebApi = @"C:\IVELIN\PROJECTS\LOS\src\Los.ClientPortal\Web\Los.ClientPortal.WebAPI\ConnectionStrings.Dev.config";
            string connectionStringsLosClientPortalWebApi = File.ReadAllText(stringsPathLosClientPortalWebApi);
            connectionStringsLosClientPortalWebApi = connectionStringsLosClientPortalWebApi.Replace(DEFAULT_CS, CS_LOS_clientPortal_CHANGE);
            File.WriteAllText(stringsPathLosClientPortalWebApi, connectionStringsLosClientPortalWebApi);

            // Los.ClientPortal.XCom.Runner
            string stringsPathLosClientPortalXComRunner = @"C:\IVELIN\PROJECTS\LOS\src\Los.ClientPortal\Infrastructure\Los.ClientPortal.XCom.Runner\ConnectionStrings.Dev.config";
            string connectionStringsLosClientPortalXComRunner = File.ReadAllText(stringsPathLosClientPortalXComRunner);
            connectionStringsLosClientPortalXComRunner = connectionStringsLosClientPortalXComRunner.Replace(DEFAULT_CS, CS_LOS_clientPortal_CHANGE);
            File.WriteAllText(stringsPathLosClientPortalXComRunner, connectionStringsLosClientPortalXComRunner);

            // Los.Fees.XCom.Runner
            string stringsPathLosFeesXComRunner = @"C:\IVELIN\PROJECTS\LOS\src\Microservices\Los.LoanFees\Infrastructure\Los.LoanFees.XCom.Runner\ConnectionStrings.Dev.config";
            string connectionStringsLosFeesXComRunner = File.ReadAllText(stringsPathLosFeesXComRunner);
            connectionStringsLosFeesXComRunner = connectionStringsLosFeesXComRunner.Replace(DEFAULT_CS, CS_LOS_Fees_CHANGE);
            File.WriteAllText(stringsPathLosFeesXComRunner, connectionStringsLosFeesXComRunner);
        }
    }
}
