using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main()
        {
            DateTime currTimeAndDate = DateTime.Now;
            Console.WriteLine("Today's time and date is {0}\n", currTimeAndDate);
            Console.WriteLine("Enter a number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            DateTime Xhours = currTimeAndDate.AddHours(y);
            Console.WriteLine(string.Format("{0} {1}", currTimeAndDate, Xhours));
            Console.ReadLine();
        }

        }
}
