using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Console_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] age = new int[2];
            string[] name = new string[2];
            int i, j = 0;
            string find;

            // Storing users name and age in two different array. 
            for (i = 0; i < 2; i++)
                //got rid of the < sign for the infinite loop
            {
                Console.Write("\n\nEnter your name:\t");
                name[i] = Console.ReadLine();
                Console.Write("Enter your age:\t\t");
                age[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Accepting name and find their correspondence age in array.

            Console.Write("\n\nEnter your name to find age:\t");
            find = Console.ReadLine();

            for (i = 0; i < 2; i++)
            {
                if (name[i] == find)
                {
                    Console.WriteLine("\n\nName\t:{0}", name[i]);
                    Console.WriteLine("Age\t:{0}", age[i]);
                    j++;
                }
            }
            if (j == 0)
            {
                Console.WriteLine("Not Found!!!");
            }
            Console.ReadLine();

            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int x, y;

            // Storing user input in arr1
            for (x = 0; x < 3; x++)
            {
                for (y = 0; y < 3; y++)
                {
                    Console.Write("Enter a value:\t");
                    arr1[x, y] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //copying value of arr1 to arr2
            for (x = 0; x < 3; x++)
            {
                for (y = 0; y < 3; y++)
                {
                    arr2[x, y] = arr1[x, y];
                }
            }

            Console.WriteLine("\n\nElements of second value are:\n\n");
            //Printing the arr2 value
            for (x = 0; x < 3; x++)
            {
                Console.WriteLine();
                for (y = 0; y < 3; y++)
                {
                    Console.Write("\t{0}", arr2[x, y]);
                }
            }
            
            Console.ReadLine();

            List<int> list = new List<int>() { 3, 5, 3, 2, 7, 7, 5, 6 };

            IEnumerable<int> duplicates = list.GroupBy(k => k)
                                                .Where(k => g.Count() > 1)
                                                .Select(k => k.Key);

            Console.WriteLine("Duplicate elements are: " + String.Join(",", duplicates));
         }
     }
}   

