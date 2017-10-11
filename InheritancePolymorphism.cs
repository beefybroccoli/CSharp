using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp
{
    class Book
    {

        public Book(string Author, string Summary) {} 
        public virtual void toString() {}
        public void displaySummary() {Console.WriteLine("summary : " + Summary);}

        public string Author {get; set;}
        public string Summary { get; set; }
        public string ISBN { get; set; }
        public string Subject { get; set; }
        public string Title { get; set; }
    }

    class Fiction : Book
    {
        public Fiction (string title, string Author, string Summary, string ISBN)
           :base (Author, Summary)
        {
            this.Author = Author;
            this.Summary = Summary;
            this.ISBN = ISBN;
        }

        public override void toString()
        {
            string result = "fiction, " + "author" + base.Author + ", summary : " + base.Summary + "\n";
            Console.WriteLine(result);
        }


    }

    class NonFiction : Book
    {
        public NonFiction (string title, string Author, string Summary, string Subject)
            :base (Author, Summary)
        {
            this.Author = Author;
            this.Summary = Summary;
            this.Subject = Subject;
        }

        public override void toString()
        {
            string result = "non-fiction, " + "author" + base.Author + ", summary : " + base.Summary + "\n";
            Console.WriteLine(result);
        }
    }

}

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