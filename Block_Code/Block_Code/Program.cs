using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            /*variable decleration*/
            int multiply, divide;
            int userInput;
            multiply = 192;
            divide = 16;

            /*getting user input*/
            Console.WriteLine("Length of shower in minutes:");

            userInput = int.Parse(Console.ReadLine());

            int numBottlesMinute = multiply / divide;

            Console.WriteLine("The amount of water used is:" + userInput * numBottlesMinute);
            if(userInput > 15)
            {
                Console.WriteLine("Take a shorter shower");
            }
            else
            {
                Console.WriteLine("Good job taking a shorter shower");
            }
            Console.ReadLine();

        }
    }
}
