using System;

namespace CentralPlaza.Consoleapp
{
    public class CentralPlaza
    {
        public bool AppRunning { get; set; }
        public string Command { get; set; }

        public CentralPlaza(bool appRunning)
        {
            AppRunning = appRunning;
        }

        protected CentralPlaza()
        {
            
        }

        public virtual void Greeting()
        {
            Console.WriteLine("Welcome to the Central Plaza!");
        }
        
        public virtual bool CheckIfContinue()
        {
            Console.Write("Would you like to check out another store? Y/N: ");
            return Console.ReadLine()?.Trim().ToUpper() == "Y";
        }

        public virtual void ByeBye()
        {
            Console.WriteLine("Good bye!");
        }
    }
}