using burgershack.Interfaces;

namespace burgershack.Models
{
    abstract class Candle : ILight
    {
        public string Type { get; set; }
        public int Lumens { get; set; }

        //NOTE Virtual flags a method as 'overridable' and will be used as the default if not overriden.
        public virtual void Illuminate()
        {
            System.Console.WriteLine("A small flicker of light");
        }

        public void Illuminate(string fuel)
        {
            System.Console.WriteLine("The wick burns away");
        }
    }
}