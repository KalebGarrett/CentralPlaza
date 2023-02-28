using System;

namespace CentralPlaza.Consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            CentralPlaza store = new CentralPlaza(true);
            TechGeek techGeek = new TechGeek();
            QuickMart quickMart = new QuickMart();

            store.Greeting();

            while (store.AppRunning)
            {
                Console.Write("\"E\" for Exit, \"T\" for Tech Geek, and \"Q\" for Quick Mart: ");
                store.Command = Console.ReadLine()?.ToUpper();

                switch (store.Command)
                {
                    case "E":
                        store.AppRunning = false;
                        break;
                    case "T":
                        break;
                    case "Q":
                        break;
                    default:
                        Console.WriteLine("That is not a valid option");
                        break;
                }
            }

            store.ByeBye();
        }
    }
}