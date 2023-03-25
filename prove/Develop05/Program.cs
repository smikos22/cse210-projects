using System;

class Program
{
    static void Main(string[] args)
    
    {
        int menuUserInput = 0;
        string endMessage = "";

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
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }

            menuUserInput = int.Parse(Console.ReadLine());

            if (menuUserInput == 1)
            {
                string startMessage = "The types of Goals are:";
                Console.WriteLine(startMessage);
            }
            else if (menuUserInput == 2)
            {
            }
            else if (menuUserInput == 3)
            {
            }
        }
    


        


    }   
    
  
}