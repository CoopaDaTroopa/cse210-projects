using System.Reflection;

public class Fraction
{
    public int _denominator; //bottom number
    public int _numberator; //top number


    public Fraction()
    {
        _denominator = 1;
        _numberator = 1;
    }
    public Fraction(int numerator)
    {
        _denominator = 1;
        _numberator = numerator;
    }
    public Fraction(int numerator, int denominator)
    {
        _denominator = denominator;
        _numberator = numerator;
    }

    public string GetFractionString()
    {
        return $"{_numberator}/{_denominator}";
    }
    public double GetDecimalValue()
    {
        double dec = _numberator / _denominator;
        return dec;
    }
    public void SetNumerator(int numerator)
    {
        _numberator = numerator;
    }
    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }
    public int GetNumerator()
    {
        return _numberator;
    }
    public int GetDenominator()
    {
        return _denominator;
    }
}