using C__Preply;

var carFord = new Car();

carFord.Brand = "Ford2";
carFord.Color = "Red";

var carAudi = new Car
{
    Brand = "Audi",
    Color = "Blue",
};

carFord.ShowShortInfo();
carFord.ShowSpeedInfo();
carFord.Accelerate(101);
// carFord.Speed = carFord.Speed + 100;
carFord.ShowSpeedInfo();

var speedNow = carFord.GetCurrentSpeed();

if (carFord.GetCurrentSpeed() > 100)
{
    carFord.Stop();
}

carFord.ShowSpeedInfo();