using System;
using burgershack.Services;

namespace burgershack.Controllers
{
    public class BurgershackController
    {
        private BurgershackService Service { get; set; } = new BurgershackService();
        private bool _running = true;

        public void Run()
        {
            Service.PrintMenu(); //fills Service.Messages with the menu 
            //NOTE this keeps the app alive
            while (_running)
            {
                PrintMessages();
                GetUserInput();
            }
            Console.Clear();
            Console.WriteLine("Goodbye");
        }

        private void GetUserInput()
        {
            var key = Console.ReadKey();
            Console.Clear();
            var keyChar = key.KeyChar;
            switch (keyChar)
            {
                case 'q':
                    _running = false;
                    break;
                default:
                    System.Console.WriteLine("Invalid command");
                    Service.PrintMenu();
                    break;
            }
        }

        private void PrintMessages()
        {
            foreach (string message in Service.Messages)
            {
                Console.WriteLine(message);
            }
            Service.Messages.Clear();
        }
    }
}