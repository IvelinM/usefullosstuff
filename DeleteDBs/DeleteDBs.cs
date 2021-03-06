﻿using Common;
using System.Diagnostics;

namespace DeleteDBsAndUpdateDatabase
{
    class DeleteApplicationDB
    {
        static void Main(string[] args)
        {
            var databasesPath = Constants.DATABASES_PATH;
            var commandApplication = @"sqlcmd -S .\ -q ""alter database [" + Constants.APPLICATION_DATABASE_NAME + "] set single_user with rollback immediate drop database [" + Constants.APPLICATION_DATABASE_NAME + @"]""";
            var commandClientPortal = @"sqlcmd -S .\ -q ""alter database [" + Constants.CLIENT_PORTAL_DATABASE_NAME + "] set single_user with rollback immediate drop database [" + Constants.CLIENT_PORTAL_DATABASE_NAME + @"]""";
            var commandRates = @"sqlcmd -S .\ -q ""alter database [" + Constants.RATES_DATABASE_NAME + "] set single_user with rollback immediate drop database [" + Constants.RATES_DATABASE_NAME + @"]""";
            var commandFees = @"sqlcmd -S .\ -q ""alter database [" + Constants.FEES_DATABASE_NAME + "] set single_user with rollback immediate drop database [" + Constants.FEES_DATABASE_NAME + @"]""";

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
