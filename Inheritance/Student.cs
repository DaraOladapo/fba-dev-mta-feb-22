namespace Inheritance
{
    public partial class Program
    {
        class Student : Person
        {
            public double Tuition { get; set; }
            public Teacher Teacher { get; set; }
            
        }
    }
}