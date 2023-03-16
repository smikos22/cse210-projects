public class Activity
{
//protected string startingMessage = "Welcome";
protected string _commonStartMessage = "Welcome";
protected int _activityDuration = 0;
protected string _endMessage = "GoodBye";

public Activity (string commonStartMessage, int activityDuration, string endMessage)
{
    _commonStartMessage = commonStartMessage;
    _activityDuration = activityDuration;
    _endMessage = endMessage;
}
public string GetCommonStartMessage()
{
    return _commonStartMessage;
}
public int GetActivityDuration()
{
    return _activityDuration;
}
public string GetEndMessage()
{
    return _endMessage;
}
public void StartUp()
{
    Console.WriteLine($"{_commonStartMessage} {_activityDuration} {_endMessage}");
}
}
