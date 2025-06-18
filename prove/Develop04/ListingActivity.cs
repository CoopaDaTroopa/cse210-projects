using System.Data;
using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private List<string> _questions = new List<string> //i made AI make this list for me cuz lazy
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string activityName, string startMessage, string description)  : base(activityName, startMessage, description)
    { }
    public void RunLA()
    {
        StartMessage();
        int pressed = 0;
        Random rand = new Random();
        int r = rand.Next(_questions.Count());
        //Console.WriteLine("How many seconds would you like to run this activity? ");
        //_time = int.Parse(Console.ReadLine());
        RequestTime();
        Console.WriteLine(_questions[r]);
        Animation(4);
        Console.WriteLine("Please begin typing your response. Press enter after every response.");
        ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
        DateTime startTime = DateTime.Now;
        TimeSpan duration = TimeSpan.FromSeconds(_time);
        while (DateTime.Now - startTime < duration)
        {
            string response = Console.ReadLine();
            pressed++;
        }
        Console.WriteLine($"You have listed {pressed} items!");
        EndMessage();
    }
}