namespace C__Preply;

public class HotelRoom
{
    private int RoomNumber { get; }
    public string GuestName { get; private set; }
    private int roomPriceForNight;
    public int RoomPriceForNight
    {
        get
        {
            return roomPriceForNight;
        }

        set
        {
            if (value > 0)
            {
                roomPriceForNight = value;
            }
            else
            {
                roomPriceForNight = 1000;
            }
        }
    }
    
    private int HowManyNights { get; set; }
    public bool Booked { get; private set; }

    public decimal TotalCost
    {
        get
        {
            return RoomPriceForNight * HowManyNights; 
        }
        

    }

    public HotelRoom(int RoomNumber)
    {
        this.RoomNumber = RoomNumber;
        RoomPriceForNight = 1000;
    }

    public HotelRoom(int roomNumber, int roomPrice)
    {
        RoomNumber = roomNumber;
        RoomPriceForNight = roomPrice;

    }

    public bool Book(string name)
    {
        if (!Booked)
        {
            GuestName = name;
            HowManyNights = 1;
            Booked = true;
            return true;
        }

        return false;
    }

    public bool Book(string name, int nights)
    {
        if (!Booked && nights > 0)
        {
            GuestName = name;
            HowManyNights = nights;
            Booked = true;
            return true;
        }
        
        return false;
    }

    public void CancelBooking()
    {
        GuestName = "";
        HowManyNights = 0;
        Booked = false;
        
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Booking - {Booked}, Guest Name - {GuestName}, how many night - {HowManyNights}");
    }
}