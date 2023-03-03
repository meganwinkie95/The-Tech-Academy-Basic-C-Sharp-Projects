using System;

namespace Bool_project
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ever had a DUI, True or False");
            bool myBool = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int ticket = Convert.ToInt32(Console.ReadLine());
            if (age < 15 || ticket >= 3 || myBool != true);
            {
                Console.WriteLine("unqualified");
                Console.ReadLine();
            }
          
        }
    }
}
