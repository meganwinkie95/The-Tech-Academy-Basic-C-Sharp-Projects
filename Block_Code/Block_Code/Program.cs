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
            try
            {


                /*getting user input*/
                List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };
                Console.WriteLine("Dividing number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                foreach (var i in nums)
                {
                    Console.WriteLine(i / num2);
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please write a whole number");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by 0");
            }
            finally
            {
                Console.ReadLine();
            }
        }
            

        }
    }
