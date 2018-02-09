using System;
using System.Runtime.CompilerServices;

namespace CSharpCallerMemberAttribute
{
    /// <summary>
    /// C# 5
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ShowCallerInfo();
            Console.ReadKey();
        }

        //Only Applicable for  Defalut Param

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callerName"></param>
        public static void ShowCallerInfo([CallerMemberName] string callerName = null, 
            [CallerFilePath] string callerFilePath = null, 
            [CallerLineNumber] int callerLine = -1)
        {
            Console.WriteLine("CallerMemberName: " + callerName);
            Console.WriteLine("CallerFilePath: " + callerFilePath);
            Console.WriteLine("CallerLineNumber: " + callerLine);
        }

    }


    //public class EmployeeVM : INotifyPropertyChanged
    //{
    //    public event PropertyChangedEventHandler PropertyChanged;

    //    public void OnPropertyChanged([CallerMemberName] string propertyName = null)
    //    {
    //        if (PropertyChanged != null)
    //        {
    //            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    //        }
    //    }

    //    private string _name;

    //    public string Name
    //    {
    //        get { return _name; }
    //        set
    //        {
    //            _name = value;
    //            // The compiler converts the above line to:
    //            // RaisePropertyChanged ("Name");
    //        }
    //    }

    //    private string _phone;

    //    public string Phone
    //    {
    //        get { return _phone; }
    //        set
    //        {
    //            _phone = value;
    //            OnPropertyChanged(nameof(Phone));
    //            try
    //            {

    //            }
    //            catch (Exception e)
    //            {

    //                throw new ArgumentException(nameof(e));
    //            }
    //            // The compiler converts the above line to:
    //            // RaisePropertyChanged ("Phone");
    //        }
    //    }
    }
}
