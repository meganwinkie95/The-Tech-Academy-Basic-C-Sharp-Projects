using System;


namespace AnonymousIncomeComparisonProgram
{
    class IncomeCompair
    {
        static void Main()
        {

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person1");
            Console.ReadLine();
            Console.WriteLine("What is your hourly rate?");
            int hourly1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hour did you work?");
            int workhours1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person2");
            Console.ReadLine();
            Console.WriteLine("What is your hourly rate?");
            int hourly2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours did you work?");
            int workhours2 = Convert.ToInt32(Console.ReadLine());
            int salary1 = hourly1 * workhours1 * 52;
            Console.WriteLine("Annual salary of Person 1: " + salary1.ToString());
            Console.ReadLine();
            int salary2 = hourly2 * workhours2 * 52;
            Console.WriteLine("Annual salary of Person 2: " + salary2.ToString());
            Console.ReadLine();
            Console.WriteLine("Does Person 1 makes more money than Person 2?");
            Console.ReadLine();
            Console.WriteLine(salary1 > salary2);
            Console.ReadLine();
        }
    }
}
