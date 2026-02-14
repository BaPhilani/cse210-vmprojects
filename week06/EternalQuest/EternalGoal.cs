//EternalGoal.cs is repeatable and becomes complete once we add the following code to it:
using System;
class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You've made progress on the eternal goal: {GetName()} and earned {GetPoints()} points!");
    }
}