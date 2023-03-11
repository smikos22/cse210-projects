class Reference
{
    private string book;
    private int chapter;

    private int startVerse;

    private int endVerse;

    private bool isMulti;


    // Parameterized constructor

    public Reference(string book, int chapter, int startVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.isMulti = true;
    
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
        this.isMulti = false;
    

    }

    public string GetReference()
    {
        string reference;
        if (endVerse == 0)
        {
            reference = book + " " + chapter + ":" + startVerse;
        }
        else
        {
            reference = book + " " + chapter + ":" + startVerse+ "-" + endVerse;
        }
        return reference;
    }


}