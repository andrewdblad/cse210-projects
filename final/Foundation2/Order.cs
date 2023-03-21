


class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer = new Customer();
    private double _total = 0.00;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public double CalculateTotal()
    {
        foreach(Product product in _products)
        {
            if(_customer.LiveInUSA() == true)
            {
            double price = product.GetPrice();
            _total = _total + price + 5;
            }
            else
            {
                double price = product.GetPrice();
                _total = _total + price + 35;
            }
        }
        return Math.Round(_total, 2);
    }
    public void DisplayPackingLabel()
    {
        foreach(Product product in _products)
        {
            string name = product.GetName();
            string productID = product.GetProductID();
            int quantity = product.GetQuantity();
            string _packingLabel = $"{name} {productID} * {quantity}";
            Console.WriteLine(_packingLabel);
        }
    }
    public void DisplayShippingLabel()
    {
        string address = _customer.GetAddressString();
        string name = _customer.GetName();
        Console.WriteLine($"{name}\n{address}");

    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    

}