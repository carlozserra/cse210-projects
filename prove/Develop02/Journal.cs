using System.IO;

public class Journal 

{
    public List<Entry> _entries = new List<Entry>();
    

    public void AddEntry(Entry newEntry)
    {
    
         _entries.Add(newEntry);
 //So, whenever you call the AddEntry method and pass   //an Entry object as an argument, it will be added to the _entries list.
    }


    public void DisplayAll()
    {
         foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
            // maybe gonna be necessary change the "entry" argument to $ format 
        }


    }

    public void SaveToFile(string file)
    {
        string filename = "file.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))

{       foreach (Entry e in _entries)   
        {
            outputFile.WriteLine($"{e._date},{e._entryText}, {e._promptText}");
        }
         
}

    } 

    public void LoadFromFile(Entry _entries)
    {
        string filename = "file.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
        string[] parts = line.Split(",");
            // Assuming parts are in the format of "date,entryText,promptText"
            DateTime _date = DateTime.Parse(parts[0]);
            string _entryText = parts[1];
            string _promptText = parts[2];
            
        }
    }
}       