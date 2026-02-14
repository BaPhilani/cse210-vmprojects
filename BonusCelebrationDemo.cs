// Quick demonstration of the bonus celebration feature
using System;

class ChecklistGoal
{
    private int _targetCount;
    private int _currentCount;

    public ChecklistGoal(int targetCount)
    {
        _targetCount = targetCount;
        _currentCount = 0;
    }

    public void RecordEvent()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            Console.WriteLine("Congratulations! You've completed the checklist goal!");
            DisplayBonusCelebration();
        }
        else
        {
            Console.WriteLine($"Progress: {_currentCount}/{_targetCount}");
        }
    }

    private void DisplayBonusCelebration()
    {
        Console.WriteLine("\n🎉 ✨ BONUS CELEBRATION ✨ 🎉");
        Console.WriteLine("═══════════════════════════════════");
        Console.WriteLine("  AMAZING ACHIEVEMENT UNLOCKED!");
        Console.WriteLine("  You've conquered this challenge!");
        Console.WriteLine("  Keep up the fantastic momentum!");
        Console.WriteLine("═══════════════════════════════════");
        Console.WriteLine("Bonus Points Awarded: +50 XP\n");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Bonus Celebration Feature Demo ===\n");
        
        var goal = new ChecklistGoal(3);
        
        Console.WriteLine("Recording events for a 3-count checklist goal:\n");
        goal.RecordEvent();
        goal.RecordEvent();
        goal.RecordEvent();
    }
}
