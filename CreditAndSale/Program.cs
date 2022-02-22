using System;

namespace CreditAndSale
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is credit limit exceeded (Y/N)?");
            var creditLimitInput = Console.ReadLine();
            bool isCreditLimitExceeded = true;
            switch (creditLimitInput.ToLower())
            {
                case "y":
                    isCreditLimitExceeded = true;
                    break;
                case "n":
                    isCreditLimitExceeded = false;
                    break;
                default:
                    Console.WriteLine("Invalid input, please try again.");
                    break;
            }
            Console.WriteLine("Does user pay promptly (Y/N)?");
            var promptPaymentInput = Console.ReadLine();
            bool promptPayer = true;
            switch (promptPaymentInput.ToLower())
            {
                case "y":
                    promptPayer = true;
                    break;
                case "n":
                    promptPayer = false;
                    break;
                default:
                    Console.WriteLine("Invalid input, please try again.");
                    break;
            }
            Console.WriteLine("Is there a special clearance (Y/N)?");
            var specialClearanceInput = Console.ReadLine();
            bool specialClearance = true;
            switch (specialClearanceInput.ToLower())
            {
                case "y":
                    specialClearance = true;
                    break;
                case "n":
                    specialClearance = false;
                    break;
                default:
                    Console.WriteLine("Invalid input, please try again.");
                    break;
            }

            #region inefficient code
            //if (isCreditLimitExceeded == true && promptPayer == true && specialClearance == true)
            //{
            //    Console.WriteLine(OrderAcceptanceStatus.Accept);
            //}
            //else if (isCreditLimitExceeded == true && promptPayer == true && specialClearance == false)
            //{
            //    Console.WriteLine(OrderAcceptanceStatus.Decline);
            //}
            //else if (isCreditLimitExceeded == true && promptPayer == false && specialClearance == true)
            //{
            //    Console.WriteLine(OrderAcceptanceStatus.Accept);
            //}
            //else if (isCreditLimitExceeded == true && promptPayer == false && specialClearance == false)
            //{
            //    Console.WriteLine(OrderAcceptanceStatus.Decline);
            //}
            #endregion

            bool firstDeclineCondition = (isCreditLimitExceeded == true && promptPayer == true && specialClearance == false);
            bool secondDeclineCondition = (isCreditLimitExceeded == true && promptPayer == false && specialClearance == false);
            if (firstDeclineCondition || secondDeclineCondition)
            {
                Console.WriteLine(OrderAcceptanceStatus.Decline);
            }
            else
            {
                Console.WriteLine(OrderAcceptanceStatus.Accept);
            }
        }
    }
}
