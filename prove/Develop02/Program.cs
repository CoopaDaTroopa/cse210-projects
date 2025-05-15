using System;

class Program
{
    static void Main(string[] args)
    {
        Entry entry = new Entry();
        Journal journal = new Journal();
        string choice = "";
        bool running = true;
        while(running){
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1.Write\n2.Display\n3.Load\n4.Save\n5.Quit");
            choice = Console.ReadLine();
            if(choice == "1"){
                entry.AddEntry(journal._entrys);
            } else if(choice == "2"){
                journal.Display();
            }else if(choice == "3"){
                journal.LoadFile();
            }else if(choice == "4"){
                journal.SaveFile();
            } else if (choice == "5"){
                running = false;
            }
        }
    }
}