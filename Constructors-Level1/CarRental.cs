namespace Constructors_Level1;
/* Car Rental System
o Create a CarRental class with attributes customerName, carModel, and
rentalDays.
o Add constructors to initialize the rental details and calculate total cost.
 */
public class CarRental
{
    // Attributes
    public string customerName;
    public string carModel;
    public int rentalDays;
    public int totalPrice;

    // Parametrized Constructor
    public CarRental(string  customerName, string carModel, int rentalDays)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
        this.totalPrice = CalculatePrice();
    }

    // Total Price
    public int CalculatePrice()
    {
        int charge = 400;
        totalPrice = charge * rentalDays;
        return totalPrice; 
    }

    // Display
    public void Display()
    {
        Console.WriteLine("Car Rental System");
        Console.WriteLine("Customer Name: " + customerName);
        Console.WriteLine("Car Model: " + carModel);
        Console.WriteLine("Rental Days: " + rentalDays);
        Console.WriteLine("Total Price : " + totalPrice);

    }

}
