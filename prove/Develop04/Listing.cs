public class Listing : Activity
{

    protected string _lDescription = "";
    public Listing (string commonStartMessage, string lDescription, int activityDuration, string endMessage)
    :base(commonStartMessage, activityDuration, endMessage)
    {
        _lDescription = lDescription;
    }
    public string GetLDescription()
    {
        return _lDescription;
    }
}