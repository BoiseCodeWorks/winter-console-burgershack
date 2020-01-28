namespace burgershack.Interfaces
{
    interface ILight
    {
        int Lumens { get; set; }
        public void Illuminate();
        public void Illuminate(string fuel);
    }
}