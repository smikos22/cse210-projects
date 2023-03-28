public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment> ();

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length:{_length} secconds");
        foreach(Comment comment in _comments)
        {
            Console.WriteLine($"Name: {comment._name} Comment: {comment._comment}");
        }
        Console.WriteLine($"Number of comments: {CountComments()}");
    }
    public int CountComments()
    {
        return _comments.Count;
    }
}