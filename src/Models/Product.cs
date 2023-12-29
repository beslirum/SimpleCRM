// Product.cs

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    // Ürün adının benzersiz olup olmadığını kontrol eden bir özellik
    public bool IsNameUnique { get; set; }

    // Ürün stok durumu
    public int StockQuantity { get; set; }

    // Ürün açıklaması
    public string Description { get; set; }
}
