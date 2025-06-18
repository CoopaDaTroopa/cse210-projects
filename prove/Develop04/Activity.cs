public class Activity
{
    private string _startMessage;
    private string _activityName;
    private string _description;
    protected int _time;


    public Activity(string startMessage, string activityName, string description)
    {
        _startMessage = startMessage;
        _activityName = activityName;
        _description = description;
    }




    public void StartMessage()
    {
        Console.WriteLine(_startMessage);
        Thread.Sleep(1000);
        Console.WriteLine($"You have chosen: {_activityName}");
        Thread.Sleep(1000);
        Console.WriteLine(_description);
        Thread.Sleep(1000);
    }


    public void EndMessage()
    {
        Console.WriteLine("Great Job!");
        Thread.Sleep(2500);
        Animation(2);
        Console.WriteLine($"You have completed the {_activityName}");
        Thread.Sleep(3000);
    }


    public void Animation(int time)
    {
        for (int i = 0; i < time; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
        }
        Console.WriteLine();
    }


    public void RequestTime()
    {
         Console.WriteLine("How many seconds would you like to do this activity for?");
        _time = int.Parse(Console.ReadLine());
    }
} 