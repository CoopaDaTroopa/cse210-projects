using System;

class Program
{
    static void Main(string[] args)
    {
        displayWelcome();
        string name = promptUserName();
        int favNum = promptUserNumber();
        int sqNum = sqNumber(favNum);
        result(sqNum, name);
    }


    static void displayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }
    static string promptUserName(){
        Console.Write("Please Enter Your Name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int promptUserNumber(){
        Console.Write("What is your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
    static int sqNumber(int num){
        int sqNum = num*num;
        return sqNum;
    }
    static void result(int num, string name){
        Console.WriteLine($"{name}, the square of your number is {num}");
    }
}