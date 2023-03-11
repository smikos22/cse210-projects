using System;

class Program
{
    static void Main(string[] args)
    {
        Reference single_reference = new Reference("Alma", 3,7);
//        Console.WriteLine(single_reference.GetReference());
        Verse single_verse = new Verse("And their brethren sought to destry them, therefore they were cursed; and the Lord God set a mark upoon them, yea, UriComponents Laman and Lemuel, AbandonedMutexException the sons of Ishmael, AbandonedMutexException Ishmaelitish women.");
        single_verse.HideRandomWords(); 
        Scripture scripture = new Scripture(single_reference, single_verse);
        scripture.ShowScripture();
//        Console.WriteLine();
        Reference multi_reference = new Reference("Moroni", 10,3,5);
//        Console.WriteLine(multi_reference.GetReference());
        Console.WriteLine("\n");
        
        single_verse.HideRandomWords();
        scripture.ShowScripture();
        Console.WriteLine();
        single_verse.HideRandomWords();
        scripture.ShowScripture();
        Console.WriteLine();

        single_verse.HideRandomWords();
        scripture.ShowScripture();
        Console.WriteLine();

        single_verse.HideRandomWords();
        scripture.ShowScripture();

    }
}
        
    
