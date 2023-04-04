using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("03 Nov 2022", 30, 4.8f);
        Cycling cycling = new Cycling("04 Nov 2022", 30, 20.4f);
        Swimming swimming = new Swimming ("02 Nov 2023", 30, 5.5f);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}