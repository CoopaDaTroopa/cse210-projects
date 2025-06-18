using System.Runtime.CompilerServices;

public class ReflectingActivity : Activity
{

    private List<string> _prompts = ["Think of a time you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
    private List<string> _questions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time differnt then other times when you were not successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself from this experience?", "How can you keep this experience in mind in the future?"];

    public ReflectingActivity(string activityName, string startMessage, string description) : base(activityName, startMessage, description){}
    


    public void RunRA()
    {
        Random rand = new Random();
        int r = rand.Next(_prompts.Count());
        StartMessage();
        //Console.WriteLine("How many seconds would you like ro run this activity? ");
        //_time = int.Parse(Console.ReadLine());
        RequestTime();
        while (_time < 20)
        {
            Console.WriteLine("Youre gonna need more time then that!(I know your mind) Please choose another count: ");
            _time = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(_prompts[r]);
        Thread.Sleep(3000);
        _time = _time - (_time % 5);
        _time = _time / 5;
        for (int i = 0; i < _time; i++)
        {
            Console.WriteLine(_questions[i]);
            Animation(5);
        }

        EndMessage();
    }

}