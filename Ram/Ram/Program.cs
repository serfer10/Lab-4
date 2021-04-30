using System;

namespace Ram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TaskManager.ComputerName);
            Console.WriteLine(TaskManager.UserName);
            Console.WriteLine(TaskManager.OSVersion);
            Console.WriteLine(TaskManager.ProcessActiveNow);
        }
    }
}
