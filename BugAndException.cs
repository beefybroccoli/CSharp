using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp
{
    class BugAndException
    {

        public static int divide(int a, int b)
        {
            int result = -2;

            try
            {
                result = a / b;
                
            } catch {
                Console.WriteLine("Divide by zero exception");
                result = Common.EXPECTION_ERROR_CODE();
            } finally {
               
            }

            return result;
        }

        public static void fileException()
        {
            try
            {


                Console.WriteLine("opening file....");

                Common obj = new Common();
                
                if (obj.get_random_boolean())
                {
                    throw new System.Exception();
                    Console.WriteLine("Handle Exception");
                }


            }
            catch
            {

                
            }
            finally
            {
                Console.WriteLine("closing file...");
            }
        }

    }
}

/*
    Exception : things go wrong at runtime
        the base is System.Exception
        caused by object

        call stack i sthe list of methods that called methods


    Bug :
*/