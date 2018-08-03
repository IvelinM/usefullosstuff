using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XComRunners
{
    class StartXComRunners
    {
        static void Main(string[] args)
        {
            Process.Start("C:\\IVELIN\\PROJECTS\\LOS\\src\\Los.ClientPortal\\Infrastructure\\Los.ClientPortal.XCom.Runner\\bin\\Debug\\Los.ClientPortal.XCom.Runner.exe");
            Process.Start("C:\\IVELIN\\PROJECTS\\LOS\\src\\Los.Application\\Infrastructure\\Los.Application.XCom.Runner\\bin\\Debug\\Los.Application.XCom.Runner.exe");
        }
    }
}
