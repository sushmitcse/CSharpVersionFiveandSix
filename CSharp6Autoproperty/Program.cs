using System;

namespace CSharp6Autoproperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee();
            Console.WriteLine(Emp.EmployeeID);
            //Console.ReadLine();

            //String Interpolation old techniques
            Customer cus = new Customer();
            cus.FirstName = "Sushmit";
            cus.LastName = "Goswami";
            cus.Email = "Sushmit.Goswami@outlook.com";
            cus.age = 28;
            Console.WriteLine("Name : " + cus.FirstName + " " + cus.LastName + "\nEmail : " + cus.Email);
            Console.WriteLine(string.Format("Name : {0} {1}\nEmail : {2}", cus.FirstName, cus.LastName, cus.Email));

            //new Interpolation
            Console.WriteLine($" {cus.FirstName} {cus.LastName} is my name"); // Any where u can use it, similar thing in ECMA6 binding
            Console.ReadLine();


            //Null Condition Operator
            var first = cus?.FirstName;

            var firstorUndefined = cus?.FirstName ?? "undefined";

            //old
            //var handler = this.SomethingHappened;
            //if (handler != null)
            //    handler(this, eventArgs);

            // preferred in C# 6:
           // this.SomethingHappened?.Invoke(this, eventArgs);
        }
    }

    //old 
    public class Employee
    {
        public Employee()
        {
            EmployeeID = Guid.NewGuid();
        }

        public Guid EmployeeID { get; set; }
    }

    //New Auto propertyInitializer 
    public class Employee1
    {
        public Guid EmployeeID1 { get; set; } = new Guid();
        public int MyProperty { get; set; };
    }






    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int age { get; set; }
    }
}
