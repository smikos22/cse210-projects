public class Breathing : Activity
{
    protected string _bDescription = "";
    public Breathing (string commonStartMessage, string bDescription, int activityDuration, string endMessage)
    :base(commonStartMessage, activityDuration, endMessage)
    {
        _bDescription = bDescription;
    }

    public string GetDescription()
    {
        return _bDescription;
    }
}