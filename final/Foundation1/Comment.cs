public class Comment
{
    private string _name;
    private string _contents;

    public Comment(string name, string contents)
    {
        _name = name;
        _contents = contents;
    }

    public string GetString()
    {
        return $"{_name}: {_contents}";
    }
}