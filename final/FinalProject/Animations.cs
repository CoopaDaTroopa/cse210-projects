public class Animations
{
    public static void Type(string sentence)
    {
        List<char> charList = new List<char>(sentence);
        foreach (char c in charList)
        {
            Console.Write(c);
            Thread.Sleep(75);
        }
        Thread.Sleep(75);
        Console.WriteLine();
    }
}