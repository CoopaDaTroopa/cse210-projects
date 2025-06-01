public class Reference
{
    // in this class I will only make 2 constructs for a reference with 1 verse and another for
    //multiple verses. Edit: I will make a method that returns the full reference
    private string _book;
    private string _verseNum;
    private string _verseNumToo = "";
    public Reference(string book, string verseNum)
    {
        _book = book;
        _verseNum = verseNum;
    }
    public Reference(string book, string verseNum, string verseNumToo)
    {
        _book = book;
        _verseNum = verseNum;
        _verseNumToo = verseNumToo;
    }


    public string giveRef()
    {
        string reference = "";
        if (_verseNumToo == "")
        {
            reference = _book + " " + _verseNum;
        }
        else
        {
            reference = _book + " " + _verseNum + ":" + _verseNumToo;
        }
        return reference;
    }
}