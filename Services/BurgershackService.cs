using System.Collections.Generic;
using burgershack.Models;

namespace burgershack.Services
{
    class BurgershackService
    {
        private Shack Shack { get; set; } = new Shack(); //object to hold data
        ///<summary> collection of messages generated by the service to be drawn to the console by the controller</summary>
        public List<string> Messages = new List<string>();


        public void PrintMenu()
        {
            Messages.Add("----Menu----");
            foreach (var item in Shack.Menu)
            {
                Messages.Add(item.GetMenuLineItem());
            }
            Messages.Add("press (o) to order or (n) to add a new item or (q) to quit");
        }

    }
}