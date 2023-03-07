﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_continued3
{ 
        class TheClass
        {
            public string willIChange;
        }

        struct TheStruct
        {
            public string willIChange;
        }

        class TestClassAndStruct
        {
            static void ClassTaker(TheClass c)
            {
                c.willIChange = "Changed";
            }

            static void StructTaker(TheStruct s)
            {
                s.willIChange = "Changed";
            }

            public static void Main()
            {
                TheClass testClass = new TheClass();
                TheStruct testStruct = new TheStruct();

                testClass.willIChange = "Not Changed";
                testStruct.willIChange = "Not Changed";

                ClassTaker(testClass);
                StructTaker(testStruct);

                Console.WriteLine("Class field = {0}", testClass.willIChange);
                Console.WriteLine("Struct field = {0}", testStruct.willIChange);

                // Keep the console window open in debug mode.
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
}