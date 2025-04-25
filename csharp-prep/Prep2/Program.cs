using System;

class Program
{
    static void Main(string[] args)
    {
        string lGrade = "";
        Console.Write("What was your grade percentage? ");
        int gr = int.Parse(Console.ReadLine());
        if(gr >= 90){
            lGrade = "A";
            Console.WriteLine("YOU PASSED!");
        } else if(gr >= 80){
            lGrade = "B";
            Console.WriteLine("YOU PASSED!");
        } else if(gr >= 70){
            lGrade = "C";
            Console.WriteLine("YOU PASSED!");
        } else if(gr >= 60){
            lGrade = "D";
            Console.WriteLine("You failed. Better luck next time!");
        } else {
            lGrade = "F";
            Console.WriteLine("You failed. Better luck next time!");
        }
        Console.WriteLine(lGrade);
    }
}