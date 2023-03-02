using System;

    class Program
    {
        static void Main()
    {
        Console.WriteLine("The Tech Academy");
        Console.ReadLine();
        Console.WriteLine("Student Daily Report");
        Console.ReadLine();
        Console.WriteLine("What is your name?");
        String yourname = Console.ReadLine();
        Console.WriteLine("What course are you on?");
        String coursename = Console.ReadLine();
        Console.WriteLine("What page number?");
        int page = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Do you need help with anything ? Please answer “true” or “false.”");
        bool myBool = Convert.ToString(Console.ReadLine());
        Console.WriteLine(Convert.ToString(myBool));// Convert bool to string
        Console.WriteLine("Were there any positive experiences you’d like to share ? Please give specifics.");
        String experience = Console.ReadLine();
        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        String feedback = Console.ReadLine();
        Console.WriteLine("How many hours did you study today?");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.ReadLine();


    }
}
