using C__Preply;

var listOfVehicles = new List<Vehicle>
{
    new Car("Second Car"),
    new Bicycle("Third Bicycle", 7),
    new Bicycle("Fourth Bicycle", 7),
    new ElectricBicycleV2("ELeCTRIC", 100)
};

void TestRide(Vehicle vehicle) => vehicle.Move();

foreach (var vehicle in listOfVehicles)
{
    TestRide(vehicle);
}

var testCar = new Car("First Car");

Console.WriteLine(testCar.Specification);