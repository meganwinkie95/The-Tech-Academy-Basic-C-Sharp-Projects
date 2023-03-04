using System;

namespace Package_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the package weight?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("your Package is too heavy");
            }
            else
            {
                Console.WriteLine("What is the package width?");
            }
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the package height?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the package length?");
            int length = Convert.ToInt32(Console.ReadLine());
            int x = width + height + length;
            int D = length * height * width * weight;
            int total = D / 100;
            if (x > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
            }
            else
            {

                Console.WriteLine("Your estimated total for shipping this package is: $" + total + ".00 Thank you");
            }
            Console.ReadLine();

        }
    }
}
