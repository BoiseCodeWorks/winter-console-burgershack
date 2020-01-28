using burgershack.Interfaces;

namespace burgershack.Models
{
    class Side : IMenuItem
    {
        public Side(string name, int kCal)
        {
            Name = name;
            KCal = kCal;
        }

        public string Name { get; set; }
        public int KCal { get; set; }
        public float Price { get; set; } = 2.85f;

        public string GetMenuLineItem()
        {
            return $"{Name}({KCal})";
        }
    }
}