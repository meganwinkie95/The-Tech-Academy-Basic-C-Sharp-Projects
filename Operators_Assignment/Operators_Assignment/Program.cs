
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Continue4
{
    public class Employee
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int ID { get; set; }

        public void SayName(string x, string y, int k)
        {
            Console.WriteLine("Name: " + x + " " + " " + y + " " + k);
            Console.ReadLine();
        }
        public static bool operator== (Employee x, Employee y)
        {
            return x.ID == y.ID;
        }
        public static bool operator !=(Employee x, Employee y)
        {
            return x.ID != y.ID;
        }

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

            Employee name1 = new Employee();
            name1.FName = "sample";
            name1.LName = "student";
            name1.ID = 2;
            name1.SayName(name1.FName, name1.LName, name1.ID);
            Console.WriteLine(name1 == name);
            Console.ReadLine();
        }
    }
}