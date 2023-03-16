using System;

class Program
{
    static void Main(string[] args)
    
    {
        string commonStartMessage = "Welcome";
        int activityDuration  = 0;
        string endMessage = "GoodBye";

        string bDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        Breathing bMessage = new Breathing (commonStartMessage, bDescription, activityDuration, endMessage);
        Console.WriteLine(bMessage.GetDescription());

        string rDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        Reflecting rMessage = new Reflecting (commonStartMessage, rDescription, activityDuration, endMessage);
        Console.WriteLine(rMessage.GetRDescription());
    
        string lDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        Listing lMessage = new Listing (commonStartMessage, lDescription, activityDuration, endMessage);
        Console.WriteLine(lMessage.GetLDescription());

    }   
    
}