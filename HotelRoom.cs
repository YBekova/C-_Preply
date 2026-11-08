namespace C__Preply;

public class HotelRoom
{
    public int Number { get; set; }
    public decimal PricePerNight { get; set; }
    public bool IsBooked { get; set; }

    public HotelRoom(int number, decimal pricePerNight)
    {
        Number = number;
        PricePerNight = pricePerNight;
        IsBooked = false;
    }

   public decimal Book(int nights)
    {
        if (nights <= 0)
        {
            throw new ArgumentException("The amount of nights must be more than 0!");
        }

        if (IsBooked == true)
        {
            throw new InvalidOperationException("This room is already booked!");
        }
        decimal totalCost = PricePerNight * nights;
        IsBooked = true;
        return totalCost;
        ;
    }
}