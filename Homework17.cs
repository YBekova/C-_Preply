const int ticketPrice = 150;
const int doubleSeatsIndex = 9;

Console.Write("Enter number of seats: ");
var isSeatsNumberValid = int.TryParse(Console.ReadLine(), out var numberOfSeats);
var isInvalidSeatsNumber = numberOfSeats is < 5 or > 20;

var occupiedSeats = 0;
while (!isSeatsNumberValid || isInvalidSeatsNumber)
{
    if (!isSeatsNumberValid)
    {
        Console.Write("Error! Enter the valid number for seats: ");
    }
    else if (isInvalidSeatsNumber)
    {
        Console.Write("Error! The number of entered seats can't be more than 20 and less than 5, try again: ");
    }
    
    isSeatsNumberValid = int.TryParse(Console.ReadLine(), out numberOfSeats);
    isInvalidSeatsNumber = numberOfSeats is < 5 or > 50;


}

var seats = new bool[numberOfSeats]; // через булеан задаем массив в который кладем колчиство свободных сидений и это значение кладем в seats который всегда будет false, если сиденье свободно
var freeSeats = numberOfSeats;


Console.WriteLine();

while (freeSeats > 0)
{
    for (int i = 0; i < seats.Length; i++)
    {
        if (!seats[i]) Console.Write("[ ] ");
        
        if (!seats[i])
        {
            if (i >= doubleSeatsIndex) Console.Write("  [ ]  ");
            else Console.Write("[ ] ");
        }
        else Console.Write("[X] ");
        
    }
    
    Console.WriteLine();
    
    for (int i = 0; i < seats.Length; i++)
    {
        if (i >= doubleSeatsIndex) Console.Write($"  {i + 1}   ");
        else Console.Write($" {i + 1}  ");
    }

    Console.WriteLine();
    Console.Write("Enter seat number (0 - close cashier): ");

    var seatNumber = 0;
    var seatNumberValid = false;
    var isSeatNumberOutOfRange = seatNumber < 1 || seatNumber > seats.Length;
    
    while (!seatNumberValid || (seatNumber != 0 && isSeatNumberOutOfRange))
    {
        seatNumberValid = int.TryParse(Console.ReadLine(), out seatNumber);

        if (!seatNumberValid) Console.Write("Error! Enter a number: ");
        else if (isSeatNumberOutOfRange) Console.Write($"There are only {seats.Length} seats. Try again: ");
    }

    if (seatNumber == 0)
    {
        Console.WriteLine("\nThe cashier is closed. Good bye!");
        break;

    }

    var seatIndex = seatNumber - 1;
    
    if (seats[seatIndex])// сюда заходим если сиденье true уже до итерации и тогда тут выскакивает проверка
    {
        Console.WriteLine($"Seat {seatNumber} is already occupied. Choose another.");
        continue;

    }
    
    seats[seatIndex] = true;// сюда заходим если сиденье было свободно false, а стало занято те true только тогда
    freeSeats--;
    occupiedSeats++;
    
    Console.WriteLine();
    Console.WriteLine($"Seat {seatNumber} sold!");
    

}


var occupancyPercentage = (double)occupiedSeats / numberOfSeats * 100;
var ticketSum = ticketPrice * occupiedSeats;

Console.WriteLine($"Sold seats: {occupiedSeats} from {numberOfSeats}");
Console.WriteLine($"Unoccupied seats: {freeSeats}");
Console.WriteLine($"Occupancy: {occupancyPercentage}%");
Console.WriteLine($"Ticket price: {ticketPrice}");
Console.WriteLine($"ticket revenue: {ticketSum}");

       

