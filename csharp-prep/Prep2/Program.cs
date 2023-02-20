using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        if (number >= 90)
        {
            Console.WriteLine ("A");
        }
        
        else if (number >= 80)
        {
            Console.WriteLine ("B");
        }
        
        else if (number >= 70)
        {
            Console.WriteLine ("C");
        }

        else if (number >= 60)
        {
            Console.WriteLine ("D");
        }

        else
        {
            Console.WriteLine ("F");
        }

        Console.WriteLine($"Your grade is: {number}");

        if (number >=70)
        {
            Console.WriteLine ("Congrautlations you passed the class! ");
        }

        else
        {
            Console.WriteLine ("Keep practicing and I'm sure you will pass next time.");
        }
    }
}