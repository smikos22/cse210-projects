public class Receptions : Event
{
    private string _rsvpEmail;
    private int _capacity;
    public Receptions (string eventTitle, string description, string date, string time, Address address, string rsvpEmail, int capacity)
    : base(eventTitle, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
        _capacity = capacity;
        Console.WriteLine("Reception");

    }
    public override string GetFullDetails()
    {
        string fullDetails = $"Title: {_eventTitle}\n" + 
        $"Description: {_description}\n" +
        $"Date: {_date}\n"+
        $"Time: {_time}\n"+
        $"Address: {_address}\n"+
        $"RSVP: {_rsvpEmail}\n"+
        $"Capasity: {_capacity}";
        return fullDetails;
        
    }
    public override string GetShortDescription()
    {
        string shortDescription = $"Title: {_eventTitle}\n" + 
        $"Date: {_date}\n";
        return shortDescription;
        
    }




}