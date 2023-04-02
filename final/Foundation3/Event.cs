
public abstract class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    public Event (string eventTitle, string description, string date, string time, Address address)
    {
        Console.WriteLine();
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GetStandardDetails()
    {
        string details = $"Title: {_eventTitle}\n" + 
        $"Description: {_description}\n" +
        $"Date: {_date}\n"+
        $"Time: {_time}\n"+
        $"Address: {_address}\n";
        return details;
    }
    public abstract string GetFullDetails();
    public abstract string GetShortDescription();
    
    

}