using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EnumExtension
{
    // Define multiple methods with the same name
    public class Numbers
    {
        public int add(int x)
        {
            return x + 2;
        }
        public int add(decimal i)
        {
            int y = Convert.ToInt32(i);
            return y - 6;
        }

        public int add(string x)
        {
            int y = Convert.ToInt32(x);
            return y * 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Call the methods
            Console.WriteLine("Pick a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a decimal.");
            decimal dec = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Pick a number.");
            string str = (Console.ReadLine());
            Numbers y = new Numbers();
            int solution3 = y.add(number);
            int solution2 = y.add(dec);
            int solution1 = y.add(str);
            Console.WriteLine(solution1);
            Console.WriteLine(solution2);
            Console.WriteLine(solution3);
            Console.ReadLine();
        }
        
    }
}
/* Output:
   
 */
