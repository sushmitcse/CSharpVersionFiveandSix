using System;
using System.Collections.Generic;
using static System.Console;

namespace CSharpVersionSix
{
    /// <summary>
    /// Version 6.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CreateDictionaryAndPrint();
            CreateDictionaryAndPrintwith6();

           
            ReadLine(); //--------------
        }

        private static void CreateDictionaryAndPrint()
        {
            //Throw exception if key is duplicate.
            Dictionary<int, string> oldDict = new Dictionary<int, string>() { { 1, "Sushmit" }, { 2, "Goswami" } };

            foreach (var item in oldDict)
            {
                Console.WriteLine("Key : " + item.Key.ToString());
                Console.WriteLine("Value : " + item.Value);
            }
        }

        private static void CreateDictionaryAndPrintwith6()
        {
            //overrite the key value
            Dictionary<int, string> oldDict = new Dictionary<int, string>() { [1] = "Sushmit6", [2] = "Goswami 6" };  // can create and initialize objects with indexes at the same time.
            foreach (var item in oldDict)
            {
                Console.WriteLine("Key : " + item.Key.ToString());
                Console.WriteLine("Value : " + item.Value);
            }


            //index initializer
            Dictionary<int, string> webErrors = new Dictionary<int, string>
            {
                [404] = "Page not Found",
                [302] = "Page moved, but left a forwarding address.",
                [500] = "The web server can't come out to play today."
            };
        }
    }
}
