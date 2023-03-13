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


    }

    public class Program
    {

        // Main Method
        static void Main(string[] args)
        {
            // List with each element of type Student
            List<Employee> details = new List<Employee>() {
                new Employee{ ID = 1, FName = "Liza" },
                new Employee{ ID = 2, FName = "Stewart" },
                new Employee{ ID = 3, FName = "Tina" },
                new Employee{ ID = 4, FName = "Stefani" },
                new Employee{ ID = 5, FName = "Joe" },
                new Employee{ ID = 6, FName = "Liza" },
                new Employee{ ID = 7, FName = "Stewart" },
                new Employee{ ID = 8, FName = "Tina" },
                new Employee{ ID = 9, FName = "Stefani" },
                new Employee{ ID = 10, FName = "Joe" },
            
        };
            List<Employee> details2 = new List<Employee>();
            details2 = details.Where(x => x.FName == "Joe").ToList();
            Console.ReadLine();


            //var newDetails1 = details.OrderBy(x => x.FName);

            //foreach (var value in newDetails1)
            //{
            //    if (value.FName == "Joe")
            //    {
            //        Console.WriteLine(value.ID + " " + value.FName);
            //        Console.ReadLine();
            //    }
            //}


            //// To sort the details list
            //// based on name of student
            //// in ascending order
            List<Employee> newDetails = details.Where(x => x.ID > 5).ToList();

            //foreach (var value in newDetails)
            //{
            //    if(value.ID > 5)
            //    {
            //        Console.WriteLine(value.ID + " " + value.FName);
            //        Console.ReadLine();
            //    }
            //}


        }
    }
}
