public class Listing : Activity
{

    protected string _lDescription = "";
    public Listing (string StartMessage, string description, int activityDuration, string endMessage)
    :base(StartMessage, description, activityDuration, endMessage)
    {
        Listing lMessage = new Listing("Welcome to the Listing Activity.", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", activityDuration, endMessage);

    }
}