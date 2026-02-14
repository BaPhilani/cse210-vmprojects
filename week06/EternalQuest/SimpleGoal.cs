//simpleGoal.cs becomes complete once we add the following code to it:
using System;
class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        if (!IsCompleted())
        {
            MarkCompleted();
            Console.WriteLine($"Congratulations! You've completed the goal: {GetName()} and earned {GetPoints()} points!");
        }
        else
        {
            Console.WriteLine($"You've already completed the goal: {GetName()}.");
        }
    }

    public void LoadProgress(bool isCompleted)
    {
        SetCompleted(isCompleted);
    }
}