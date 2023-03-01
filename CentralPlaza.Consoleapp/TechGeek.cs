using System;
using System.Collections.Generic;
using System.Linq;

namespace CentralPlaza.Consoleapp
{
    public class TechGeek
    {
        public record TechGeekCatalogue(string Product, double Price);

        public record TechGeekOrder(TechGeekCatalogue Item, int Quantity);

        public List<TechGeekCatalogue> TechProducts { get; set; } = new List<TechGeekCatalogue>
        {
            new("Phone", 500.00),
            new("Laptop", 1000.00),
            new("Digital Camera", 600.00),
            new("Headphones", 150.00),
            new("OLED Television", 1800.00),
        };

        public List<TechGeekOrder> TechOrders { get; set; } = new List<TechGeekOrder>();

        public virtual void Greeting()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Tech Geek!");
        }

        public void PrintCatalogue(List<TechGeekCatalogue> techGeekCatalogue)
        {
            Console.WriteLine("What are you interested in buying?");
            for (int i = 0; i < techGeekCatalogue.Count; i++)
            {
                Console.Write($"{i + 1}: {techGeekCatalogue[i].Product} (${techGeekCatalogue[i].Price})\n");
            }

            Console.WriteLine();
        }

        public TechGeekCatalogue InputProduct(List<TechGeekCatalogue> techGeekCatalogue)
        {
            while (true)
            {
                Console.Write("Enter options: 1, 2, 3, 4, or 5: ");
                if (int.TryParse(Console.ReadLine(), out int i) && i > 0 && i <= techGeekCatalogue.Count)
                {
                    Console.WriteLine($"You have picked: {techGeekCatalogue[i - 1].Product}\n");
                    return techGeekCatalogue[i - 1];
                }
            }
        }

        public virtual int InputQuantity()
        {
            while (true)
            {
                Console.Write("Enter quantity: ");
                if (int.TryParse(Console.ReadLine(), out int i) && i > 0)
                {
                    return i;
                }
            }
        }

        public void PrintSubTotal(List<TechGeekOrder> techGeekOrders)
        {
            Console.WriteLine($"Your Subtotal: ${techGeekOrders.Sum(o => o.Item.Price * o.Quantity)}\n");
        }

        public virtual bool CheckIfContinue()
        {
            Console.Write("Would you like anything else from Tech Geek? Y/N: ");
            return Console.ReadLine()?.Trim().ToUpper() == "Y";
        }

        public void PrintGrandTotal(List<TechGeekOrder> techGeekOrders)
        {
            Console.WriteLine();
            foreach (var order in techGeekOrders)
            {
                Console.WriteLine(
                    $"{order.Item.Product,-10} x{order.Quantity,-4}: ${order.Item.Price * order.Quantity}");
            }

            Console.WriteLine("**********************************");
            Console.WriteLine($"Your Grand Total: ${techGeekOrders.Sum(o => o.Item.Price * o.Quantity)}\n");
        }

        public virtual void ByeBye()
        {
            Console.WriteLine("Thank you for shopping at Quick Mart!");
            Console.WriteLine();
        }
    }
}