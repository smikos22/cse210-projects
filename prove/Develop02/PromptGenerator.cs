class PromptGenerator
{
    public List<string> prompts = new List<string>();
    public string prompt;
//    public string message;

    public PromptGenerator()
    {
        prompts.Add("What made you smile today? ");
        prompts.Add("What was the best part of your day? ");
        prompts.Add("Who did you serve today? ");
        prompts.Add("What blessing are you grateful for today?");
        prompts.Add("If I had one thing I could do over today, what would it be? ");

    }
    public string GetRandomPrompt()
    {
        Random randomGenerator= new Random ();
        int promptNumber = randomGenerator.Next(0,5);
        prompt = prompts[promptNumber];
        return prompt;
    }
}