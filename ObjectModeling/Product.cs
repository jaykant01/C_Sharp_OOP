namespace ObjectModeling;

public class Product
{
    public string name { get; }
    public double price { get; }

    public Product(string name, double price)
    {
        this.name = name;
        this.price = price;
    }

    public override string ToString()
    {
        return $"{name} - ${price}";
    }
}

public class Order
{
    public int orderId { get; }
    public DateTime orderDate { get; }
    public Customer1 customer { get; } 

    // List of products in this order
    private List<Product> products = new List<Product>();

    public Order(int orderId, Customer1 customer)
    {
        this.orderId = orderId;
        this.customer = customer;
        this.orderDate = DateTime.Now;
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        products.Add(product);
        Console.WriteLine($"Added '{product.name}' to Order #{orderId}");
    }

    // Calculate total price of the order
    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.price;
        }
        return total;
    }

    // Show full order details (communication)
    public void ShowOrderDetails()
    {
        Console.WriteLine("Order Details");
        Console.WriteLine($"Order ID: {orderId}");
        Console.WriteLine($"Date: {orderDate:yyyy-MM-dd HH:mm}");
        Console.WriteLine($"Customer: {customer.name} ({customer.email})");
        Console.WriteLine("Products:");
        foreach (var product in products)
        {
            Console.WriteLine($" - {product}");
        }
        Console.WriteLine($"Total Amount: ${GetTotalPrice()}");
        Console.WriteLine();
    }
}

public class Customer1
{
    public string name { get; }
    public string email { get; }

    // List of orders placed by this customer
    private List<Order> orders = new List<Order>();

    public Customer1(string name, string email)
    {
        this.name = name;
        this.email = email;
    }

    // Method to place a new order
    public Order PlaceOrder(int orderId)
    {
        Order newOrder = new Order(orderId, this);
        orders.Add(newOrder);
        Console.WriteLine($"{name} placed a new order (Order #{orderId})");
        return newOrder;
    }

    // Show all orders by this customer
    public void ShowMyOrders()
    {
        Console.WriteLine($"Orders placed by {name}:");
        if (orders.Count == 0)
        {
            Console.WriteLine("  No orders yet.\n");
        }
        else
        {
            foreach (var order in orders)
            {
                Console.WriteLine($"  - Order #{order.orderId} on {order.orderDate:yyyy-MM-dd}");
            }
            Console.WriteLine();
        }
    }
}
