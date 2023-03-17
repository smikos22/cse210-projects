using System.Diagnostics;

public class Activity
{
protected string _startMessage = "";
protected string _description = "";
protected int _activityDuration;

protected string _endMessage = "GoodBye";
protected int spinnerCounter = 0;
protected int numSecondsToRun;

public Activity (string startMessage, string description, int activityDuration, string endMessage)
{
    _startMessage = startMessage;
    _description = description;
    _activityDuration = activityDuration;
    _endMessage = endMessage;
}

public void WriteIntro()
{
    Console.WriteLine(_startMessage);
    Console.WriteLine(_description);
    Console.WriteLine(_activityDuration);
}
public string GetStartMessage()
{
    return _startMessage;
}

public string GetDescriptionMessage()
{
    return _description;
}

public int GetActivityDuration()
{
    return _activityDuration;
}
public string GetEndMessage()
{
    return _endMessage;
}
public int GetNumSecondsToRun()
{
    return numSecondsToRun;
}
public void displaySpinner(int numSecondsToRun)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        
        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            spinnerCounter++;        
            switch (spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }
 
        Console.Write(" ");
    } 
 
    public void displayCountDown(int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i >= 1; i--)
        {            
            Console.Write(string.Format("You may begin in: {0}", i));
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }

}
