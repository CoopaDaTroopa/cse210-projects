public class SimpleGoal : Goal
{
    private bool _complete;
    public SimpleGoal(string activityType, string name, string description, int points, bool complete) : base(activityType, name, description, points)
    {
        _complete = complete;
    }
    public SimpleGoal(string activityType, string name, string description, int points) : base(activityType, name, description, points)
    {
        _complete = false;
    }

    public override void DisplayGoal()
    {
        string complete = " ";
        if (_complete == true)
        {
            complete = "X";
        }
        Console.WriteLine($"[{complete}] {GetAType()}: {GetName()}  Description: {GetDes()}");
    }

    public override int RecordGoal()
    {
        if (_complete != true)
        {
            _complete = true;
            return GetPoints();
        }
        else
        {
            Console.WriteLine("You have already completed this goal.");
            return 0;
        }
    }


    public override void Save(string fileName)
    {
        File.Create(fileName).Close();
        bool c;
        if (_complete == false)
        {
            c = false;
        }
        else
        {
            c = true;
        }
        //File.AppendAllText(fileName, $"{GetAType()}@{GetName()}@{GetDes()}@{GetPoints()}@{c}" + Environment.NewLine);
        using (StreamWriter sw = File.AppendText(fileName))
        {
            sw.Write($"{GetAType()}@{GetName()}@{GetDes()}@{GetPoints()}@{c}");
            //string activityType, string name, string description, int points, bool complete
        }
    }


    public static SimpleGoal LoadSG(string info)
    {
        //List<string> infoList = new List<string>(info.Split(new[] { '@' }, StringSplitOptions.RemoveEmptyEntries));
        string[] infoList = info.Split('@', StringSplitOptions.RemoveEmptyEntries);
        bool c = true;
        if (infoList[4] == "false")
        {
            c = false;
        }
        SimpleGoal g = new SimpleGoal(infoList[0], infoList[1], infoList[2], int.Parse(infoList[3]), c);
        return g;
    }


}