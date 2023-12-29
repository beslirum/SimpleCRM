// Order.cs

public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public List<OrderItem> OrderItems { get; set; }

    // Siparişin toplam tutarını hesaplayan bir özellik
    public decimal TotalAmount
    {
        get { return OrderItems?.Sum(oi => oi.Subtotal) ?? 0; }
    }
}

public class OrderItem
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }

    // Sipariş öğesinin alt toplamını hesaplayan bir özellik
    public decimal Subtotal { get; set; }
}

