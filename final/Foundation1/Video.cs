public class Video
{
 private int _length;
private string _author;
private string _description;
private List<Comment> comments;

    public Video(string author, string description, int length)
    {
        _author = author;
        _description = description;
        _length = length;
        comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Length: {_length} seconds \n");
        Console.WriteLine($"^ Comments({GetNumberOfComments()})");

        foreach (var comment in comments)
        {
            Console.WriteLine(comment.GetString());
        }
    }
}