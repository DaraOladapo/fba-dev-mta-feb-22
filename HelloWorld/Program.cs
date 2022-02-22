using System;
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args){
            bool eligible;
            int age;
            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            eligible = (age >= 18);
            while (eligible)
            {
                Console.WriteLine("Runs because eligible is true");
                eligible = false;
            }

            do
            {
                Console.WriteLine("Runs anyways.");
                eligible = false;
            } while (eligible);

        for (var i = 5; i <= 100; i+=5)
        {
            Console.WriteLine(i);
        }
        
        string[] names = {"John", "Jane", "Joe", "Jack", "Jill", "Jenny", "Jared"};
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        for (var i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
        }
    }
}