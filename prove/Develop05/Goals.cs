using System.ComponentModel;

public abstract class Goal
{
    private int _points;
    private string _activityType;
    private string _name;
    private string _description;

    public Goal(string activityType, string name, string description, int points)
    {
        _activityType = activityType;
        _name = name;
        _description = description;
        _points = points;
    }


    public virtual void AddPoints()
    { }


    //i can add static to my methods to use them without having an object in main, so i can do Goal.AddGoal(); instead of making a new dummy object to call it
    public static Goal AddGoal()
    {
        string activityType;
        string name;
        string description;
        int points;
        Console.WriteLine("What type of goal would you like to set?\n1. Eternal\n2. CheckList\n3. Simple");
        string ans = Console.ReadLine();
        if (ans == "1")
        {
            activityType = "Eternal Goal";
            Console.WriteLine("What would you like to name this goal?");
            name = Console.ReadLine();
            Console.WriteLine("What would you like the description to be?");
            description = Console.ReadLine();
            Console.WriteLine("How many points would you like allocated for completeing this goal?");
            points = int.Parse(Console.ReadLine());
            EternalGoal eg = new EternalGoal(activityType, name, description, points);
            return eg;
        }
        if (ans == "2")
        {
            activityType = "CheckList Goal";
            Console.WriteLine("What would you like to name this goal?");
            name = Console.ReadLine();
            Console.WriteLine("What would you like the description to be?");
            description = Console.ReadLine();
            Console.WriteLine("How many points would you like for accomplishing a portion of this goal?");
            points = int.Parse(Console.ReadLine());
            Console.WriteLine("How many points would you like allocated for completeing this goal?");
            int fPoints = int.Parse(Console.ReadLine());
            Console.WriteLine("How many times do you want to accomplish this goal until it is finished?");
            int list = int.Parse(Console.ReadLine());
            CheckListGoal cg = new CheckListGoal(activityType, name, description, points, list, fPoints);
            //string activityType, string name, string description, int points, int list, int fPoints, int counter
            return cg;
        }
        if (ans == "3")
        {
            activityType = "Simple Goal";
            Console.WriteLine("What would you like to name this goal?");
            name = Console.ReadLine();
            Console.WriteLine("What would you like the description to be?");
            description = Console.ReadLine();
            Console.WriteLine("How many points would you like allocated for completeing this goal?");
            points = int.Parse(Console.ReadLine());
            SimpleGoal sg = new SimpleGoal(activityType, name, description, points);
            return sg;
        }
        else
        {
            return null;
        }

    }


    public static void DisplayScore(List<Goal> list)
    {
        int score = 0;
        foreach (Goal goal in list)
        {
            score += goal._points;
        }
        Console.WriteLine($"score");
    }

    public virtual int RecordGoal()
    {
        return 0;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual void DisplayGoal() { }


    public virtual string Save()
    {
        return "";
    }
    public static List<Goal> Load(string fileName)
    {
        List<Goal> list = new List<Goal>();
        List<string> gList = new List<string>(File.ReadAllLines(fileName));
        gList.RemoveAt(0);
        string type = "";
        foreach (string line in gList)
        {
            type = line.Substring(0, line.IndexOf("@"));
            if (type == "Simple Goal")
            {
                list.Add(SimpleGoal.LoadSG(line));
            }
            else if (type == "CheckList Goal")
            {
                list.Add(CheckListGoal.LoadCG(line));
            }
            else if (type == "Eternal Goal")
            {
                list.Add(EternalGoal.LoadEG(line));
            }
        }
        return list;

    }




    public string GetAType()
    {
        return _activityType;
    }
    public string GetDes()
    {
        return _description;
    }
    public string GetName()
    {
        return _name;
    }
}