using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorph
{ 

        class Animal  // Base class (parent) 
    {
            public void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
                Console.ReadLine();
            }
        }

        class Pig : Animal  // Derived class (child) 
        {
            public void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
                Console.ReadLine();
        }
        }

        class Dog : Animal  // Derived class (child) 
        {
            public void animalSound()
            {
                Console.WriteLine("The dog says: bow wow");
                Console.ReadLine();
        }
      
        }

        class Program
        {
            static void Main(string[] args)
            {
                Animal myAnimal = new Animal();  // Create a Animal object
                Animal myPig = new Pig();  // Create a Pig object
                Animal myDog = new Dog();  // Create a Dog object

                myAnimal.animalSound();
                myPig.animalSound();
                myDog.animalSound();

        }
    }
}
