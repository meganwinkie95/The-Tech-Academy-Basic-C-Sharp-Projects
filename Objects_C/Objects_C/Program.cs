
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Continue4
{
    public class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }

        public void SayName(string x, string y, int k)
        {
            Console.WriteLine("Name: " + x + " " + " " + y + " " + k);
            Console.ReadLine();
        }

    }
    public class Employee : Person
    {
        public int ID { get; set; }
    }

    public class Program
    {

        static void Main()
        {
            Employee name = new Employee();
            name.FName = "sample";
            name.LName = "student";
            name.ID = 9;
            name.SayName(name.FName, name.LName, name.ID);
        }
    }
}
