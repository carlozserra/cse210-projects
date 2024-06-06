public class Reception : Event
{
    private string _weather;


    public Reception (string title, string description, string date, string time, string weather, Address address) 
    :base (title, description, date, time, address)
    {  
        _weather = weather;     
    }
    public string SetReception()
    {
        return $"Weather: {_weather}";
    }

}