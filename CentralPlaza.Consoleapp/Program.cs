using System;

namespace CentralPlaza.Consoleapp
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Models.CentralPlaza plaza = new Models.CentralPlaza(true);
            TechGeek techGeek = new TechGeek();
            QuickMart quickMart = new QuickMart();

            while (plaza.AppRunning)
            {
                Console.Write("Commands: \'-Exit\', \'-Tech Geek\', \'-Quick Mart\': ");
                plaza.Command = Console.ReadLine();

                switch (plaza.Command)
                {
                    case { } a when a.StartsWith("-Exit"):
                        plaza.AppRunning = false;
                        break;
                    case { } b when b.StartsWith("-Tech Geek"):
                        do
                        {
                            techGeek.Greeting();
                            techGeek.PrintCatalogue(techGeek.TechProducts);
                            var item = techGeek.InputProduct(techGeek.TechProducts);
                            var quantity = techGeek.InputQuantity();
                            techGeek.TechOrders.Add(new TechGeek.TechGeekOrder(item, quantity));
                            techGeek.PrintSubTotal(techGeek.TechOrders);
                        } while (techGeek.CheckIfContinue());

                        techGeek.PrintGrandTotal(techGeek.TechOrders);
                        techGeek.ByeBye();
                        break;
                    case { } c when c.StartsWith("-Quick Mart"):
                        do
                        {
                            quickMart.Greeting();
                            quickMart.PrintCatalogueQuickMart(quickMart.QuickMartProducts);
                            var item = quickMart.InputProductQuickMart(quickMart.QuickMartProducts);
                            var quantity = quickMart.InputQuantity();
                            quickMart.QuickMartOrders.Add(new QuickMart.QuickMartOrder(item, quantity));
                            quickMart.PrintSubTotalQuickMart(quickMart.QuickMartOrders);
                        } while (quickMart.CheckIfContinue());

                        quickMart.PrintGrandTotalQuickMart(quickMart.QuickMartOrders);
                        quickMart.ByeBye();
                        break;
                    default:
                        Console.WriteLine("That is not a valid command.");
                        break;
                }
            }
        }
    }
}