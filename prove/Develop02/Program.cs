using System;

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
                "2. Display",
                "3. Load",
                "4. Save",
                "5. Quit",
                "What would you like to do? "
            };
        while (menuUserInput != 5)
        {
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }

            menuUserInput = int.Parse(Console.ReadLine());

            if (menuUserInput == 1)
            {
                journal.CreateJournalEntry();
            }
            else if (menuUserInput == 2)
            {
                journal.DisplayJournalEntries();
            }
            else if (menuUserInput == 3)
            {
                journal.LoadFromCSV();
            }
            else if (menuUserInput == 4)
            {
                //Console.WriteLine();
                journal.SaveToCSV();
            }
        }
    }
}
