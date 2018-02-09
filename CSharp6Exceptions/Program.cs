using System;
using static System.Console;

namespace CSharp6Exceptions
{
    class Program
    {
        public struct paramlessstruct
        {
            public double X;
            public double Y;
            public paramlessstruct() //.net version 4.6.2 // Removed later from 6
            {
                X = 50.0;
                Y = 50.0;
            }
        }

        static void Main(string[] args)
        {
            //Bfore 6
            var httpStatusCode = 404;
            WriteLine("Abc");
            try
            {
                throw new Exception(httpStatusCode.ToString());
            }
            catch (Exception ex)
            {

                if (ex.Message.Equals("500"))
                    Write("Bad Request");
                else if (ex.Message.Equals("401"))
                    Write("Unauthorized");
                else if (ex.Message.Equals("402"))
                    Write("Exception Occurred");
                else if (ex.Message.Equals("403"))
                    Write("Forbidden");
                else if (ex.Message.Equals("404"))
                    Write("Not Found");
            }

            //Parameter

            try
            {
                throw new Exception(httpStatusCode.ToString());
            }
            catch (Exception ex) when (ex.Message.Equals("400"))
            {
                Write("Bad Request");
                ReadLine();
            }
            catch (Exception ex) when (ex.Message.Equals("401"))
            {
                Write("Unauthorized");
                ReadLine();
            }
            catch (Exception ex) when (ex.Message.Equals("402"))
            {
                Write("Exception Occurred ");
                ReadLine();
            }
        }
    }
}
