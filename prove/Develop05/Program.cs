using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        bool running = true;
        int score = 0;
        Console.WriteLine("Welcome!");
        //string menu = $"Score: {score}\nMenu:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit";
        while (running)
        {
            Console.WriteLine($"Score: {score}\nMenu:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            string ans = Console.ReadLine();
            if (ans == "1")
            {
                goals.Add(Goal.AddGoal());
            }
            else if (ans == "2")
            {
                foreach (Goal g in goals)
                {
                    g.DisplayGoal();
                }
            }
            else if (ans == "3")
            {
                Console.WriteLine("What file would you like to save to?");
                string fileName = Console.ReadLine();
                File.Create(fileName).Close();
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    sw.WriteLine($"{score}");
                    foreach (Goal g in goals)
                    {
                        sw.WriteLine(g.Save());
                    }
                }
            }
            else if (ans == "4")
            {
                Console.WriteLine("What file would you load?");
                string fileName = Console.ReadLine();
                score = int.Parse(File.ReadLines(fileName).First());
                goals = Goal.Load(fileName);
            }
            else if (ans == "5")
            {
                Console.WriteLine("By name, what goal would you like to record?");
                string name = Console.ReadLine();
                int index = 0;
                bool happened = false;
                foreach (Goal g in goals)
                {
                    if (g.GetName() == name)
                    {
                        score += goals[index].RecordGoal();
                        goals[index].DisplayGoal();
                        Thread.Sleep(1000);
                        happened = true;
                    }
                    index++;
                }
                if (!happened)
                {
                    Console.WriteLine("Sorry, I could not find a goal that matched that name");
                }
            }
            else if (ans == "6")
            {
                running = false;
                Thread.Sleep(2000);
                Console.WriteLine("Good-bye!");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("Sorry, that is not a valid choice.\nPlease choose again");
            }
        }

    }
}





//Console.WriteLine("What file would you like to save to? ");
        //string _fileName = Console.ReadLine();
        //File.Create(_fileName).Close();
        //using(StreamWriter sw = File.AppendText(_fileName)){
            //foreach(string entry in _entrys){
                //sw.Write($"{entry}%");