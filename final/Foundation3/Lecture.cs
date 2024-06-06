public class Lecture : Event
{

    private string _speaker;
    private int _capacity;

    public Lecture (string title, string description, string date, string time, string speaker, int capacity, Address address) 
    :base (title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string SetLecture()
    {
        return $"Speaker : {_speaker}\n"+
               $"Capacity : {_capacity}\n";
    }

}