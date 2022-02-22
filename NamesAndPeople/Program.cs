namespace NamesAndPeople
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "John";
            person.MiddleName = "Michael";
            person.LastName = "Smith";
            Console.WriteLine($"Name in initials: {person.GetNameInInitials()}");
            Console.WriteLine($"Name in full: {person.GetFullName()}");
        }   
    }
    public class Person{
        public string FirstName;
        public string MiddleName{ get; set; }
        public string LastName{ get; set; }
        public string Initials
        {
            get { return $"{FirstName[0]}.{MiddleName[0]}."; }
        }
        public string GetNameInInitials()
        {
            return $"{Initials} {LastName}";
        }    
        public string GetFullName()
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }    
    }
}