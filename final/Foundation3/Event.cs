public class Event{

    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address; 

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        
    }

    
    public string GetStandardDetail() //Lists the title, description, date, time, and address
    {
        return $"{_description} - {_title}\n{_date} at {_time}\n"+
               $"{_address.GetFullAddress()}\n";
    }
    public string GetFullDetail() 
    {
        return $" type: {_title}\n {_date} at {_time} \n {_address.GetFullAddress()}\n";
    }

    public string GetShortDescription() // Lists the type of event, title, and the date.
    {
        return $"{_title} - {_description} - {_date}";
    }

}
