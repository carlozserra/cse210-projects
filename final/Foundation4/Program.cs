using System;

class Program
{
    static void Main(string[] args)
    {
       List<Activity> activities = new List<Activity>
        {
            new Running("03 Apr 2024", 30, 4.8),
            new Swimming("04 Jan 2024", 40, 20),
            new Biking("05 Oct 2024", 50, 15)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetActivitySummary());
        }
    }
}