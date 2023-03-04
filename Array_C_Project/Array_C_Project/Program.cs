using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] arg)
        {
        List<string> intList = new List<string>();
        intList.Add("Hello");
        intList.Add("Hi");
        intList.Add("Hey");
        Console.WriteLine("Select index 0,1,2?");
        int greet = Convert.ToInt32(Console.ReadLine());
        if (2 < greet)
        {
            Console.WriteLine("index not available");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine(intList[greet]);
            Console.ReadLine();
            int[] numArray = new int[5];
            numArray[0] = 5;
            numArray[1] = 7;
            numArray[2] = 9;
            Console.WriteLine("Select index 0,1,2?");
            int numb = Convert.ToInt32(Console.ReadLine());
            if (2 < numb)
            {
                Console.WriteLine("index not available");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(numArray[numb]);
                Console.ReadLine();
            }

        }
    
    }

}
