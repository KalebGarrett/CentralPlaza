using System;
using System.Collections.Generic;

namespace CentralPlaza.Consoleapp
{
    public class TechGeek : CentralPlaza
    {
        public record TechGeekCatalogue(string Product, double Price);

        public record TechGeekOrder(TechGeekCatalogue Item, int Quantity);

        public List<TechGeekCatalogue> TechCatalogue = new List<TechGeekCatalogue>()
        {
            new("Phone", 500.00),
            new("Laptop", 1000.00),
            new("Digital Camera", 600.00),
            new("Headphones", 150.00),
            new("OLED Television", 1800.00),
        };

        public List<TechGeekOrder> Orders = new List<TechGeekOrder>();

        public override void Greeting()
        {
            Console.WriteLine("Welcome to Tech Geek!");
        }

        public void PrintCatalog(List<TechGeekCatalogue> TechCatalogue)
        {
            Console.WriteLine("What are you interested in buying?");
            for (int i = 0; i < TechCatalogue.Count; i++)
            {
                Console.Write("");
            }

            Console.WriteLine("**********************");
        }

        public TechGeekCatalogue InputItem(List<TechGeekCatalogue> TechCatalogue)
        {
            while (true)
            {
                Console.Write("Enter option 1, 2 , 3, 4, or 5");
            }
        }

        public override bool CheckIfContinue()
        {
            Console.Write("Would you like anything else from Tech Geek? Y/N: ");
            return Console.ReadLine()?.Trim().ToUpper() == "Y";
        }

        public override void ByeBye()
        {
            Console.WriteLine();
        }
    }
}