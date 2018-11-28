using System.Diagnostics;

namespace DeleteDBsAndUpdateDatabase
{
    class DeleteApplicationDB
    {
        static void Main(string[] args)
        {
            var databasesPath = @"C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA";
            var commandApplication = @"sqlcmd -S .\ -q ""alter database [LOS] set single_user with rollback immediate drop database [LOS]""";
            var commandClientPortal = @"sqlcmd -S .\ -q ""alter database [LOS.clientPortal] set single_user with rollback immediate drop database [LOS.clientPortal]""";
            var commandRates = @"sqlcmd -S .\ -q ""alter database [LOS.Rates] set single_user with rollback immediate drop database [LOS.Rates]""";
            var commandFees = @"sqlcmd -S .\ -q ""alter database [LOS.Fees] set single_user with rollback immediate drop database [LOS.Fees]""";

            var removeApplicationDatabase = new ProcessStartInfo
            {
                FileName = "cmd",
                RedirectStandardInput = true,
                WorkingDirectory = databasesPath,
                UseShellExecute = false,
                CreateNoWindow = false
            };
            var removeClientPortalDatabase = new ProcessStartInfo
            {
                FileName = "cmd",
                RedirectStandardInput = true,
                WorkingDirectory = databasesPath,
                UseShellExecute = false,
                CreateNoWindow = false
            };
            var removeRatesDatabase = new ProcessStartInfo
            {
                FileName = "cmd",
                RedirectStandardInput = true,
                WorkingDirectory = databasesPath,
                UseShellExecute = false,
                CreateNoWindow = false
            };
            var removeFeesDatabase = new ProcessStartInfo
            {
                FileName = "cmd",
                RedirectStandardInput = true,
                WorkingDirectory = databasesPath,
                UseShellExecute = false,
                CreateNoWindow = false
            };
            var removeApplicationDatabaseProcess = Process.Start(removeApplicationDatabase);
            removeApplicationDatabaseProcess.StandardInput.WriteLine(commandApplication);

            var removeClientPortalDatabaseProcess = Process.Start(removeClientPortalDatabase);
            removeClientPortalDatabaseProcess.StandardInput.WriteLine(commandClientPortal);

            var removeRatesDatabaseProcess = Process.Start(removeRatesDatabase);
            removeRatesDatabaseProcess.StandardInput.WriteLine(commandRates);

            var removeFeesDatabaseProcess = Process.Start(removeFeesDatabase);
            removeFeesDatabaseProcess.StandardInput.WriteLine(commandFees);
        }
    }
}
