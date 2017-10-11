using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp
{
    class MethodsOverloading
    {

        /*
         the compiler when it is method overload by different in
            _number of paramemters
            _type of parameters
        */

        public double computeSalary(double initialSalary) {

            return 0; 
        }

        public double computeSalary(double initialSalary, string position)
        {
            return 0;
        }

        public double computeSalary(double initialSalary, int yearOfService)
        {
            return 0;
        }


    }
}
