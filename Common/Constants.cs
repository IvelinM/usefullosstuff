using System.IO;
using System.Reflection;

namespace Common
{
    public static class Constants
    {
        // Change as per your local usage:
        public static string PATH_TO_LOS_FOLDER = @"C:\IVELIN\PROJECTS\LOS";

        public static string DATABASES_PATH = @"C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA";

        public static string APPLICATION_DATABASE_NAME = "LOS";
        public static string CLIENT_PORTAL_DATABASE_NAME = "LOS.ClientPortal";
        public static string RATES_DATABASE_NAME = "LOS.Rates";
        public static string FEES_DATABASE_NAME = "LOS.Fees";
        
        public static string SQL_SERVER_NAME = "IMATEV10";
        public static string SQL_USER_YOU_USE_FOR_LOS = "los";
        public static string SQL_USERS_PASSWORD_FOR_LOS_USER = "los";

        // Do not change
        public static string PATH_TO_THIS_SOLUTION = Path.GetFullPath(Path.Combine(Assembly.GetExecutingAssembly().Location, "../../../../"));
    }
}
