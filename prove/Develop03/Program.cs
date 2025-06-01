using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string quit = "";
        Scripture s1 = new Scripture("And it came to pass that as I was thus racked with torment, while I was harrowed up by the memory of my many sins, behold, I remembered also to have heard my father prophesy unto the people concerning the coming of one Jesus Christ, a Son of God, to atone for the sins of the world.");
        Reference r1 = new Reference("Alma", "17");
        Word word = new Word("");
        Console.Clear();
        Console.WriteLine("Press enter to hide words or quit to exit");
        Console.WriteLine(r1.giveRef());
        s1.PrintVerse();
        int entersMax = s1.GetWords().Count();
        entersMax = (entersMax - entersMax % 3)/3;
        int enters = 0;
        
        //Console.ReadKey().Key != ConsoleKey.Enter
        while (quit != "quit")
        {
            if (Console.ReadLine() != "quit" && enters != entersMax -1)
            { //make it so pressing once runs code but also that quit works, make it end when all spaces are filled
                Console.Clear();
                Console.WriteLine("Press enter to hide words or quit to exit");
                s1.setVerse(s1.ReplaceWithBlank(word));
                Console.WriteLine(r1.giveRef());
                s1.PrintVerse();
                enters++;
            }
            else
            {
                quit = "quit";
                Console.Clear();
            }
        }
    }
}