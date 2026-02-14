//ChecklistGoal.cs is for goals that require multiple completions and becomes complete once we add the following code to it:
using System;
class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;

    public ChecklistGoal(string name, string description, int points, int targetCount) : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
    }

    public override void RecordEvent()
    {
        if (!IsCompleted())
        {
            _currentCount++;
            if (_currentCount >= _targetCount)
            {
                MarkCompleted();
                Console.WriteLine($"Congratulations! You've completed the checklist goal: {GetName()} and earned {GetPoints()} points!");
            }
            else
            {
                Console.WriteLine($"Progress made on the checklist goal: {GetName()}. Current count: {_currentCount}/{_targetCount}.");
            }
        }
        else
        {
            Console.WriteLine($"You've already completed the checklist goal: {GetName()}.");
        }
    }

    public int GetTargetCount()
    {
        return _targetCount;
    }

    public int GetCurrentCount()
    {
        return _currentCount;
    }

    public void LoadProgress(int currentCount, bool isCompleted)
    {
        if (currentCount < 0)
        {
            currentCount = 0;
        }

        if (currentCount > _targetCount)
        {
            currentCount = _targetCount;
        }

        _currentCount = currentCount;
        SetCompleted(isCompleted);
    }
}