using System;

class Program
{
    static void Main(string[] args)
    
    {
        Breathing breathing = new Breathing();
        Activity activity = new Activity();
        Listing listing = new Listing();
        int menuUserInput = 0;

        List<string> menu = new List<string>
            {
                "Menu Options:",
                "1. Start breathing activity",
                "2. Start reflecting activity",
                "3. Start listing activity",
                "4. Quit",
                "Select a choice from the menu: "
            };
        while (menuUserInput != 4)
        {
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }

            menuUserInput = int.Parse(Console.ReadLine());

            if (menuUserInput == 1)
            {
                bMessage.Breathing();
            }
            else if (menuUserInput == 2)
            {
                rMessage.DisplayQuestions();
            }
            else if (menuUserInput == 3)
            {
                listing.Listing();
            }
        }
    

  //      int activityDuration ;
        Console.Write("Please enter the number of seconds you would like this activity to run.");
        int activityDuration = int.Parse(Console.ReadLine());
        string endMessage = "Great job completeing this activity";

        string bStartMessage = "Welcome to the Breathing Activity.";
        string bDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        Breathing bMessage = new Breathing (bStartMessage, bDescription, activityDuration, endMessage);
        bMessage.WriteIntro();
        
        string rStartMessage = "Welcome to the Reflecting Activity.";
        string rDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        Reflecting rMessage = new Reflecting (rStartMessage, rDescription, activityDuration, endMessage);

        rMessage.WriteIntro();
        rMessage.DisplayQuestions();

        string lStartMessage = "Welcome to the Listing Activity.";   
        string lDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        Listing lMessage = new Listing (lStartMessage, lDescription, activityDuration, endMessage);
        lMessage.WriteIntro();

    }   
    
}