using C__Preply;

HotelRoom room = new HotelRoom(101, 1200m);
BookingService service = new BookingService();

try
{
    decimal totalCost = service.CreateBooking(room, 0);
    Console.WriteLine($"Total cost: {totalCost}");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine($"Is booked: {room.IsBooked}");

try
{
    decimal totalCost = service.CreateBooking(room, 3);
    Console.WriteLine($"Total cost: {totalCost}");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine($"Is booked: {room.IsBooked}");

try
{
    decimal totalCost = service.CreateBooking(room, 2);
    Console.WriteLine($"Total cost: {totalCost}");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine($"Is booked: {room.IsBooked}");