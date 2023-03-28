
class OutdoorEvent : Event
{
    string _weatherStatement = "";

    public OutdoorEvent(string title,
                        string description,
                        string date,
                        string time,
                        Address address,
                        string weatherStatement) : base(title,
                                             description,
                                             date,
                                             time,
                                             address)
    {
        _weatherStatement = weatherStatement;
    }
    public override string GetFullDetails()
    {
        string standardDetails = GetStandardDetails();
        string fullDetails = $"{standardDetails}, {_weatherStatement}";
            return fullDetails;
    }
    public override string GetShortDescription()
    {
        string shortDescription = $"Outdoor Event, {_title}, {_date}";
            return shortDescription;
    }
}