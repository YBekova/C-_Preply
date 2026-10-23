namespace C__Preply;

public class ElectricBicycleV2 : Bicycle
{
    public FuelType Fuel => FuelType.Electric;
    
    public ElectricBicycleV2(string name, int gearCount) : base(name, gearCount)
    {
        
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} is using electric");
    }
}