using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp
{
    class Manager : Employee
    {


        public Manager()
            : base()
        {
            Income = 100000;
            YearsOfService = 10;
            SetRating(Employee.Rating.excellent);
        }

        public Manager(string assignment)
        {
            Income = 100000;
            YearsOfService = 10;
            SetRating(Employee.Rating.excellent);
            this.Assignment = assignment;
        }

        public String Assignment { set; get; }
    }
}
