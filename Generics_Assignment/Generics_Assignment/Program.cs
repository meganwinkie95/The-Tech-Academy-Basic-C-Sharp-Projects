using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    
        public enum DaysoftheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What day is it?");
                string day1 = Convert.ToString(Console.ReadLine());
                DaysoftheWeek day2 = (DaysoftheWeek)Enum.Parse(typeof(DaysoftheWeek), day1);

                Console.WriteLine(day2);
                //using Parse on DaysoftheWeek to go through enum
            }
            catch
            {
                Console.WriteLine("Pick a day of the week");
            }
            Console.ReadLine();

        }
    }
}
