using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void MyMethod(int k, int x = 2)
        {
            Console.WriteLine(k + x);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a number(optional)");
            string num2 = (Console.ReadLine());
            if (num2 == "")
            {
                MyMethod(num1);
            }
            else
            {
                int y = Convert.ToInt32(num2);
                MyMethod(num1, y);
            }
            Console.ReadLine();

        }
    }
}
