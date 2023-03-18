public class Breathing : Activity
{
    //protected string _bDescription = "";
    public Breathing (string StartMessage, string description, int activityDuration, string endMessage)
    :base(StartMessage, description, activityDuration, endMessage)
    {
    }
    public void RunActivity()
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_activityDuration);
        Console.WriteLine(_activityDuration);
        while (currentTime < endTime)
        {
            BreatheIn();
            Console.WriteLine();
            BreatheOut();
            Console.WriteLine();
            currentTime = DateTime.Now;
        }

    }
    protected virtual void BreatheIn()
    {
        Console.WriteLine();
        Console.WriteLine("Breathe in...");
        ShowCountdown(3);
    }
    protected virtual void BreatheOut()
    {
        Console.WriteLine("Breathe out...");
        ShowCountdown(3);
    }

    private void Pause(int seconds)
    {
        Thread.Sleep(seconds * 1000);
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }    
}