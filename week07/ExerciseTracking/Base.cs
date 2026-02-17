// Base class for activities
using System;
public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public string GetDate()
    {
        return _date;
    }

    // Polymorphic methods
    public abstract double GetDistance(); // miles
    public abstract double GetSpeed();    // mph
    public abstract double GetPace();     // min per mile

    public virtual string GetSummary()
    {
        return $"{_date} ({_minutes} min): " +
               $"Distance {GetDistance():0.00} miles, " +
               $"Speed {GetSpeed():0.00} mph, " +
               $"Pace {GetPace():0.00} min/mile";
    }
}