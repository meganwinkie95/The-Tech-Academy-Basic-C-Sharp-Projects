
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_assignment
{
   interface IQuittable
    {
        void Quit();
    }
    public class Employee : IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("Welcome Employee");
        }
    }

    public class Program
    {

        static void Main()
        {
            Employee name = new Employee();
            name.Quit();
            Console.ReadLine();
        }
        
    }
}

