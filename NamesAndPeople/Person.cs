namespace NamesAndPeople
{
    //create class Person
    public class Person{
        //create fields
        public string FirstName;
        private string MiddleName{ get; set; }
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