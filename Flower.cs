namespace C__Preply;

public class Flower
{
    public string Colour;
    public string Type;
    public int Amount;
    public bool Blossom;

    public void IsBlossomed()
    {
        Blossom = true;
        Console.WriteLine("Flower is blossomed");
    }

    public void IsNotBlossomed()
    {
        Blossom = false;
        Console.WriteLine("Flower not blossomed");
    }

    public void FlowerInfo()
    {
        Console.WriteLine($"Type: {Type}, Colour: {Colour}, Amount: {Amount}");
    }

    public void IsReadyForSale()
    {
        IsBlossomed();
        Console.WriteLine("Ready for Sale");
    }

    public void AddFlowers(int amount)
    {
        Amount += amount;
    }
}