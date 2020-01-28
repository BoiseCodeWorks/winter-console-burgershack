using burgershack.Interfaces;

namespace burgershack.Models
{
    public class Mushroom : ILight, IScented
    {
        public bool Poisonous { get; set; }
        public int Lumens { get; set; }
        public string Scent { get; set; }

        public void Illuminate()
        {
            System.Console.WriteLine("It glows with magic");
        }

        public void Illuminate(string fuel)
        {
            System.Console.WriteLine("Maybe you will glow if you eat it");
        }
    }
}