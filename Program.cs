using C__Preply;


var car1 = new Car("Toyota Camry", 100, 50);
var car2 = new Car("Mitsubishi Outlander", 150, 80);

var bicycle1 = new Bicycle("Atom", 40);
var bicycle2 = new Bicycle("Salomon", 30);
var bicycle3 = new Bicycle("Lamborghini", 30);

List<Vehicle> vehicles = new List<Vehicle>();

vehicles.Add(car1);
vehicles.Add(car2);
vehicles.Add(bicycle1);
vehicles.Add(bicycle2);
vehicles.Add(bicycle3);

List<RentalOrder> rentalOrder = new List<RentalOrder>(8);

rentalOrder.Add(new RentalOrder(car1, 8));
rentalOrder.Add(new RentalOrder(car2, 3));
rentalOrder.Add(new RentalOrder(car1, 5));
rentalOrder.Add(new RentalOrder(car2, 4));

rentalOrder.Add(new RentalOrder(bicycle1, 7));
rentalOrder.Add(new RentalOrder(bicycle2, 5));
rentalOrder.Add(new RentalOrder(bicycle1, 4));
rentalOrder.Add(new RentalOrder(bicycle2, 2));

static void ProcessRentalOrders(List<RentalOrder> rentalOrders)
{
    if (rentalOrders.Count == 0)
    {
        Console.WriteLine("No rental orders found");
        return;
    }
    
    decimal totalRevenue = 0;
    decimal maxCost = 0;
    RentalOrder mostExpensiveOrder = null;

    foreach (RentalOrder order in rentalOrders)
    {
        decimal cost = order.GetTotalCost();
        
        Console.WriteLine($"Transport: {order.Vehicle.Name}, days: {order.Days}, cost: {cost}");
        
        totalRevenue += cost;
        
        if (cost > maxCost)
        {
            maxCost = cost;
            mostExpensiveOrder = order;
        }
        
    }
    
    Console.WriteLine($"\nTotal revenue: {totalRevenue}");
        
    Console.WriteLine($"\nMost expensive order: {mostExpensiveOrder.Vehicle.Name}, cost: {maxCost}");
    
    decimal averageCost = totalRevenue / rentalOrders.Count;
    
    Console.WriteLine($"\nAverage order cost: {averageCost}\n");

    var countAboveAverage = 0;
    
    foreach (RentalOrder order in rentalOrders)
    {
        if (order.GetTotalCost() > averageCost)
        {
            Console.WriteLine($"Above average order: {order.Vehicle.Name}, cost: {order.GetTotalCost()}");
            countAboveAverage++;
        }
    }

    Console.WriteLine($"\nOrders above average: {countAboveAverage}");
}

static void ShowVehicleStats(List<Vehicle> vehicles, List<RentalOrder> rentalOrders)
{

    foreach (Vehicle vehicle in vehicles)
    {
        var orderCount = 0; 
        var totalDays = 0;
        decimal revenue = 0;

        foreach (RentalOrder order in rentalOrders)
        {
            if (ReferenceEquals(vehicle, order.Vehicle))
            {
                orderCount++;
                totalDays += order.Days;
                revenue += order.GetTotalCost();
            }
        }

        Console.WriteLine($"{vehicle.Name}: orders - {orderCount}, days - {totalDays}, revenue - {revenue}");
    }
}

ProcessRentalOrders(rentalOrder);
Console.WriteLine();
ShowVehicleStats(vehicles, rentalOrder);
