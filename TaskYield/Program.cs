using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskYield
{
    class Program
    {
        static void Main(string[] args)
        {
            CallTaskYieldMethod();
            Console.WriteLine("Main Method End");
            Console.ReadLine(); 
        }

        private static async void CallTaskYieldMethod()
        {
            await Task.Yield();
            DoLongRunningTask();

        }

        private static void DoLongRunningTask()
        {
            for (int i = 0; i < 999999999; i++)
            {

            }

            Console.WriteLine("Long Running task Ended");
        }
    }
}
