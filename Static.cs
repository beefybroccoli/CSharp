using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp
{
    class Static
    {
        public static int FeetToInch(int inputInch)
        {
            Console.WriteLine("public static int FeetToInch was called.");
            int result = -2;

            if (inputInch <= 0)
            {
                result = 0;
            }
            else
            {
                result = inputInch * 12;
            }

            return result;
        }    
    }

    class NonStatic
    {
        public NonStatic()
        {

        }

        public int FeetToInch(int inputInch)
        {
            Console.WriteLine("public int FeetToInch was called.");
            int result = -2;

            if (inputInch <= 0)
            {
                result = 0;
            }
            else
            {
                result = inputInch * 12;
            }

            return result;
        }


    }
}


/*
 static member are access through class, not throgh object
*/