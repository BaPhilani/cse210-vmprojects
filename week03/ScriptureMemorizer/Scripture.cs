using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string reference, string text)
    {
        _reference = ParseReference(reference);
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    private Reference ParseReference(string referenceText)
    {
        // Parse something like "John 3:16" or "Proverbs 3:5-6"
        var parts = referenceText.Split(' ');
        var book = parts[0];
        var chapterVerse = parts[1].Split(':');
        var chapter = int.Parse(chapterVerse[0]);
        
        if (chapterVerse[1].Contains('-'))
        {
            var verses = chapterVerse[1].Split('-');
            return new Reference(book, chapter, int.Parse(verses[0]), int.Parse(verses[1]));
        }
        else
        {
            return new Reference(book, chapter, int.Parse(chapterVerse[1]));
        }
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetDisplayText());
        Console.WriteLine(string.Join(" ", _words.Select(w => w.GetDisplayText())));
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool IsFullyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}  
