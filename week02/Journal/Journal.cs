using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{

    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
        }
        foreach (Entry entry in _entries)
            {
                entry.Display();
                Console.WriteLine();
            }
        
    }

    public void saveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }  
        }
    }

    public void loadFromFile(string filename)
    {
        //_entries.Clear();
        //List<Entry> _entries = new List<Entry>();
        //string[] lines = File.ReadAllLines(fileName);
        foreach (string line in File.ReadAllLines(filename))
        {
            string[] parts = line.Split("|");
            if (parts.Length == 3)
            {
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                _entries.Add(entry);
            }
           // using (StreamWriter outputfile = new StreamWriter(filename))
            //{
            //    outputfile.WriteLine();
            //}
        }

        
   }
}