namespace OOP_Pillars_Practice;

abstract class FoodItem
{
    // Encapsulated fields
    private string itemName;
    protected double price;
    protected int quantity;

    // Properties
    public string ItemName
    {
        get { return itemName; }
        protected set { itemName = value; }
    }

    public FoodItem(string name, double price, int quantity)
    {
        ItemName = name;
        this.price = price;
        this.quantity = quantity;
    }

    // Abstract method
    public abstract double CalculateTotalPrice();

    // Concrete method
    public void GetItemDetails()
    {
        Console.WriteLine("Item Name : " + ItemName);
        Console.WriteLine("Price    : " + price);
        Console.WriteLine("Quantity : " + quantity);
    }
}

interface IDiscountable
{
    double ApplyDiscount();
    string GetDiscountDetails();
}

class VegItem : FoodItem, IDiscountable
{
    public VegItem(string name, double price, int quantity)
        : base(name, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return price * quantity; 
    }

    public double ApplyDiscount()
    {
        return CalculateTotalPrice() * 0.10; 
    }

    public string GetDiscountDetails()
    {
        return "10% Veg Discount";
    }
}

class NonVegItem : FoodItem, IDiscountable
{
    public NonVegItem(string name, double price, int quantity)
        : base(name, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        double extraCharge = 50; 
        return (price * quantity) + extraCharge;
    }

    public double ApplyDiscount()
    {
        return CalculateTotalPrice() * 0.05; 
    }

    public string GetDiscountDetails()
    {
        return "5% Non-Veg Discount";
    }
}
