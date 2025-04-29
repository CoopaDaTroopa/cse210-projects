using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 100);
        Console.WriteLine("The magic number is Chosen!");
        int guess = 0;
        while(guess != magicNum){
            Console.Write("What is your guess: ");
            guess = int.Parse(Console.ReadLine());
            if(guess == magicNum){
                Console.WriteLine("Thats Correct!");
            } else if(guess > magicNum){
                Console.WriteLine("Too high!");
            }else{
                Console.WriteLine("Too Low!");
            }

        }
        Console.WriteLine("You Got It!!");
    }
}