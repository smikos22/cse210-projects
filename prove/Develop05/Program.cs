using System;

class Program
{
    static void Main(string[] args)
    
    {
        int menuUserInput = 0;
        string endMessage = "";
        Game game = new Game();

        List<string> menu = new List<string>
            {
                "Menu Options:",
                "1. Create New Goal",
                "2. List Goals",
                "3. Save Goals",
                "4. Load Goals",
                "5. Record Event",
                "6. Quit",
                "Select a choice from the menu: "
            };
        while (menuUserInput != 6)
        {
            Console.WriteLine($"You have {game.GetTotalPoints()} points.\n");
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }

            menuUserInput = int.Parse(Console.ReadLine());

            if (menuUserInput == 1)
            {
                game.CreateGoal();
            }
            else if (menuUserInput == 2)
            {
                game.ListGoals();
            }
            else if (menuUserInput == 3)
            {
                game.SaveGoals();
            }
            else if (menuUserInput == 4)
            {
                game.LoadGoals();
            }  
            else if (menuUserInput == 5)
            {
                game.RecordEvent();
            }
            Console.WriteLine();
        }
    


        


    }   
    
  
}