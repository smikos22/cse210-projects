using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        string userInput;
        int listOfNumbers;
        int maxVal = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        do
        {
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            listOfNumbers = int.Parse(userInput);
            if (listOfNumbers != 0)
            {
                numbers.Add(listOfNumbers);
            }
        } while (listOfNumbers != 0);
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        
 //          Finding the Max value in a list of numbers
            foreach( int i in numbers)
            {
                if (i > maxVal) {
                    maxVal = i;
                }
            
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {(float) sum/numbers.Count}");
        Console.WriteLine($"The largest number is: {maxVal}");
    }
}