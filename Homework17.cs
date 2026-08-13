using System.Runtime.CompilerServices;

Console.Write("Enter number of seats: ");
var isSeatsNumberValid = int.TryParse(Console.ReadLine(), out var numberOfSeats);
var isInvaildSeatsNumber = numberOfSeats is < 5 or > 20;

var occupiedSeats = 0;
while (!isSeatsNumberValid || isInvaildSeatsNumber)
{
    if (!isSeatsNumberValid)
    {
        Console.Write("Error! Enter the valid number for seats: ");
    }
    else if (isInvaildSeatsNumber)
    {
        Console.Write("Error! The number of entered seats can't be more than 20 and less than 5, try again: ");
    }
    
    isSeatsNumberValid = int.TryParse(Console.ReadLine(), out numberOfSeats);
    isInvaildSeatsNumber = numberOfSeats is < 5 or > 20;


}

bool[] seats = new bool[numberOfSeats]; // через булеан задаем массив в который кладем колчиство свободных сидений и это значение кладем в seats который всегда будет false, если сиденье свободно
var freeSeats = numberOfSeats;


Console.WriteLine();

while (freeSeats > 0)
{
    for (int i = 0; i < seats.Length; i++)
    {
        if (!seats[i]) Console.Write("[ ] ");
        
        else Console.Write("[X] ");
        
    }
    
    Console.WriteLine();
    
    for (int i = 0; i < seats.Length; i++)
    {
        Console.Write($" {i + 1}  ");
    }

    Console.WriteLine();
    Console.Write("Enter seat number (0 - close cashier): ");
    
    var seatNumberValid = int.TryParse(Console.ReadLine(), out var seatNumber);
    

    while (!seatNumberValid || (seatNumber != 0 && (seatNumber < 1 || seatNumber > seats.Length)))
    {

        if (!seatNumberValid) Console.Write("Error! Enter a number: ");
           
        
        else Console.Write($"There are only {seats.Length} seats. Try again: ");

        
        
        seatNumberValid = int.TryParse(Console.ReadLine(), out seatNumber);

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



var countedOccupied = 0;
var countedFree = 0;


foreach (bool seat in seats)
{
    if(seat) countedOccupied++;
    else countedFree++;
    
}

int cashierSum = 0;
var occupancyPercentage = (double)occupiedSeats / numberOfSeats * 100;
var ticketPrice = 150;
var ticketSum = ticketPrice * occupiedSeats;

Console.WriteLine($"Sold seats: {occupiedSeats} from {numberOfSeats}");
Console.WriteLine($"Unoccupied seats: {freeSeats}");
Console.WriteLine($"Occupancy: {occupancyPercentage}%");
Console.WriteLine($"Ticket price: {ticketPrice}");
Console.WriteLine($"ticket revenue: {ticketSum}");
       

