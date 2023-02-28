using System;

namespace CentralPlaza.Consoleapp
{
    public class QuickMart : CentralPlaza
    {
        public override void Greeting()
        {
            Console.WriteLine("Welcome to Quick Mart!");
        }

        public override bool CheckIfContinue()
        {
            Console.Write("Would you like anything else from Quick Mart? Y/N: ");
            return Console.ReadLine()?.Trim().ToUpper() == "Y";
        }

        public override void ByeBye()
        {
            Console.WriteLine("Thank you for shopping at Quick Mart!");
        }
    }
}