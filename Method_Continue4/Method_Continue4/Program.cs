
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Continue4
{
    public abstract class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }

       public abstract void SayName(string X, string y);

    }
    public class Employee : Person
    {
        public override void SayName(string x, string y) { 
            Console.WriteLine(x + " " + y);
            Console.ReadLine();
        }
    }

    public class Program
    {

        static void Main()
        {
            Employee name = new Employee();
           name.FName = "sample";
           name.LName = "student";
           name.SayName(name.FName, name.LName);
        }
    }
}



