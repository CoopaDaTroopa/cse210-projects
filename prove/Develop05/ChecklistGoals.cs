using System.Diagnostics.Metrics;

public class CheckListGoal : Goal
{
    private int _list;
    private int _counter;
    private int _finishPoints;

    public CheckListGoal(string activityType, string name, string description, int points, int list, int fPoints) : base(activityType, name, description, points)
    {
        _list = list;
        _counter = 0;
        _finishPoints = fPoints;
    }
    public CheckListGoal(string activityType, string name, string description, int points, int list, int fPoints, int counter) : base(activityType, name, description, points)
    {
        _list = list;
        _counter = counter;
        _finishPoints = fPoints;
    }




    public override void DisplayGoal()
    {
        string complete = $"{_counter}/{_list}";
        if (_list == _counter)
        {
            complete = "X";
        }
        Console.WriteLine($"[{complete}] {GetAType()}: {GetName()}  Description: {GetDes()}");
    }





    public override int RecordGoal()
    {
        if (_counter != _list)
        {
            _counter++;
            if (_counter != _list)
            {
                return GetPoints();
            }
            else
            {
                return _finishPoints;
            }
        }
        else
        {
            Console.WriteLine("This Goal is already complete");
            return 0;
        }


    }



    public override string Save()
    {
        return $"{GetAType()}@{GetName()}@{GetDes()}@{GetPoints()}@{_list}@{_finishPoints}@{_counter}";
    }
    
    public static CheckListGoal LoadCG(string info)
    {
        List<string> infoList = new List<string>(info.Split(new[] { '@' }, StringSplitOptions.RemoveEmptyEntries)); // i was lazy and made AI make this for me
        CheckListGoal g = new CheckListGoal(infoList[0], infoList[1], infoList[2], int.Parse(infoList[3]), int.Parse(infoList[4]), int.Parse(infoList[5]), int.Parse(infoList[6]));
        return g;
    }



}