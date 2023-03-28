
class LectureEvent : Event
{
    private string _speaker = "";
    private int _capacity = 0;

    public LectureEvent(string title,
                        string description,
                        string date,
                        string time,
                        Address address,
                        string speaker,
                        int capacity) : base(title,
                                             description,
                                             date,
                                             time,
                                             address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override string GetFullDetails()
    {
        string standardDetails = GetStandardDetails();
        string fullDetails = $"{standardDetails}, {_speaker}, {_capacity}";
            return fullDetails;
    }
    public override string GetShortDescription()
    {
        string shortDescription = $"Lecture Event, {_title}, {_date}";
            return shortDescription;
    }
}