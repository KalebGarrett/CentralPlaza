namespace CentralPlaza.Consoleapp.Models
{
    public class CentralPlaza
    {
        public bool AppRunning { get; set; }
        public string Command { get; set; }

        public CentralPlaza(bool appRunning)
        {
            AppRunning = appRunning;
        }
    }
}