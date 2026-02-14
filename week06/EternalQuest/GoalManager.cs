//GoalMnager.cs handles the creation of goals and the recording of events for those goals. 
//It also keeps track of the total points earned by the player.
using System;
using System.Collections.Generic;
using System.IO;
class GoalManager
{
    private List<Goal> _goals;
    private int _totalPoints;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    // to add GetGoals() method to return the list of goals,
    // allowing other parts of the program to access and display the goals as needed.
    public List<Goal> GetGoals()
    {
        return _goals;
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            bool wasCompleted = goal.IsCompleted();
            goal.RecordEvent();
            int pointsEarned = 0;

            if (goal is EternalGoal)
            {
                pointsEarned = goal.GetPoints();
            }
            else if (goal is SimpleGoal)
            {
                if (!wasCompleted && goal.IsCompleted())
                {
                    pointsEarned = goal.GetPoints();
                }
            }
            else if (goal is ChecklistGoal)
            {
                if (!wasCompleted)
                {
                    pointsEarned = goal.GetPoints();
                }
            }

            if (pointsEarned > 0)
            {
                _totalPoints += pointsEarned;
                Console.WriteLine($"You earned {pointsEarned} points! Total points: {_totalPoints}.");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void SaveGoals(string filePath)
    {
        List<string> lines = new List<string>();
        lines.Add(_totalPoints.ToString());

        foreach (Goal goal in _goals)
        {
            if (goal is SimpleGoal)
            {
                lines.Add($"SimpleGoal|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.IsCompleted()}");
            }
            else if (goal is EternalGoal)
            {
                lines.Add($"EternalGoal|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}");
            }
            else if (goal is ChecklistGoal checklist)
            {
                lines.Add($"ChecklistGoal|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{checklist.GetTargetCount()}|{checklist.GetCurrentCount()}|{goal.IsCompleted()}");
            }
        }

        File.WriteAllLines(filePath, lines);
    }

    public bool LoadGoals(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return false;
        }

        string[] lines = File.ReadAllLines(filePath);
        if (lines.Length == 0)
        {
            Console.WriteLine("File is empty.");
            return false;
        }

        List<Goal> loadedGoals = new List<Goal>();
        int loadedPoints = 0;
        int.TryParse(lines[0], out loadedPoints);

        for (int i = 1; i < lines.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(lines[i]))
            {
                continue;
            }

            string[] parts = lines[i].Split('|');
            if (parts.Length < 4)
            {
                continue;
            }

            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            if (!int.TryParse(parts[3], out int points))
            {
                continue;
            }

            if (type == "SimpleGoal" && parts.Length >= 5)
            {
                bool isCompleted = false;
                bool.TryParse(parts[4], out isCompleted);
                SimpleGoal goal = new SimpleGoal(name, description, points);
                goal.LoadProgress(isCompleted);
                loadedGoals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                loadedGoals.Add(new EternalGoal(name, description, points));
            }
            else if (type == "ChecklistGoal" && parts.Length >= 7)
            {
                if (int.TryParse(parts[4], out int targetCount) && int.TryParse(parts[5], out int currentCount))
                {
                    bool isCompleted = false;
                    bool.TryParse(parts[6], out isCompleted);
                    ChecklistGoal goal = new ChecklistGoal(name, description, points, targetCount);
                    goal.LoadProgress(currentCount, isCompleted);
                    loadedGoals.Add(goal);
                }
            }
        }

        _goals = loadedGoals;
        _totalPoints = loadedPoints;
        return true;
    }
}