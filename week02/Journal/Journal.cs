// stores a list of journal entries for the user to review later
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAllEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found. Start writing!");
            return;
        }
        
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filename, jsonString);
            Console.WriteLine($"Journal saved successfully to {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine($"File '{filename}' not found.");
                return;
            }
            
            string jsonString = File.ReadAllText(filename);
            _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString) ?? new List<Entry>();
            Console.WriteLine($"Journal loaded successfully from {filename}. {_entries.Count} entries loaded.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }

    public void DisplayStatistics()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to analyze.");
            return;
        }

        Console.WriteLine($"\n=== Journal Statistics ===");
        Console.WriteLine($"Total entries: {_entries.Count}");
        
        Dictionary<string, int> moodCounts = new Dictionary<string, int>();
        foreach (var entry in _entries)
        {
            if (!string.IsNullOrEmpty(entry._mood))
            {
                if (moodCounts.ContainsKey(entry._mood))
                    moodCounts[entry._mood]++;
                else
                    moodCounts[entry._mood] = 1;
            }
        }
        
        if (moodCounts.Count > 0)
        {
            Console.WriteLine("\nMood distribution:");
            foreach (var mood in moodCounts)
            {
                Console.WriteLine($"  {mood.Key}: {mood.Value} entries");
            }
        }
        
        if (_entries.Count > 0)
        {
            Console.WriteLine($"First entry: {_entries[0]._date}");
            Console.WriteLine($"Latest entry: {_entries[_entries.Count - 1]._date}");
        }
    }

    public void SearchEntries(string keyword)
    {
        var results = new List<Entry>();
        foreach (var entry in _entries)
        {
            if (entry._entryText.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                entry._prompt.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                results.Add(entry);
            }
        }
        
        if (results.Count == 0)
        {
            Console.WriteLine($"No entries found containing '{keyword}'.");
        }
        else
        {
            Console.WriteLine($"\nFound {results.Count} entries matching '{keyword}':\n");
            foreach (var entry in results)
            {
                entry.DisplayEntry();
            }
        }
    }
}
