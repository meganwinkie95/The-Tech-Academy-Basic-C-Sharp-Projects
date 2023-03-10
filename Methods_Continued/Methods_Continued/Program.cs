using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EnumExtension
{
    // Define an extension method in a non-nested static class.
    public class Numbers
    {
        public int add(int x)
        {
            return x + 2;
        }
        public double dec1(double i)
        {
            return i;
        }

        public int mult(int x)
        {
            return x * 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Call the constructor that has no parameters.
            Console.WriteLine("Pick a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a decimal number.");
            double dec = Convert.ToDouble(Console.ReadLine());
            Numbers y = new Numbers();
            Numbers T = new Numbers();
            Numbers R = new Numbers();
            int solution3 = R.mult(number);
            double solution2 = T.dec1(dec);
            int solution1 = y.add(number);
            Console.WriteLine(solution1);
            Console.WriteLine(solution2);
            Console.WriteLine(solution3);
            Console.ReadLine();
        }
        
    }
}
/* Output:
    First is a passing grade.
    Second is not a passing grade.

    Raising the bar!

    First is not a passing grade.
    Second is not a passing grade.
 */
