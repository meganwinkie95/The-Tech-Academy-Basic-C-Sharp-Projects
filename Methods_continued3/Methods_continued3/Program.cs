using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_continued3
{ 
     class Method1
    {
       public void MyMethod(int k, out int x)
        {
           x = 1;
           x = k * x;
        }

        public void MyMethod(int k)
        {
            Console.WriteLine(k / 2);
        }

    }
    public static class otherclass
    {

    }
           
    class Program
    {

        static void Main(string[] args)
            {
                Console.WriteLine("Pick a number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Method1 y = new Method1();
                y.MyMethod(num1, out int x);
                y.MyMethod(num1);
                Console.WriteLine(x);
                Console.ReadLine();

            }
        }
 }