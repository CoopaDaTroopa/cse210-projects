using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        BreathingActivity b1 = new BreathingActivity("Welcome", "Breathing activity", "You will breathe");
        //b1.RunBA();
        ReflectingActivity r1 = new ReflectingActivity("Welcome", "Reflecting Activity", "You will think(I hope)");
        //r1.RunRA();
        ListingActivity l1 = new ListingActivity("Welcome", "Listing Activity", "You will list");
        //l1.RunLA();
        ImagineActivity I1 = new ImagineActivity("Welcome", "Imagine Activity", "You will imagine");
        while (running)
        {
            Console.WriteLine("Welcome to relaxing Activitys! Please choose an activity!");
            Console.WriteLine("1. Breathing Activity\n2. Reflecting Activity\n3. Listing Activity\n4. Imagine Activity\n5. Quit");
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
            else if (answer == "4")
            {
                I1.runIA();
            }
            else if (answer == "5")
            {
                running = false;
            }
        }
    }
}