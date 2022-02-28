
namespace Casting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int myInt = 25;
            Console.WriteLine($"{myInt} is type {myInt.GetType()}");
            double myDouble = (double)myInt;
            Console.WriteLine($"{myDouble} is type {myDouble.GetType()}");
            //char myChar = 'd';
            //Console.WriteLine($"{myChar} is of type {myChar.GetType()}");
            //var myDouble = (double)myChar;
            //Console.WriteLine(myDouble);
            //if (myChar is double)
            //{
            //    var myDouble = (double)myChar;
            //    Console.WriteLine(myDouble);
            //}
            //object myInt = 25;
            //double myDouble = myInt as double;

        }
    }

}