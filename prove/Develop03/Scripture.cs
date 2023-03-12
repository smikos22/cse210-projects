class Scripture

{
    private Reference reference;
    private List<Verse> verseList;

    public Scripture (Reference reference, Verse verse)
    {
        this.reference = reference;
        verseList = new List<Verse>();
        verseList.Add (verse);
    }
    public Scripture (Reference reference, List<Verse> verseList)
    {
        this.reference = reference;
        this.verseList = verseList;

    }
    public void ShowScripture()
    {
        foreach (Verse verse in verseList)
        {
            verse.ShowVerse();
        }
    }
    public void HideWords()
    {
        foreach (Verse verse in verseList)
        {
            verse.HideRandomWords();
        }

/*        if (verseList.Count == 0)
        {
            return false;
        }
        else
        {
            return true;
  //          int index = new Random().Next(verseList.Count);
  /         return verseList[index].HideRandomWords();
        }*/  
    }
    public bool IsFullyHidden()
    {
        bool foundVisibleWord = false;
        foreach (Verse verse in verseList)
        {
            if (verse.AllWordsHidden())
            {
                foundVisibleWord = true;
            }
        }

        bool fullyHidden = true;
        if (foundVisibleWord)
        {
            fullyHidden = false;
        }
        return fullyHidden;
//        return verseList.All(verseList => verse.IsFullyHidden());
    }
}