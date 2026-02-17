// Program.cs - Main program for exercise tracking application with no user input, just hardcoded activities for demonstration.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("03 Nov 2022", 30, 3.0));
        activities.Add(new Cycling("03 Nov 2022", 45, 12.0));
        activities.Add(new Swimming("03 Nov 2022", 40, 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}