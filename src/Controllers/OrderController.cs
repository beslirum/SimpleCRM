// OrderController.cs

public class OrderController
{
    private readonly DatabaseContext _context;

    public OrderController(DatabaseContext context)
    {
        _context = context;
    }

    public void PlaceOrder(Order order)
    {
        // Eğer siparişin ürünleri varsa, veritabanına ekleyelim
        if (order.OrderItems != null && order.OrderItems.Any())
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
        else
        {
            // Siparişte ürün yoksa kullanıcıya bir hata mesajı gösterelim
            throw new InvalidOperationException("Siparişte en az bir ürün olmalıdır.");
        }
    }

    // Sipariş detaylarını getiren bir metot ekleyebilirsiniz
    public Order GetOrderDetails(int orderId)
    {
        return _context.Orders
            .Include(o => o.OrderItems)
            .ThenInclude(oi => oi.Product)
            .FirstOrDefault(o => o.Id == orderId);
    }

    // Tüm siparişleri getiren bir metot ekleyebilirsiniz
    public List<Order> GetAllOrders()
    {
        return _context.Orders.ToList();
    }

    // Diğer sipariş işlemleri için metotlar eklenebilir.
}
