using System;

class Program
{
    static void Main(string[] args)

    {

        Random randomGenerator= new Random ();
        int magicNumber = randomGenerator.Next(1, 100);
//        Console.Write("What is the magic number? ");
 //       string magicNumberInput = Console.ReadLine();
 //       int magicNumber = int.Parse(magicNumberInput);

        string userInput;
        int guess;

        do
        {
            Console.Write("What is your guess? ");
            userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);

    }

}