class Verse
{
    List<Word> words;
    private string plainText;
    public Verse(string plainText)
    {
        words = new List<Word>();
        string[] parts = plainText.Split(' ');
        foreach (string word in parts)
        {
           Word currentWord =  new Word (word);
           words.Add (currentWord);
        }
    }
    public void ShowVerse()
    {
        foreach (Word word in words)
        {
            if (word.GetIsVisible())
            {
                Console.Write($"{word.GetWord()} ");
            }
            else 
            {
                Console.Write($"{word.GetInvisibleWord()} ");
            }

        }
        Console.WriteLine();
        Console.WriteLine();
    }
    public void HideRandomWords()
    {
        Random random = new Random();

        for (int i=0; i<5; i++)
        {
            int randomNumber = random.Next(0, words.Count);
            //Console.WriteLine(words[randomNumber].GetWord());
            words[randomNumber].SetIsVisible(false);
            
        }


    }
    public bool AllWordsHidden()
    {
        bool foundVisibleWord = false;
        foreach (Word word in words)
        {
            
            if (word.GetIsVisible())
            {
                foundVisibleWord = true;
            }

        }
        return foundVisibleWord;

    }


}