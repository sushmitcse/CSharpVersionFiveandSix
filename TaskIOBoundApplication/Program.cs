using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskIOBoundApplication
{
    /// <summary>
    /// Version 5
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //GetHtmlAsync();

            //Console.ReadLine();
            Console.WriteLine("Main method Task Started...");
            var r = CallAsync();
           

            Console.WriteLine("Main method Task Complete...");
            Console.WriteLine("Waiting for result.........");
            Console.WriteLine(r.Result);
            Console.Read();

            //var t = new Func<Task<string>>(async() => { await SomeTAsk();  return ""; });
        }

        private static Task SomeTAsk()
        {
            throw new NotImplementedException();
        }

        public static async Task<string> CallAsync()
        {
            //var r = await Task.Run(() => GetFirstCharactersCountAsync(string.Empty, 30));

            var r = await GetFirstCharactersCountAsync(string.Empty, 30);
            Console.WriteLine("CallAsync started ...wait");
            return r;
        }

        //public static Task<string> GetHtmlAsync()
        //{
        //    // Execution is synchronous here
        //    var client = new HttpClient();

        //    return client.GetStringAsync("http://www.google.com");
        //}

        public static async Task<string> GetFirstCharactersCountAsync(string url, int count)
        {
            // Execution is synchronous here
            var client = new HttpClient();

            // Execution of GetFirstCharactersCountAsync() is yielded to the caller here
            // GetStringAsync returns a Task<string>, which is *awaited*
            Console.WriteLine("Long Running is waiting");

            var page = await LongrunningTask();

            //var page = await client.GetStringAsync("http://www.google.com");


            //// Execution resumes when the client.GetStringAsync task completes,
            //// becoming synchronous again.

            //if (count > page.Length)
            //{
            //    return page;
            //}
            //else
            //{
            //    return page.Substring(0, count);
            //}
            return page;
        }

        //private static Task<string> LongrunningTask()
        //{
        //    for (int i = 0; i < 9999999; i++)
        //    {

        //    }

        //    Console.WriteLine("Long Running Task done..");
        //    return Task.FromResult<string>("yy");
        //}
        private static Task<string> LongrunningTask()
        {
            for (int i = 0; i < 9999999; i++)
            {

            }

            Console.WriteLine("Long Running Task done..");
            return Task.FromResult<string>("yy");
           
          
        }
    }
}
