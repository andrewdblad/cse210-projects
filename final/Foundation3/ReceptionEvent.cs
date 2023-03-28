
class ReceptionEvent : Event
{
    string _rsvpEmail = "";

    public ReceptionEvent(string title,
                        string description,
                        string date,
                        string time,
                        Address address,
                        string rsvpEmail) : base(title,
                                             description,
                                             date,
                                             time,
                                             address)
    {
        _rsvpEmail = rsvpEmail;
    }
    public override string GetFullDetails()
    {
        string standardDetails = GetStandardDetails();
        string fullDetails = $"{standardDetails}, {_rsvpEmail}";
            return fullDetails;
    }
    public override string GetShortDescription()
    {
        string shortDescription = $"Reception Event, {_title}, {_date}";
            return shortDescription;
    }
}