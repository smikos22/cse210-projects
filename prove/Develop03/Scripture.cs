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

    }
}