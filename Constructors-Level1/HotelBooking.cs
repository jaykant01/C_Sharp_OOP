namespace Constructors_Level1;
/* Hotel Booking System
o Create a HotelBooking class with attributes guestName, roomType, and
nights.
o Use default, parameterized, and copy constructors to initialize bookings.
 */
public class HotelBooking
{
    // Attributes
    public string guestName;
    public string roomType;
    public int nights;

    // Default Constructors
    public HotelBooking()
    {
        guestName = null;
        roomType = null;
        nights = 0;
    }

    // Parametrized Constructors
    public HotelBooking(string GuestName, string RoomType, int Nights)
    {
        guestName = GuestName;
        roomType = RoomType;
        nights = Nights;
    }

    // Copy Constructors
    public HotelBooking(HotelBooking copyHotel)
    {
        guestName = copyHotel.guestName;
        roomType = copyHotel.roomType;
        nights = copyHotel.nights;
    }

    // Display
    public void Display()
    {
        Console.WriteLine("Hotel Booking Details");
        Console.WriteLine("Guest Name: " + guestName);
        Console.WriteLine("Room Type: " + roomType);
        Console.WriteLine("Nights: " + nights);
    }
}
