public class Listing : Activity
{

    protected string _lDescription = "";
    public List<string> prompts = new List<string>();
    public string prompt;
    public Listing (string StartMessage, string description, int activityDuration, string endMessage)
    :base(StartMessage, description, activityDuration, endMessage)
    {
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");

    }

    public void RunActivity()
    {
        List<string> list = new List<string>();
        Console.WriteLine(_activityDuration);
        displayCountDown(5);
        GetRandomPrompt();
        Console.WriteLine(GetRandomPrompt());

        Console.WriteLine("Go!");
        DateTime endTime = DateTime.Now.AddSeconds(_activityDuration);
        while (DateTime.Now < endTime) {
            Console.Write("> ");
            string tempInput = Console.ReadLine();
            list.Add(tempInput);
        }

            Console.WriteLine("You Entered " + list.Count + " items.");

        }
    
    public string GetRandomPrompt()
    {
        Random randomGenerator= new Random ();
        int promptNumber = randomGenerator.Next(0,5);
        prompt = prompts[promptNumber];
        return prompt;
    }


    
}