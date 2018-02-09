using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CsharpVersionSixAsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task.Factory.StartNew(() => GetSite());
            //diffrence
            GetSite();
            Console.WriteLine("Waiting....");
            ReadLine();
        }

        private async static Task GetSite()
        {
            HttpClient client = new HttpClient();
            try
            {
                var result = await client.GetStringAsync("http://www.facebook.com"); //create worker thread
                WriteLine(result);
            }
            catch (Exception exception)
            {
                //try
                //{
                //    //This asynchronous request will be invoked 
                //    // if the first request is failed. 
                //    var result = await client.GetStringAsync
                //                 ("http://www.easywcf.com");
                //    WriteLine(result);
                //}
                //catch
                //{
                //    WriteLine("Entered Catch Block");
                //}
                //finally
                //{
                //    WriteLine("Entered Finally Block");
                //}
                var result = await client.GetStringAsync
                                 ("http://www.easywcf.com");
                WriteLine(result);
            }
        }
    }
}
