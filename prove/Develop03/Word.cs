public class Word
{
    public string _word;



    public Word(string word)
    {
        _word = word;
    }
    public void setWord(string word)
    {
        _word = word;
    }
    //returns a a string of _ with the same characters as word
    public string giveBlank()
    {
        string blank = "";
        for (int i = 1; i <= _word.Length; i++)
        {
            blank += "_";
        }
        return blank;
    }
}