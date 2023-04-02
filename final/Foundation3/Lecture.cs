public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string eventTitle, string description, string date, string time, Address address, int capacity, string speaker)
    : base(eventTitle, description, date, time, address)
    {
        _capacity = capacity;
        _speaker = speaker;
        Console.WriteLine("Lecture");
    }
    public override string GetFullDetails()
    {
        string fullDetails = $"Title: {_eventTitle}\n" + 
        $"Description: {_description}\n" +
        $"Date: {_date}\n"+
        $"Time: {_time}\n"+
        $"Address: {_address}\n"+
        $"Speaker: {_speaker}\n"+
        $"Capacity: {_capacity}";
        return fullDetails;
        
    }
    public override string GetShortDescription()
    {
        string shortDescription = $"Title: {_eventTitle}\n" + 
        $"Date: {_date}\n";
        return shortDescription;
        
    }
}
