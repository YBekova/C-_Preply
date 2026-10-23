namespace C__Preply;

public class Car : Vehicle
{
    public Car(string name) : base(name)
    {
        Specification = "Some new Car";
        Model = "Some new Model";
    }

    public override void Move()
    {
        Console.WriteLine($"Топим педаль тачки! Model: {Model}");
    }
}