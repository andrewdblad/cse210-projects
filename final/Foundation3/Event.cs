
abstract class Event
{
    protected string _title = "";
    private string _description = "";
    protected string _date = "";
    private string _time = "";
    private Address _address = null;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GetStandardDetails()
    {
        string addressString = _address.GetAddressString();
        string standardDetails = $"{_title}, {_description}, {_date}, {_time}, {addressString}";
            return standardDetails;
    }

    public abstract string GetFullDetails();
    
    public abstract string GetShortDescription();
}