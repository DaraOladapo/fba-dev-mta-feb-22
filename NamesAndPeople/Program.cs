namespace NamesAndPeople
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //create new instance of person
            Person person = new Person();
            person.FirstName = "John";
            person.MiddleName = "Michael";
            person.LastName = "Smith";
            Console.WriteLine($"Name in initials: {person.GetNameInInitials()}");
            Console.WriteLine($"Name in full: {person.GetFullName()}");
        }   
    }
    //create class Person
    public class Person{
        //create fields
        public string FirstName;
        public string MiddleName{ get; set; }
        public string LastName{ get; set; }

        //create readonly field
        public string Initials
        {
            get { return $"{FirstName[0]}.{MiddleName[0]}."; }
        }
        //get initials
        public string GetNameInInitials()
        {
            return $"{Initials} {LastName}";
        }  
        //get full name  
        public string GetFullName()
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }    
    }
}