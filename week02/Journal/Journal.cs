using System;
using System.IO;
using System.Collections.Generic;

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
            Console.WriteLine("No Journal entries found.");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    _entries.Add(new Entry(parts[0], parts[1], parts[2]));
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    // this is creativity
    public void DeleteEntry(int index)
        {
            if (index < 1 || index > _entries.Count)
            {
                Console.WriteLine("Invalid entry.");
                return;
            }
            _entries.RemoveAt(index - 1);
        }
    
}