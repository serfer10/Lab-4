using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Ram
{
    class TaskManager
    {
        public static string ComputerName
        {
            get
            {
                return $"Machine name: <{Environment.MachineName}>";
            }
        }

        public static string OSVersion
        {
            get
            {
                return $"OS version: <{Environment.OSVersion}>";
            }
        }
        public static string UserName
        {
            get
            {
                return $"User name: <{Environment.UserName}>";
            }
        }
        public static string ProcessActiveNow
        {
            get
            {
                List<string> processes = new List<string>();

                foreach (var process in Process.GetProcesses())
                {
                    processes.Add(process.ProcessName);
                }

                string result = "Active processes:\n\n";

                foreach (var processName in processes)
                {
                    result += processName + "\n";
                }
                return result;
            }
        }
    }
}
