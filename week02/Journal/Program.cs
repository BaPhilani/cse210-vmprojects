using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        
        Console.WriteLine("\n╔════════════════════════════════════════╗");
        Console.WriteLine("║   Welcome to the Journal Program!      ║");
        Console.WriteLine("╚════════════════════════════════════════╝");
        
        while (true)
        {
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. View journal statistics");
            Console.WriteLine("6. Search entries");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"\n{prompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    
                    // Exceeding requirement: mood tracking
                    Console.WriteLine("\nHow are you feeling today?");
                    Console.WriteLine("1. Happy 😊  2. Sad 😢  3. Excited 🎉  4. Stressed 😰  5. Peaceful 😌  6. Skip");
                    Console.Write("Choose mood: ");
                    string moodChoice = Console.ReadLine();
                    string mood = moodChoice switch
                    {
                        "1" => "Happy 😊",
                        "2" => "Sad 😢",
                        "3" => "Excited 🎉",
                        "4" => "Stressed 😰",
                        "5" => "Peaceful 😌",
                        _ => ""
                    };
                    
                    Entry entry = new Entry(DateTime.Now.ToString("yyyy-MM-dd HH:mm"), prompt, response, mood);
                    journal.AddEntry(entry);
                    Console.WriteLine("✓ Entry added successfully!");
                    break;
                    
                case "2":
                    journal.DisplayAllEntries();
                    break;
                    
                case "3":
                    Console.Write("Enter filename to save (e.g., myjournal.json): ");
                    string saveFile = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(saveFile))
                        saveFile = "journal.json";
                    journal.SaveToFile(saveFile);
                    break;
                    
                case "4":
                    Console.Write("Enter filename to load (e.g., myjournal.json): ");
                    string loadFile = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(loadFile))
                        loadFile = "journal.json";
                    journal.LoadFromFile(loadFile);
                    break;
                    
                case "5":
                    journal.DisplayStatistics();
                    break;
                    
                case "6":
                    Console.Write("Enter keyword to search: ");
                    string keyword = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(keyword))
                        journal.SearchEntries(keyword);
                    break;
                    
                case "7":
                    Console.WriteLine("\nThank you for using the Journal Program. Goodbye!");
                    return;
                    
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}