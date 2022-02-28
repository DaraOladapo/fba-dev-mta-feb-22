namespace NamesAndPeople
{
    public class Dog : Animal
    {
        public string Breed;
        public string GetBreed()
        {
            return $"{Breed}";
        }
    }
    public class Animal
    {
        public string FirstName;
        public string MiddleName { get; set; }
        protected string LastName { get; set; }
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