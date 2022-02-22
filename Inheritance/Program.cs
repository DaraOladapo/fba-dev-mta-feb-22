namespace Inheritance
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            Dean dean = new Dean()
            {
                FirstName = "Jack",
                LastName = "Doe",
                Salary = 2000,
                EmailAddress = "jack@doe.com",
                Faculty = Faculty.Science,
                OfficeNumber = "C-123"
            };
            Teacher teacher = new Teacher()
            {
                FirstName = "John",
                LastName = "Doe",
                Salary = 1000,
                EmailAddress = "jon@doe.com",
                Faculty = Faculty.Science
            };
            Student student = new Student()
            {
                FirstName = "Jane",
                LastName = "Doe",
                Tuition = 500,
                EmailAddress = "jane@doe.com",
                Faculty=Faculty.Science

            };
        }
    }
}