using System;
using System.Collections.Generic;
using System.Linq;

namespace CentralPlaza.Consoleapp
{
    public class QuickMart : TechGeek
    {
        public record QuickMartCatalogue(string Product, double Price);

        public record QuickMartOrder(QuickMartCatalogue Item, int Quantity);

        public List<QuickMartCatalogue> QuickMartProducts { get; set; } = new List<QuickMartCatalogue>
        {
            new("Eggs", 7.00),
            new("Milk", 6.00),
            new("Yogurt", 5.00),
            new("Fish", 12.00),
            new("Bread", 5.50),
            new("Pasta", 2.50),
        };

        public List<QuickMartOrder> QuickMartOrders  { get; set; } = new List<QuickMartOrder>();

        public override void Greeting()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Quick Mart!");
        }

        public void PrintCatalogueQuickMart(List<QuickMartCatalogue> quickMartCatalogue)
        {
            Console.WriteLine("What are you interested in buying?");
            for (int i = 0; i < quickMartCatalogue.Count; i++)
            {
                Console.Write($"{i + 1}: {quickMartCatalogue[i].Product} (${quickMartCatalogue[i].Price})\n");
            }

            Console.WriteLine();
        }

        public QuickMartCatalogue InputProductQuickMart(List<QuickMartCatalogue> quickMartCatalogue)
        {
            while (true)
            {
                Console.Write("Enter options: 1, 2, 3, 4, 5, or 6: ");
                if (int.TryParse(Console.ReadLine(), out int i) && i > 0 && i <= quickMartCatalogue.Count)
                {
                    Console.WriteLine($"You have picked: {quickMartCatalogue[i - 1].Product}\n");
                    return quickMartCatalogue[i - 1];
                }
            }
        }

        public override int InputQuantity()
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

        public void PrintSubTotalQuickMart(List<QuickMartOrder> quickMartOrders)
        {
            Console.WriteLine($"Your Subtotal: ${quickMartOrders.Sum(o => o.Item.Price * o.Quantity)}\n");
        }

        public override bool CheckIfContinue()
        {
            Console.Write("Would you like anything else from Quick Mart? Y/N: ");
            return Console.ReadLine()?.Trim().ToUpper() == "Y";
        }

        public void PrintGrandTotalQuickMart(List<QuickMartOrder> quickMartOrders)
        {
            Console.WriteLine();
            foreach (var order in quickMartOrders)
            {
                Console.WriteLine(
                    $"{order.Item.Product,-10} x{order.Quantity,-4}: ${order.Item.Price * order.Quantity}");
            }

            Console.WriteLine("**********************************");
            Console.WriteLine($"Your Grand Total: ${quickMartOrders.Sum(o => o.Item.Price * o.Quantity)}\n");
        }

        public override void ByeBye()
        {
            Console.WriteLine("Thank you for shopping at Quick Mart!");
            Console.WriteLine();
        }
    }
}