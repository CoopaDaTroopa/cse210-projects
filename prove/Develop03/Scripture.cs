using System.Data.Common;

public class Scripture
{
    private string _verse;
    private List<string> _words = new List<string>();
    //private Word word;



    public Scripture(string verse)
    {
        _verse = verse;
        _words = _verse.Split(' ').ToList();
    }


    public string ReplaceWithBlank(Word word)
    {
        Random rnd = new Random();
        string fVerse = "";
        for (int i = 0; i <= 2; i++)
        {
            int num = rnd.Next(0, _words.Count());
            while (_words[num].IndexOf("_") != -1)
            {
                num = rnd.Next(0, _words.Count());
            }
            word.setWord(_words[num]);
            _words[num] = word.giveBlank();
        }
        foreach (string a in _words)
        {
            if (a.IndexOf(".") == -1)
            {
                fVerse += a + " ";
            }
            else
            {
                fVerse += a;
            }
        }
        return fVerse;
    }

    public void PrintVerse()
    {
        int count = 0;
        foreach (string a in _words)
        {
            if (a.IndexOf(".") == -1)
            {
                if (count == 18)
                {
                    Console.WriteLine();
                    count = 0;
                }
                Console.Write(a + " ");
                count++;
            }
            else
            {
                Console.Write(a);
            }
        }
        Console.WriteLine();
    }

    public void setVerse(string verse)
    {
        _verse = verse;
    }
    public List<string> GetWords()
    {
        return _words;
    }
}