class Word
{
    private string _word;
    private bool _isVisible;

    public Word(string word)
    {
        _word = word;
        _isVisible = true;

    }
    public void SetIsVisible (bool isVisible)
    {
        _isVisible = isVisible;

    }
    public bool GetIsVisible()
    {
        return _isVisible;

    }
    public string GetWord()
    {
        return _word;

    }
    public string GetInvisibleWord()
    {
        string invisibleWord = "";
        for (int i=0; i<_word.Length; i++)
        {
            invisibleWord += "_";
        }
        return invisibleWord;
    }
}