using Common;
using System.Diagnostics;

namespace NpmInstallUIs
{
    class NpmInstallUIs
    {
        static void Main(string[] args)
        {
            Process.Start(Constants.PATH_TO_THIS_SOLUTION + @"\ClientPortalNpmInstall\bin\Debug\ClientPortalNpmInstall.exe");
            Process.Start(Constants.PATH_TO_THIS_SOLUTION + @"\ApplicationNpmInstall\bin\Debug\ApplicationNpmInstall.exe");
            Process.Start(Constants.PATH_TO_THIS_SOLUTION + @"\SharedNpmInstall\bin\Debug\SharedNpmInstall.exe");
        }
    }
}