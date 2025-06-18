using System.Runtime.CompilerServices;

public class ImagineActivity : Activity
{
    public ImagineActivity(string activityName, string startMessage, string description) : base(activityName, startMessage, description)
    {
        activityName = "Imagine Activity";
        startMessage = "Welcome!";
        description = "You will imagine";
    }

    private List<string> _prompts = ["Imagine being on a beach.", "Imagine spending time with your best friend.", "Imagine laying in a hammock.", "Imagine crushing those who oppose you.", "Imagine playing with puppys and kittens.", "Imagine sitting by a small waterfall.", "Imagine being debt free."];



    public void runIA()
    {
        StartMessage();
        RequestTime();
        _time = _time - (_time % 5);
        _time = _time / 5;
        for (int i = 0; i < _time; i++)
        {
            Console.WriteLine(_prompts[i]);
            Animation(5);
        }
        EndMessage();
    }

}