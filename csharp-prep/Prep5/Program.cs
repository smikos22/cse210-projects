using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
        return;
    }
    static string PromptUserName()
    {
        string userInput;
        Console.Write("please Enter your name: ");
        userInput = Console.ReadLine();
        return userInput;

    }

    static int PromptUserNumber()
    {
        string userInput;
        int favoriteNumber;
        Console.Write("Please enter your favorite number: ");
        userInput = Console.ReadLine();
        favoriteNumber = int.Parse(userInput);
        return favoriteNumber;
    }
    static int SquareNumber(int favoriteNumber)
    {
        int square = favoriteNumber * favoriteNumber;
        return square;

    }

    static void DisplayResult (string userName,int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}");
        return;
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int square = SquareNumber(favoriteNumber);
        DisplayResult(userName, square);
        
        
    }
}