public class BreathingActivity : Activity
{



    public BreathingActivity(string activityName, string startMessage, string description) : base(activityName, startMessage, description)
    {
    }



    public void Breathe(int time)
    {
        time = time / 5;
        time = (time - (time % 2)) / 2;
        for (int i = 0; i < time; i++)
        {
            Console.WriteLine("Breathe in");
            Thread.Sleep(1000);
            Animation(4);
            Console.WriteLine("Breathe out");
            Thread.Sleep(1000);
            Animation(4);
        }
    }
    public void RunBA()
    {
        //this will run a breathing activity with its included functions
        StartMessage();
        //Console.WriteLine("How many seconds would you like to do this activity for?");
        //_time = int.Parse(Console.ReadLine());
        RequestTime();
        while (_time < 20)
        {
            Console.WriteLine("Youre gonna need more time then that!(I know your mind) Please choose another count: ");
            _time = int.Parse(Console.ReadLine());
        }
        _time = _time - (_time % 5);
        Breathe(_time);
        EndMessage();
    }
}