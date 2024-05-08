using System.IO;
using System.Reflection.Emit;

public class Journal 

{
    public List<Entry> _entries = new List<Entry>();
    
    public void AddEntry(Entry newEntry)
    {
         _entries.Add(newEntry);
                      
    }


    public void DisplayAll()
    {
         foreach (Entry entry in _entries)
        {
                 entry.Display();
            
        }

    }

    public void SaveToFile()
    {
        Console.WriteLine("Enter the filename to save:");
        string _filename = Console.ReadLine();      

        Console.WriteLine($"Saving to file: {_filename}");                                           
        using (StreamWriter outputFile = new StreamWriter(_filename))
    
        foreach (Entry e in _entries)   
        {
         outputFile.WriteLine($"{e._date},{e._entryText},{e._promptText}");
        }
    
        Console.WriteLine("File Saved Successfully!");
    }   
    

    

     public void LoadFromFile()
    {
        string _filename = Console.ReadLine();
        string[] _lines = File.ReadAllLines(_filename);

        foreach (string _line in _lines)
        {
            string[] _parts = _line.Split(",");
            
            DateTime date = DateTime.Parse(_parts[0]);
            string entryText = _parts[1];
            string promptText = _parts[2];   
        }  
    }
}

    