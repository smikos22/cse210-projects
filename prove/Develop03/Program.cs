using System;

class Program
{
    static void Main(string[] args)
    {
        Reference single_reference = new Reference("John", 3,16);
//        Console.WriteLine(single_reference.GetReference());
        Verse single_verse = new Verse("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but havve everlasting life.");
//        single_verse.HideRandomWords(); 
        Scripture scripture = new Scripture(single_reference, single_verse);
        scripture.ShowScripture();
//        Console.WriteLine();
        Reference multi_reference = new Reference("Moroni", 10,3,5);
//        Console.WriteLine(multi_reference.GetReference());
        Console.WriteLine("\n");


        while (true)
        {
            Console.WriteLine("Press Enter to Continue or type 'quit' to exit.");
            var input = Console.ReadLine().ToLower();

            if (input == "quit")
                break;
            
            scripture.HideWords();
            scripture.ShowScripture();
            

            if (scripture.IsFullyHidden())
            {
                Console.WriteLine("All words have been hidden.");
                break;
            }
          

        }
        
    }
}
        
    
