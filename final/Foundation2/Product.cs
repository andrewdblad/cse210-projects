


class Product
{

    private string _name = "";
    private string _productID = "";
    private double _price = 0.00;
    private int _quantity = 0;

    public Product()
    {

    }
    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = quantity * price;
        _quantity = quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetProductID()
    {
        return _productID;
    }
    public double GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
}