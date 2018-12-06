using Common;
using Newtonsoft.Json;
using System.IO;
namespace RenameConnectionStrings
{
    class RenameConnectionStrings
    {
        static void Main(string[] args)
        {
            // Los.Application.WebAPI
            string stringsPathLosApplicationWebApi = Constants.PATH_TO_LOS_FOLDER + @"\src\Los.Application\Web\Los.Application.Web\appsettings.Development.json";
            string losApplicationJson = File.ReadAllText(stringsPathLosApplicationWebApi);
            dynamic losApplicationJsonObj = JsonConvert.DeserializeObject(losApplicationJson);
            losApplicationJsonObj["ConnectionStrings"]["DefaultConnection"] = "Data Source=" + Constants.SQL_SERVER_NAME + ";Initial Catalog=" + Constants.APPLICATION_DATABASE_NAME + ";User Id=" + Constants.SQL_USER_YOU_USE_FOR_LOS + ";Password=" + Constants.SQL_USERS_PASSWORD_FOR_LOS_USER;
            File.WriteAllText(stringsPathLosApplicationWebApi, JsonConvert.SerializeObject(losApplicationJsonObj, Formatting.Indented));

            // Los.Application.XCom.Runner
            string stringsPathLosApplicationXComRunner = Constants.PATH_TO_LOS_FOLDER + @"\src\Los.Application\Infrastructure\Los.Application.XCom.Runner\ConnectionStrings.Dev.config";
            File.WriteAllText(stringsPathLosApplicationXComRunner, "<?xml version=\"1.0\"?>\r\n<connectionStrings>\r\n  <clear/>\r\n  <add name=\"DefaultConnection\" connectionString=\"Data Source=" + Constants.SQL_SERVER_NAME + ";Initial Catalog=LOS;Persist Security Info=True;User ID=" + Constants.SQL_USER_YOU_USE_FOR_LOS + ";Password=" + Constants.SQL_USERS_PASSWORD_FOR_LOS_USER + "\" providerName=\"System.Data.SqlClient\" />\r\n</connectionStrings>\r\n");

            // Los.ClientPortal.WebAPI
            string stringsPathLosClientPortalWebApi = Constants.PATH_TO_LOS_FOLDER + @"\src\Los.ClientPortal\Web\Los.ClientPortal.Web\appsettings.Development.json";
            string losClientPortalJson = File.ReadAllText(stringsPathLosApplicationWebApi);
            dynamic losClientPortalJsonObj = JsonConvert.DeserializeObject(losApplicationJson);
            losClientPortalJsonObj["ConnectionStrings"]["DefaultConnection"] = "Data Source=" + Constants.SQL_SERVER_NAME + ";Initial Catalog=" + Constants.CLIENT_PORTAL_DATABASE_NAME + ";User Id=" + Constants.SQL_USER_YOU_USE_FOR_LOS + ";Password=" + Constants.SQL_USERS_PASSWORD_FOR_LOS_USER;
            File.WriteAllText(stringsPathLosClientPortalWebApi, JsonConvert.SerializeObject(losClientPortalJsonObj, Formatting.Indented));

            // Los.ClientPortal.XCom.Runner
            string stringsPathLosClientPortalXComRunner = Constants.PATH_TO_LOS_FOLDER + @"\src\Los.ClientPortal\Infrastructure\Los.ClientPortal.XCom.Runner\ConnectionStrings.Dev.config";
            File.WriteAllText(stringsPathLosClientPortalXComRunner, "<?xml version=\"1.0\"?>\r\n<connectionStrings>\r\n  <clear/>\r\n  <add name=\"DefaultConnection\" connectionString=\"Data Source=" + Constants.SQL_SERVER_NAME + ";Initial Catalog=LOS.ClientPortal;Persist Security Info=True;User ID=" + Constants.SQL_USER_YOU_USE_FOR_LOS + ";Password=" + Constants.SQL_USERS_PASSWORD_FOR_LOS_USER + "\" providerName=\"System.Data.SqlClient\" />\r\n</connectionStrings>\r\n");

            // Los.Fees.XCom.Runner
            string stringsPathLosFeesXComRunner = Constants.PATH_TO_LOS_FOLDER + @"\src\Microservices\Los.LoanFees\Infrastructure\Los.LoanFees.XCom.Runner\ConnectionStrings.Dev.config";
            File.WriteAllText(stringsPathLosFeesXComRunner, "<?xml version=\"1.0\"?>\r\n<connectionStrings>\r\n  <clear/>\r\n  <add name=\"DefaultConnection\" connectionString=\"Data Source=" + Constants.SQL_SERVER_NAME + ";Initial Catalog=LOS.Fees;Persist Security Info=True;User ID=" + Constants.SQL_USER_YOU_USE_FOR_LOS + ";Password=" + Constants.SQL_USERS_PASSWORD_FOR_LOS_USER + "\" providerName=\"System.Data.SqlClient\" />\r\n</connectionStrings>\r\n");

            // Los.Rates.XCom.Runner
            string stringsPathLoanRatesXComRunner = Constants.PATH_TO_LOS_FOLDER + @"\src\Microservices\Los.LoanRates\Infrastructure\Los.LoanRates.XCom.Runner\ConnectionStrings.Dev.config";
            File.WriteAllText(stringsPathLoanRatesXComRunner, "<?xml version=\"1.0\"?>\r\n<connectionStrings>\r\n  <clear/>\r\n  <add name=\"DefaultConnection\" connectionString=\"Data Source=" + Constants.SQL_SERVER_NAME + ";Initial Catalog=LOS.Rates;Persist Security Info=True;User ID=" + Constants.SQL_USER_YOU_USE_FOR_LOS + ";Password=" + Constants.SQL_USERS_PASSWORD_FOR_LOS_USER + "\" providerName=\"System.Data.SqlClient\" />\r\n</connectionStrings>\r\n");
        }
    }
}
