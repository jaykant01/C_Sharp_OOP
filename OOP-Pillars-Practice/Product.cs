namespace OOP_Pillars_Practice;

abstract class Product
{
    private int productId;
    private string name;
    private double price;
    
    public int ProductId
    {
        get { return productId; }
        set { productId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }


    public Product(int productId, string name, double price)
    {
        this.productId = productId;
        this.name = name;
        this.price = price;
    }


    public abstract double CalculateDiscount();
    
}

interface ITaxable
{
    double CalculateTax();

    string GetTaxDetails();
}

class Electronics : Product, ITaxable
{
    public Electronics(int  productId, string name, double price) : base(productId, name, price)
    {
    }

    public override double CalculateDiscount()
    {
        return Price * 0.10;
    }

    public double CalculateTax()
    {
        return Price * 0.18;
    }

    public string GetTaxDetails()
    {
        return "18% GST";
    }
}

class Clothing : Product, ITaxable
{
    public Clothing(int productId, string name, double price) : base(productId, name, price)
    {
    }

    public override double CalculateDiscount()
    {
        return Price * 0.20; 
    }

    public double CalculateTax()
    {
        return Price * 0.12; 
    }

    public string GetTaxDetails()
    {
        return "12% GST";
    }
}

class Groceries : Product
{
    public Groceries(int productId, string name, double price) : base(productId, name, price)
    {
    }

    public override double CalculateDiscount()
    {
        return Price * 0.05;
    }
}




