using System;

namespace PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Celso","Guido");
            //person.birthdate = new Date(11,29,2000);

            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
            /*person.birthdate.displayDate();*/
        }
    }

    public class Person
    {

        private string firstName;

	public string FirstName
	{
		get { return firstName;}
		set { firstName = value;}
	}
        private string lastName;

	public string LastName
	{
		get { return lastName;}
		set { lastName = value;}
	}

      /*  private Date dateOfBirth;

	public Date DateOfBirth
	{
		get { return dateOfBirth;}
		set { dateOfBirth = value;}
	}



        /*public string fName;
        public string lName;
        public Date birthdate;*/
 

        public Person(){
            
        }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }  
    }

   /* public class Date
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
    }*/
}
