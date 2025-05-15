public class Entry{
//make a method that prompts user for entry and return a string that is the date, prompt and their reply 
    public string[] _prompts = ["What was your favorite part of the day?", "What was your least favorite part of the day?",
    "What was the most unexpected thing that happened today?", "What was something you wished you did differnt today?",
    "What are you most proud of from today?"];
    public string newEntry = "";

    public void AddEntry(List<string> list){
        Random rnd = new Random();
        newEntry = "";
        string prompt = _prompts[rnd.Next(1, 5)];
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        newEntry += dateText + " ";
        newEntry += prompt + " ";
        Console.WriteLine(prompt);
        newEntry += Console.ReadLine();
        list.Add(newEntry);
    }
}