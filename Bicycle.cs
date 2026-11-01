namespace C__Preply;

public class Bicycle : Vehicle
{
    public Bicycle(string name, decimal pricePerDay) : base(name, pricePerDay)
    {
    }

    public override decimal CalculateCost(int days)
    {
        decimal percent = 10;
        if (days >= 5) return (PricePerDay * days) * (1 - percent/100);
        
            return PricePerDay * days;
        
    }
}