namespace burgershack.Interfaces
{
    interface IMenuItem
    {
        string Name { get; set; }
        int KCal { get; set; } //NO WAY TO KNOW

        string GetMenuLineItem();
    }
}