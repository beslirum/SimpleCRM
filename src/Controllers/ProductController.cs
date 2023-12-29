// ProductController.cs

public class ProductController
{
    private readonly DatabaseContext _context;

    public ProductController(DatabaseContext context)
    {
        _context = context;
    }

    public void AddProduct(Product product)
    {
        // Ürün adı benzersiz olmalıdır, aynı isimde başka bir ürün varsa eklenmez
        if (_context.Products.Any(p => p.Name == product.Name))
        {
            throw new InvalidOperationException("Bu isimde bir ürün zaten var.");
        }

        _context.Products.Add(product);
        _context.SaveChanges();
    }

    public void DeleteProduct(int productId)
    {
        var productToDelete = _context.Products.Find(productId);

        if (productToDelete != null)
        {
            _context.Products.Remove(productToDelete);
            _context.SaveChanges();
        }
        else
        {
            throw new InvalidOperationException("Belirtilen ürün bulunamadı.");
        }
    }

    public List<Product> GetAllProducts()
    {
        return _context.Products.ToList();
    }

    // Diğer ürün işlemleri için metotlar eklenebilir.
}
