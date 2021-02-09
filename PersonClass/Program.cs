using System;

namespace PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jr = new Person("Celso","Guido");
            jr.birthdate = new Date(11,29,2000);

            Console.WriteLine(jr.fName);
            Console.WriteLine(jr.lName);
            jr.birthdate.displayDate();
        }
    }

    public class Person
    {
        public string fName;
        public string lName;
        public Date birthdate;
        public Person(string fName, string lName)
        {
            this.fName = fName;
            this.lName = lName;
        }  
    }

    public class Date
    {
        public int month;
        public int day;
        public int year;

        public Date(int month, int day, int year)
        {
            this.month = month;
            this.day = day;
            this.year = year;
        }

        public void displayDate()
        {
            Console.WriteLine(month +"/"+day+"/"+year);
        }
    }
}
