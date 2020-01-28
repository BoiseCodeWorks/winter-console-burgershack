using System.Collections;
using System.Collections.Generic;
using burgershack.Interfaces;

namespace burgershack.Models
{
    class Burger : IMenuItem
    {
        public string Name { get; set; }
        List<string> Ingredients { get; set; }
        public float Price { get; set; }
        public int KCal { get; set; }
        public string GetMenuLineItem()
        {
            return $"{Name}({KCal}) -- ${Price}";
        }
        public Burger(string name, IEnumerable<string> ingredients, float price, int kCal)
        {
            Name = name;
            Ingredients = new List<string>();
            Ingredients.AddRange(ingredients);
            Price = price;
            KCal = kCal;
        }
    }
}