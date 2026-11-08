namespace C__Preply;

public class BookingService
{
    public decimal CreateBooking(HotelRoom room, int nights) => room.Book(nights);
    
}