using System.IO;
using System.Reflection.PortableExecutable;
public class Journal{
    public List<string> _entrys = new List<string>();
    //List<int> termsList = new List<int>();


    public void SaveFile(){
        // this will delete all previous entrys on text file and add new ones
        Console.WriteLine("What file would you like to save to? ");
        string _fileName = Console.ReadLine();
        File.Create(_fileName).Close();
        using(StreamWriter sw = File.AppendText(_fileName)){
            foreach(string entry in _entrys){
                sw.Write($"{entry}%");
            }
        }
    }
    public void LoadFile(){
        _entrys = [];
        //this will open the chosen text file and put all entrys into a new string list
        Console.WriteLine("What file would you like to load? ");
        string _fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {   
            string[] allEntrys = line.Split("%");
            foreach(string section in allEntrys){
                _entrys.Add(section);
            }
        }
        
    }

    public void Display(){
        foreach(string line in _entrys){
            Console.WriteLine(line);
        }
    }
}
