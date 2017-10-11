using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp
{
    class program
    {     
        static void Main(string[] args)
        {
            Common.demo_switch();

            Employee tom = new Employee();
            tom.CalculateRaise();
            Console.WriteLine(tom.Income);
            Common.NewLine();

            Manager tony = new Manager();
            tony.Assignment = "supervise and raise sale for FY 2017";
            tony.CalculateRaise();
            Common.NewLine();
            

            //convert 5 feet to inches by access through class
            int inches = Static.FeetToInch(5);
            Console.WriteLine($"the inches : {inches}\n");


            //convert 5 feet to inches by access through object
            NonStatic nonStaticObject = new NonStatic();
            int inch2 = nonStaticObject.FeetToInch(5);
            Console.WriteLine($"the inches : {inch2}\n");

            //-----------------------------------------------------------------------------
            /*
                Inheritance
                    in base class, keyword 'virtual' is used
                        because the derived class will override this method
                    in derived class, keyword 'override' is used
                        because the derived class is expted to override toString method
                    in derived class, keyword 'based' is used
                        because the derived class inherent the constructor


                Polymorphism


                Encapsulation
                    each class should a singel area of responsibility
            */
            Fiction fiction = new Fiction("Kill the mocking bird", "unknown", "(require summary)", "123456");
            fiction.toString();
            NonFiction nonfiction = new NonFiction("Art of Science", "Tom", "(require summary)", "Chemistry");
            nonfiction.toString();
            fiction.displaySummary();
            nonfiction.displaySummary();
            Common.NewLine();

            //---------------------------------------------------
            /*
                bug and exception
            */
            BugAndException.fileException();
            BugAndException.fileException();


            for ( int  i =0; i < 10; i++)
            {
                Common obj = new Common();
                Console.WriteLine($"Random number : {obj.get_random_boolean()}");
            }
        }

    }
}