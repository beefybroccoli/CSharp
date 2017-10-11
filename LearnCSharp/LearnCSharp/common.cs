using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp
{
    class Common
    {
        enum ERROR_CODE
        {
            exception = -100
        }

        enum Ages
        {
            oldAge = 65,
            matureAdult = 30,
            youngAdult = 18,
            teenager = 15,
            todler = 5,
            infant = 1

        }

        enum Movie
        {
            JoeDirt,
            SpiderMan,
            Matrix
        }

        public static void demo_variable()
        {
            int age = 21;
            double pay = 25.99;
            var myName = "Jessy Bert";

            Console.WriteLine($"my age: {age}, my pay: {pay}, my name{myName}");
        }

        public static void demo_switch()
        {
            Movie bestMovie = Movie.Matrix;

            switch (bestMovie)
            {
                case Movie.JoeDirt:
                    Console.WriteLine("My favorite classic");
                    break;
                case Movie.Matrix:
                    Console.WriteLine("Hollywood should make a forth one.");
                    break;
                case Movie.SpiderMan:
                    Console.WriteLine("Plese stop make another spider man movie.");
                    break;
                default:
                    Console.WriteLine("I don't know about other");
                    break;
            }
        }

        static void demo_forloop()
        {
            for (int i = 0; i < 300; i++)
            {
                Console.WriteLine($"Hello at iteration {i.ToString()}");
            }
        }

        static void demo_if_condition()
        {
            int Rachael = 20;
            int Robin = 26;
            int Stacey = 54;
            int Jesse = 60;

            
            if (Rachael > 18)
            {
                Console.WriteLine("Rachel can vote");
            }

            if (Rachael >= 21 && Robin >= 21)
            {
                Console.WriteLine("Rachel and Robin can drink");
            }
            else if (Rachael >= 21 || Robin >= 21)
            {
                Console.WriteLine("At least one can drink");
            }
            
        }

        static void demo_enum()
        {
            int age = 20;

            if (age < (int)Ages.oldAge)
            {
                Console.WriteLine("Senior Citizen");
            }
            else if (age < (int)Ages.matureAdult)
            {
                Console.WriteLine("Mature Adult");
            }
            else if (age < (int)Ages.youngAdult)
            {
                Console.WriteLine("Young Adult");
            }
            else
            {
                Console.WriteLine("Young One");
            }
        }
        
        public static void NewLine()
        {
            Console.WriteLine();
        }

        public static int EXPECTION_ERROR_CODE()
        {
            return (int) ERROR_CODE.exception;
        }

        public static int get_random_number_between_0_and_1()
        {
            Random random = new Random();
            return random.Next(0, 100);
        }
        
        public Boolean get_random_boolean()
        {
            if (get_random_number_between_0_and_1() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
