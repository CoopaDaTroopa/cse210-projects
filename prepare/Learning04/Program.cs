using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Cooper Bench", "Calculus");
        a1.GetSummary();
        MathAssignment m1 = new MathAssignment("Cooper Bench", "Calculus", "5.5", "1-10");
        m1.GetHomeWorkList();
        WritingAssignment w1 = new WritingAssignment("Cooper Bench", "Best Books of the 1930's", "Mein Kampf");
        w1.GetWritingInfo();
    }
}