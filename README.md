# Simple CRM Projesi

Bu C# projesi, müşteri ilişkileri yönetimi (CRM) için temel bir yapı sunar. Proje, müşteri bilgilerini yönetmek, etkileşim geçmişini takip etmek, ürün ve sipariş yönetimini sağlamak üzere tasarlanmıştır.

## Proje Yapısı

- **CRMPro**
  - **src**
    - **Models**
      - [Customer.cs](src/Models/Customer.cs)
      - [Interaction.cs](src/Models/Interaction.cs)
      - [Product.cs](src/Models/Product.cs)
      - [Order.cs](src/Models/Order.cs)
    - **Views**
      - [MainWindow.xaml](src/Views/MainWindow.xaml)
      - [CustomerDetailView.xaml](src/Views/CustomerDetailView.xaml)
      - [InteractionHistoryView.xaml](src/Views/InteractionHistoryView.xaml)
    - **Controllers**
      - [CustomerController.cs](src/Controllers/CustomerController.cs)
      - [InteractionController.cs](src/Controllers/InteractionController.cs)
      - [ProductController.cs](src/Controllers/ProductController.cs)
      - [OrderController.cs](src/Controllers/OrderController.cs)
    - **DataAccess**
      - [DatabaseContext.cs](src/DataAccess/DatabaseContext.cs)
    - **Utilities**
      - [Logger.cs](src/Utilities/Logger.cs)
    - [Program.cs](src/Program.cs)
  - [database.sql](database.sql)
  - [README.md](README.md)


## Proje Tanımı

Bu proje, müşteri ilişkileri yönetimi (CRM) konseptini uygulayan bir C# uygulamasıdır. Temel amacı, müşteri bilgilerini izlemek, etkileşim geçmişini kaydetmek, ürün ve sipariş yönetimini gerçekleştirmektir. Proje, Entity Framework Core kullanılarak SQL veritabanıyla etkileşime geçer.

## Nasıl Çalıştırılır

1. Projenin ana dizininde terminali açın.
2. `dotnet run` komutunu kullanarak proje üzerindeki `Program.cs` dosyasını çalıştırın.
3. Uygulama başladığında, müşteri, etkileşim ve diğer işlemleri gerçekleştirebilirsiniz.

## Bağımlılıklar

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)

## Veritabanı Yapısı

Proje, SQL tablolarını aşağıdaki gibi tanımlar:

- **Customers**: Müşteri bilgilerini içerir.
- **Interactions**: Müşteri etkileşimlerini kaydeder.
- **Products**: Satışa sunulan ürünlerin bilgilerini içerir.
- **Orders**: Müşteri siparişlerini temsil eder.
- **OrderItems**: Siparişlere ait ürünleri detaylandırır.

Veritabanı şeması ve örnek SQL sorguları için [database.sql](database.sql) dosyasına göz atın.
