using System;
using System.Collections.Generic;
using burgershack.Interfaces;

namespace burgershack.Models
{
    class Shack
    {
        public List<IMenuItem> Menu { get; set; } = new List<IMenuItem>();
        private void Setup()
        {
            //create all the things
            Burger mb = new Burger("Mark Burger", new String[] { "Beef Patty", "Cheese", "Hawt Sauce" }, 6.99f, 674);
            Burger jb = new Burger("Jake Burger", new String[] { "Beef Patty", "Bacon", "Mild Sauce" }, 4.99f, 614);
            Burger db = new Burger("D$ Burger", new String[] { "Beef Patty", "Bacon", "Elk Patty", "Bacon", "Roadkill?", "All the meats" }, 16.99f, 1674);

            Side onion = new Side("Onion Rings", 368);
            Side fries = new Side("Non-Waffled fries", 268);
            Side tots = new Side("Tots", 378);
            Menu.AddRange(new IMenuItem[]{
                mb, jb, db, onion, fries, tots
            });
        }

        public Shack()
        {
            Setup();
        }
    }
}