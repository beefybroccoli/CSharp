using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp
{
    class Employee
    {
        public Employee()
        {
            Income = 1000;
            YearsOfService = 1;
            SetRating(Employee.Rating.unrated);
        }

        public Employee(int annualSalary)
        {
            Income = annualSalary;
            YearsOfService = 1;
            SetRating(Employee.Rating.unrated);
        }

        public enum Rating
        {
            unrated, poor, good, excellent
        }

        private Rating rating;

        public string FirstName { get; set; }
        
        public string MiddleName { get; set; }

        public string LastName { get; set; }
        
        public string Office { get; set; }

        public double Income { get; set; }

        public int YearsOfService { get; set; }

        public void SetRating (Rating rating)
        {
            this.rating = rating;
        }

        public void CalculateRaise()
        {
            double baseRaise = Income * 0.05;
            double bonous = YearsOfService * 1000;
            Income += baseRaise + bonous;

            switch (rating)
            {
                case Rating.unrated:
                    break;
                case Rating.poor:
                    Income -= YearsOfService * 2000;
                    break;
                case Rating.good:
                    break;
                case Rating.excellent:
                    Income += YearsOfService * 500;
                    break;
            }

            Console.WriteLine($"New income is {Income}");
        }
    }
    


}
