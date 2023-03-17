public class Breathing : Activity
{
    //protected string _bDescription = "";
    public Breathing (string StartMessage, string description, int activityDuration, string endMessage)
    :base(StartMessage, description, activityDuration, endMessage)
    {
        Breathing bMessage = new Breathing("Welcome to the Breathing Activity.", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", activityDuration, endMessage);

    }
}