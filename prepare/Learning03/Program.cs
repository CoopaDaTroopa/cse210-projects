using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(5, 3);
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine($"{f3.GetDenominator()}");
        Console.WriteLine($"{f3.GetNumerator()}");
        f3.SetNumerator(9);
        Console.WriteLine($"{f3.GetDecimalValue()}");
        Console.WriteLine($"{f3.GetFractionString}");
        

    }
}