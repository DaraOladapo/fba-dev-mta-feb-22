using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            AcceptInput();
        }
        static void AcceptInput()
        {
            //try
            //{
            //    int userInput = int.Parse(Console.ReadLine());
            //    if (userInput >= 0)
            //    {
            //        Console.WriteLine($"{userInput}!={Factorial(userInput)}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry, you put a negative number. Try again with a positive number.");
            //        AcceptInput();
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("Sorry, you put in a non-whole number or string. Try again with a whole number");
            //    AcceptInput();
            //}
            int userParsedValue;
            var userInput = int.TryParse(Console.ReadLine(), out userParsedValue);
            if (userInput)
            {
                if (userParsedValue >= 0)
                {
                    Console.WriteLine($"{userParsedValue}!={Factorial(userParsedValue)}");
                }
                else
                {
                    Console.WriteLine("Sorry, you put a negative number. Try again with a positive number.");
                    AcceptInput();
                }
            }
            else
            {
                Console.WriteLine("Sorry, your value was not expected.");
                AcceptInput();
            }

        }
        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
