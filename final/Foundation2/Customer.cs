


class Customer
{
    private string _name = "";
    Address _address = new Address();

    public Customer()
    {

    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LiveInUSA()
    {
        if(_address.USATrueFalse() == true)
        {
            return true;
        }
        else
            return false;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetAddressString()
    {
        return _address.AddressString();
    }
}