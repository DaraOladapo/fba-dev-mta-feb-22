namespace NamesAndPeople
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //create new instance of person
            Person person = new Person();
            person.FirstName = "John";
            //would not work because MiddleName is private
            person.MiddleName = "Michael";
            person.LastName = "Smith";
            Console.WriteLine($"Name in initials: {person.GetNameInInitials()}");
            Console.WriteLine($"Name in full: {person.GetFullName()}");

            //create new instance of animal
            Dog animal = new Dog();
            animal.FirstName = "Jack";
            //would not work because LastName is protected
            animal.LastName = "Black";
            Console.WriteLine(animal.FirstName);
        }   
    }
}