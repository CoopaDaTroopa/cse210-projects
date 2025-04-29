using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int num = 1;
        int avg = 0;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while(num != 0){
            Console.Write("Enter Number: ");
            num = int.Parse(Console.ReadLine());
            if(num != 0){
                numbers.Add(num);
            }
        }
        int max = 0;
        foreach(int number in numbers){
            avg += number;
            if(number > max){
                max = number;
            }
        }
        avg /= numbers.Count;
        Console.WriteLine($"The Avg is: {avg}");
        Console.WriteLine($"The largest number is: {max}");

    }
}