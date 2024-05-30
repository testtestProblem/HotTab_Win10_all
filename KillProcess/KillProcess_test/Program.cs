using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillProcess_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //string dataChoose= args[0];
            string dataChoose= args[0];
            Console.WriteLine("[defult] Kill CollectDataAP\n" +
                "[process name] The process which want to kill");
            
            if (dataChoose == "") KillAllNotepadProcesses();
            else KillAllNotepadProcesses(dataChoose);
           
        }
        static void KillAllNotepadProcesses()
        {
            //string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            //System.Diagnostics.Process[] procs = System.Diagnostics.Process.GetProcessesByName("CollectDataAP", userName); // use "." for this machine
            //Console.WriteLine(userName, "  ", Environment.UserName);

            //string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            //System.Diagnostics.Process[] procs = System.Diagnostics.Process.GetProcessesByName("CollectDataAP", "."); // use "." for this machine
            //Console.WriteLine(userName+ "  "+Environment.UserName);

            //System.Diagnostics.Process[] procs = System.Diagnostics.Process.GetProcessesByName("CollectDataAP", Environment.UserName); // use "." for this machine

            System.Diagnostics.Process[] procs = System.Diagnostics.Process.GetProcessesByName("CollectDataAP"); // use "." for this machine

            foreach (var proc in procs)
                if (proc.Id != Process.GetCurrentProcess().Id) proc.Kill();
        }
        static void KillAllNotepadProcesses(string pid)
        {
            //string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            //System.Diagnostics.Process[] procs = System.Diagnostics.Process.GetProcessesByName("CollectDataAP", userName); // use "." for this machine
            //Console.WriteLine(userName, "  ", Environment.UserName);

            //string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            System.Diagnostics.Process[] procs = System.Diagnostics.Process.GetProcessesByName("CollectDataAP", "."); // use "." for this machine
            System.Diagnostics.Process[] procsExe = System.Diagnostics.Process.GetProcessesByName("CollectDataAP.exe", "."); // use "." for this machine

            //Console.WriteLine(userName+ "  "+Environment.UserName);

            //System.Diagnostics.Process[] procs = System.Diagnostics.Process.GetProcessesByName("CollectDataAP", Environment.UserName); // use "." for this machine

            //System.Diagnostics.Process[] procs = System.Diagnostics.Process.GetProcessesByName(data,"."); // use "." for this machine
            //foreach (var proc in procs) proc.Kill();

            foreach (var proc in procs)
                if (proc.Id != Int32.Parse(pid)) proc.Kill();

            foreach (var proc in procsExe)
                if (proc.Id != Int32.Parse(pid)) proc.Kill();
        }
    }
}
