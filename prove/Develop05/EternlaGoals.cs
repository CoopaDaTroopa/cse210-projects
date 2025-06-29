public class EternalGoal : Goal
{
    private int _records;
    public EternalGoal(string activityType, string name, string description, int points) : base(activityType, name, description, points)
    {
        _records = 0;
    }
    public EternalGoal(string activityType, string name, string description, int points, int records) : base(activityType, name, description, points)
    {
        _records = records;
    }



    public override void DisplayGoal()
    {
        Console.WriteLine($"[{_records}] {GetAType()}: {GetName()}  Description: {GetDes()}");
    }


    public override int RecordGoal()
    {
        _records++;
        return GetPoints();
    }



    public override void Save(string fileName)
    {
        File.Create(fileName).Close();
        using (StreamWriter sw = File.AppendText(fileName))
        {
            sw.WriteLine($"{GetAType()}@{GetName()}@{GetDes()}@{GetPoints()}@{_records}");
            //string activityType, string name, string description, int points, int records
        }
    }

    public static EternalGoal LoadEG(string info)
    {
        List<string> infoList = new List<string>(info.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)); // i was lazy and made AI make this for me
        EternalGoal g = new EternalGoal(infoList[0], infoList[1], infoList[2], int.Parse(infoList[3]), int.Parse(infoList[4]));
        return g;
    }
}