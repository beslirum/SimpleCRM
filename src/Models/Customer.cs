// Customer.cs

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    // Diğer müşteri bilgilerini eklemek için özellikler eklenebilir

    // Navigation Property: Müşterinin etkileşimleri
    public List<Interaction> Interactions { get; set; }

    // Navigation Property: Müşterinin siparişleri
    public List<Order> Orders { get; set; }
}
