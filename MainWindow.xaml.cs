// MainWindow.xaml.cs

public partial class MainWindow : Window
{
    private readonly CustomerController _customerController;
    private readonly InteractionController _interactionController;
    private readonly ProductController _productController;
    private readonly OrderController _orderController;

    public MainWindow()
    {
        InitializeComponent();

        var context = new DatabaseContext();
        _customerController = new CustomerController(context);
        _interactionController = new InteractionController(context);
        _productController = new ProductController(context);
        _orderController = new OrderController(context);
    }

    // Arayüz olayları ve kodları buraya eklenebilir
}
