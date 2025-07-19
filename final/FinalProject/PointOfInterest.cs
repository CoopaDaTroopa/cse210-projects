public class POI
{
    private string _name { get; set; }
    private Item _item;
    private string _des { get; set; }

    public POI(string name, string description)
    {
        _name = name;
        _des = description;
        _item = null;
    }
    public POI(string name, string description, Item item)
    {
        _name = name;
        _des = description;
        _item = item;
    }


    public Item Search()
    {
        Animations.Type(_des); // include the action of approaching and opening poi
        return _item;
    }


    public string GetName()
    {
        return (_name);
    }

    public void Empty()
    {
        _des = $"The {_name} is empty.";
        _item = null;
    }
}