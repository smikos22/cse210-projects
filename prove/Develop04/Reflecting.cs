public class Reflecting : Activity
{
    protected string _rDescription = "";
    public List<string> prompts = new List<string>();
    public List<string> questions = new List<string>();
    public string question;
    public string prompt;
    public Reflecting (string StartMessage, string description,  int activityDuration, string endMessage)
        :base(StartMessage, description, activityDuration, endMessage)
        {
 //           Reflecting rMessage = new Reflecting("Welcome to the Reflecting Activity.", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", activityDuration, endMessage);

            prompts.Add("Think of a time you stood up for someone else. ");
            prompts.Add("Think of a time when you did something really difficult. ");
            prompts.Add("Think of a time when you helped someone in need. ");
            prompts.Add("Think of a time when you did something truly selfless.");
            questions.Add("Why was this experience meaningful to you?");
            questions.Add("Have you ever done anything like this before?");
            questions.Add("How did you get started?");
            questions.Add("How did you feel when it was complete?");
            questions.Add("What made this time different than other times when you were not as successful?");
            questions.Add("What is your favorite thing about this experience?");
            questions.Add("What could you learn from this experience that applies to other situations?");
            questions.Add("What did you learn about yourself through this experience?");
            questions.Add("How can you keep this experience in mind in the future?");

        }
//    public string message;
    public void RunActivity()
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_activityDuration);
        Console.WriteLine("Get ready...");
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(_activityDuration);
        GetRandomPrompt();
        Console.WriteLine (GetRandomPrompt());
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        while (currentTime < endTime)
        {

            Console.WriteLine(GetRandomQuestion());
            displaySpinner(6);
            currentTime = DateTime.Now;
            Console.WriteLine();
        }

    }
    public string GetRandomPrompt()
    {
        Random randomGenerator= new Random ();
        int promptNumber = randomGenerator.Next(0,4);
        prompt = prompts[promptNumber];
        return prompt;
    }

    public string GetRandomQuestion()
    {
        Random randomGenerator= new Random ();
        int questionNumber = randomGenerator.Next(0,9);
        question = questions[questionNumber];
        return question;
    }

}