//Goal class is the base classwith common data and abstract methods.
//It has properties for name, description, points, and completion status, along with methods to get these properties and an abstract method RecordEvent() that will be implemented by derived classes.
using System;
abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _isCompleted;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = false;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public bool IsCompleted()
    {
        return _isCompleted;
    }

    protected void MarkCompleted()
    {
        SetCompleted(true);
    }

    protected void SetCompleted(bool isCompleted)
    {
        _isCompleted = isCompleted;
    }

    public abstract void RecordEvent();
}