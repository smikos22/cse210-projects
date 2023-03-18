using System;

class Program
{
    static void Main(string[] args)
    
    {
        int menuUserInput = 0;
        int activityDuration = 0;
        string endMessage = "";

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
                string bStartMessage = "Welcome to the Breathing Activity.";
                string bDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                Breathing bMessage = new Breathing (bStartMessage, bDescription, activityDuration, endMessage);
                bMessage.WriteIntro();
                bMessage.SetNumSecondsToRun();
                bMessage.RunActivity();
                bMessage.EndMessage();
                bMessage.displaySpinner(5);
                Console.WriteLine();
                Console.WriteLine($"You have completed another {bMessage.GetActivityDuration()} seconds of the Breathing Activity.");

            }
            else if (menuUserInput == 2)
            {
                string rStartMessage = "Welcome to the Reflecting Activity.";
                string rDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                Reflecting rMessage = new Reflecting (rStartMessage, rDescription, activityDuration, endMessage);

                rMessage.WriteIntro();
                rMessage.SetNumSecondsToRun();
                rMessage.RunActivity();
//                Console.WriteLine(rMessage.GetRandomPrompt());
//                rMessage.DisplayQuestions();
                rMessage.EndMessage();
                rMessage.displaySpinner(5);
                Console.WriteLine();
                Console.WriteLine($"You have completed another {rMessage.GetActivityDuration()} seconds of the Reflecting Activity.");
            }
            else if (menuUserInput == 3)
            {
                string lStartMessage = "Welcome to the Listing Activity.";   
                string lDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                Listing lMessage = new Listing (lStartMessage, lDescription, activityDuration, endMessage);
                lMessage.WriteIntro();
                lMessage.SetNumSecondsToRun();
                lMessage.RunActivity();
                lMessage.EndMessage();
                lMessage.displaySpinner(5);
                Console.WriteLine();
                Console.WriteLine($"You have completed another {lMessage.GetActivityDuration()} seconds of the Listing Activity.");


            }
        }
    


        


    }   
    
}