namespace C__Preply;

public abstract class Delivery : IDelivery
{
    public string Address { get; set; }
    public int Distance { get; set; }
    public abstract decimal CalculateCost();

    public Delivery(string address, int distance)
    {
        Address = address;
        Distance = distance;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"The address - {Address}, how many kilometers {Distance}");
    }
}