using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running { Date = new DateTime(2023, 07, 12), LengthInMinutes = 50, Distance = 3.0 },
            new Cycling { Date = new DateTime(2023, 07, 10), LengthInMinutes = 60, Speed = 6.0 },
            new Swimming { Date = new DateTime(2023, 07, 11), LengthInMinutes = 30, Laps = 30 }
        };

        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.Summary());
        }
    }
}
