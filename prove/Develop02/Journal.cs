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
        string filename = Console.ReadLine();      

        Console.WriteLine($"Saving to file: {filename}");                                           
        using (StreamWriter outputFile = new StreamWriter(filename))
    
        foreach (Entry e in _entries)   
        {
         outputFile.WriteLine($"{e._date},{e._entryText},{e._promptText}");
        }
    
        Console.WriteLine("File Saved Successfully!");
    }   
    

    

     public void LoadFromFile()
    {
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            
            DateTime date = DateTime.Parse(parts[0]);
            string entryText = parts[1];
            string promptText = parts[2];   
        }  
    }
}

    