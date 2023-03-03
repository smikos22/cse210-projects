using System;

//class Entry{
    
 //   public List<string> prompts = new List<string>();
 //   public string prompt;
//    public string message;

//    public Entry()
//    {
//        prompts.Add("What made you smile today? ");
//        prompts.Add("What was the best part of your day? ");
//        prompts.Add("Who did you serve today? ");
//        prompts.Add("What blessing are you grateful for today?");
//        prompts.Add("If I had one thing I could do over today, what would it be? ");

//        Random randomGenerator= new Random ();
//        int promptNumber = randomGenerator.Next(0,5);
//        prompt = prompts[promptNumber];        
        
//    }
//    public void writeEntry(String file)
//    {
//       Console.WriteLine(prompt); 
//       message = Console.ReadLine();

//       using (StreamWriter OutputFile = new StreamWriter(file, true))
//       {
//           OutputFile.WriteLine($"Promp: {prompt}");
//           OutputFile.WriteLine($"Message: {message}");
//           OutputFile.WriteLine("-------------------");
//       }
//    }

//    string getPrompt()
//    {
//        return prompt;
//    }
//}
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int menuUserInput = 0;

        List<string> menu = new List<string>
            {
                "Please select one of the following choices:",
                "1. Write",
                "2. Disply",
                "3. Load",
                "4. Save",
                "5. Quit",
                "What would you like to do? "
            };
        while (menuUserInput != 5)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuUserInput = int.Parse(Console.ReadLine());
            journal.CreateJournalEntry();
        }
        
        /*Console.WriteLine($"1. Write a new entry -");
        Console.WriteLine($"2. Display the journal to a file - ");
        Console.WriteLine($"3. Save the journal to a file - ");
        Console.WriteLine($"4. Load the journal from a file - ");*/   
    }
        //While user input is not 5
        //Switch statement for user input.
//    {
//       Program.Display();
        
//       Journal journal = new Journal();
//       journal.writeJournalEntry();
//    }
}