using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity b1 = new BreathingActivity("Welcome", "Breathing activity", "You will breathe");
        //b1.RunBA();
        ReflectingActivity r1 = new ReflectingActivity("Welcome", "Reflecting Activity", "You will think(I hope)");
        //r1.RunRA();
        ListingActivity l1 = new ListingActivity("Welcome", "Listing Activity", "You will list");
        //l1.RunLA();
        Console.WriteLine("Welcome to Listing Activitys! Please choose an activity!");
        Console.WriteLine("1. Breathing Activity\n2. Reflecting Activity\n3. Listing Activity");
        string answer = Console.ReadLine();
        if (answer == "1")
        {
            b1.RunBA();
        }
        else if (answer == "2")
        {
            r1.RunRA();
        }
        else if (answer == "3")
        {
            l1.RunLA();
        }
        
    }
}