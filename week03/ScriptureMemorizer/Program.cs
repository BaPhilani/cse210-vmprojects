using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding requirements:
        // Program loads a list of scriptures from a text file and
        // randomly selects one for the user to memorize.
        // Helps users to memorize multiple scriptures instead of just one

        List<Scripture> library = LoadScriptures("scriptures.txt");
        
        if (library.Count == 0)
        {
            Console.WriteLine("Error: No scriptures found in scriptures.txt");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            return;
        }
        
        Random random = new Random();
        Scripture scripture = library[random.Next(library.Count)];
        
        while (true)
        {
            SafeClear();
            scripture.Display();
            
            if (scripture.IsFullyHidden())
            {
                Console.WriteLine("\nCongratulations! You have memorized the scripture.");
                break;
            }
            
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit")
            {
                break;
            }
            
            scripture.HideRandomWords(3); // Hide 3 more words each time
            
            if (scripture.IsFullyHidden())
            {
                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nCongratulations! You have memorized the scripture.");
                break;
            }
        }
    }

    static List<Scripture> LoadScriptures(string filename)
    {
        List<Scripture> scriptures = new List<Scripture>();
        
        // Get the directory where the executable is located
        string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string fullPath = Path.Combine(exeDirectory, filename);
        
        if (!File.Exists(fullPath))
        {
            Console.WriteLine($"Current directory: {Directory.GetCurrentDirectory()}");
            return scriptures;
        }
        
        foreach (var line in File.ReadLines(fullPath))
        {
            var parts = line.Split('|');
            if (parts.Length == 2)
            {
                scriptures.Add(new Scripture(parts[0], parts[1]));
            }
        }
        return scriptures;
    }

    static void SafeClear()
    {
        if (Console.IsOutputRedirected)
        {
            return;
        }

        try
        {
            Console.Clear();
        }
        catch (IOException)
        {
            // Ignore clear failures in environments without a real console.
        }
    }
}  