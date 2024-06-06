public class Outdoor : Event
{
    private string _email;


    public Outdoor(string title, string description, string date, string time,string email, Address address) 
    :base (title, description, date, time, address)
    {
        _email = email;
    }
    public string SetOutdoor()
    {
        return $"Email: {_email}";
    }
}