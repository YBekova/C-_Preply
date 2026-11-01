namespace C__Preply;

public class Vehicle
{
    public string Name { get; set; }
    public decimal PricePerDay { get; set; }

    public Vehicle(string name, decimal pricePerDay)
    {
        Name = name;
        PricePerDay = pricePerDay;
    }

    public virtual decimal CalculateCost(int days)
    {
        return PricePerDay * days;
        
    }
}