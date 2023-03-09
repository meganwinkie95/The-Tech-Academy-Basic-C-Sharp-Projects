using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1
{
    class Methods
    {
        static void Main(string[] args)
        {
            // Call the constructor that has no parameters.
            Console.WriteLine("Pick a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            Numbers y = new Numbers();
            Numbers T = new Numbers();
            Numbers R = new Numbers();
            int solution3 = R.mult(number);
            int solution2 = T.sub(number);
            int solution1 = y.add(number);
            Console.WriteLine(solution1);
            Console.WriteLine(solution2);
            Console.WriteLine(solution3);
            Console.ReadLine();
        }
         
    }
}
