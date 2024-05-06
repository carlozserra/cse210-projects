public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
         Console.WriteLine($"{_date}: {_promptText}");
         Console.WriteLine($"{_entryText}");

    }

// cada pergunta feita, será um entry, agora vc precisa armazenar cada entry em uma lista, pra poder fazer save and
//load 

}