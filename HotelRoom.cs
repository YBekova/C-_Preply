namespace C__Preply;

public class HotelRoom
{
    public int RoomNumber { get; }
    public string GuestName { get; private set; }

    public int RoomPriceForNight
    {
        get;
        private set => field = value > 0 ? value : 1000;
    }
  
    public int NightsAmount { get; private set; }
    public bool IsBooked { get; private set; }

    public decimal TotalCost => RoomPriceForNight * NightsAmount;

    public HotelRoom(int roomNumber) : this(roomNumber, 1000)
    { }

    public HotelRoom(int roomNumber, int roomPrice)
    {
        RoomNumber = roomNumber;
        RoomPriceForNight = roomPrice;
    }

    public bool Book(string name)
    {
        if (!IsBooked)
        {
            GuestName = name;
            NightsAmount = 1;
            IsBooked = true;
            return true;
        }

        return false;
    }

    public bool Book(string name, int nights)
    {
        if (!IsBooked && nights > 0)
        {
            GuestName = name;
            NightsAmount = nights;
            IsBooked = true;
            return true;
        }
        
        return false;
    }
    
    public int GetValue(string test, int test2) // GetValue(string, int)
    {
        return 10;
    }

    public int GetValue() // GetValue()
    {
        return 10;
    }

    public void CancelBooking()
    {
        GuestName = "";
        NightsAmount = 0;
        IsBooked = false;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Room number: {RoomNumber} Room price: {RoomPriceForNight} Booking - {IsBooked}, Guest Name - {GuestName}, how many night - {NightsAmount}");
    }
}

// Print(int number);
// Print(string text);
// Print(string text, int count);
// Print(int count, string text);