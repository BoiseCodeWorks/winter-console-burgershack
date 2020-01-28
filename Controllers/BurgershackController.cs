using System;
using burgershack.Services;

namespace burgershack.Controllers
{
    class BurgershackController
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
                case 'n':
                    MakeBurger();
                    break;
                default:
                    System.Console.WriteLine("Invalid command");
                    Service.PrintMenu();
                    break;
            }
        }

        private void MakeBurger()
        {
            Console.Clear();
            Console.WriteLine("Making New Burger, please complete the following...");
            //name
            Console.Write("Burger Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("");
            //ingredients
            Console.Write("Ingredients (comma seperated): ");
            string[] ingredients = Console.ReadLine().Split(",");
            Console.WriteLine("");
            //Price
            Console.Write("Price: ");
            string stringPrice = Console.ReadLine(); //will have to parse
            Console.WriteLine("");
            //KCals
            Console.WriteLine("KCals: ");
            string stringKCals = Console.ReadLine();

            Console.Clear();

            if (float.TryParse(stringPrice, out float price) && int.TryParse(stringKCals, out int kCals))
            {
                Service.MakeBurger(name, ingredients, price, kCals);
                return;
            }
            System.Console.WriteLine("Invalid burger information (please try again)");
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