using burgershack.Interfaces;

namespace burgershack.Models
{
    class ScentedCandle : Candle, IScented
    {
        public string Scent { get; set; }

        public override void Illuminate()
        {
            System.Console.WriteLine("A small flicker of light and the smell of " + Scent);
        }

    }
}