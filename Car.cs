namespace C__Preply;

public class Car : Vehicle
{
    public decimal InsurancePerDay { get; set; }
    public Car(string name, decimal pricePerDay, decimal insurancePerDay) : base(name, pricePerDay)
    {
        InsurancePerDay = insurancePerDay;
    }

    public override decimal CalculateCost(int days)
    {
        return (InsurancePerDay + PricePerDay) * days;
    }
}