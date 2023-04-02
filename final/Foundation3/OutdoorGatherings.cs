public class OutdoorGatherings : Event
{
    private string _weather;
    public OutdoorGatherings(string eventTitle, string description, string date, string time, Address address, string weather)
    : base(eventTitle, description, date, time, address)
    {
        _weather = weather;
        Console.WriteLine("OutdoorGatherings");
    }
    public override string GetFullDetails()
    {
        string fullDetails = $"Title: {_eventTitle}\n" + 
        $"Description: {_description}\n" +
        $"Date: {_date}\n"+
        $"Time: {_time}\n"+
        $"Address: {_address}\n"+
        $"Weather Today: {_weather}";
        return fullDetails;
        
    }
    public override string GetShortDescription()
    {
        string shortDescription = $"Title: {_eventTitle}\n" + 
        $"Date: {_date}\n";
        return shortDescription;
        
    }


}