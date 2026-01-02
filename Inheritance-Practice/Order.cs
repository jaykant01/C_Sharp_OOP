namespace Inheritance_Practice;
/* ○ Description: Create a multilevel hierarchy to manage orders, where Order is
the base class, ShippedOrder is a subclass, and DeliveredOrder extends
ShippedOrder.
 */
public class Order
{
    public int OrderId;
    public DateTime OrderDate;

    public Order(int orderId, DateTime orderDate)
    {
        OrderId = orderId;
        OrderDate = orderDate;
    }

    public virtual string GetOrderStatus()
    {
        Console.WriteLine($"OderId is {OrderId}");
        Console.WriteLine($"Date is {OrderDate}");
        return "Order Placed";
    }
}

class ShippedOrder : Order
{
    public string TrackingNumber;

    public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber)
        : base(orderId, orderDate)
    {
        TrackingNumber = trackingNumber;
    }

    public override string GetOrderStatus()
    {
        return "Order Shipped";
    }
}

class DeliveredOrder : ShippedOrder
{
    public DateTime DeliveryDate;

    public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate) : base(orderId, orderDate, trackingNumber)
    {
        DeliveryDate = deliveryDate;
    }

    public override string GetOrderStatus()
    {
        Console.WriteLine($"Delivery Date is {DeliveryDate}");
        return "Order Delivered";
    }
}


