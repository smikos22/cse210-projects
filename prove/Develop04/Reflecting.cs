public class Reflecting : Activity
{
    protected string _rDescription = "";
    public Reflecting (string commonStartMessage, string rDescription,  int activityDuration, string endMessage)
        :base(commonStartMessage, activityDuration, endMessage)
    {
        _rDescription = rDescription;
    }
    public string GetRDescription()
    {
        return _rDescription;
    }
}