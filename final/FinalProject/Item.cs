public class Item
{
    private string _name;
    private string _des;
    private string _type;
    private int _damage;
    public string GetName()
    {
        return _name;
    }
    public Item(string type, string name, string des)
    {
        _name = name;
        _des = des;
        _type = type;
    }
    public Item(string type, string name, string des, int damage)
    {
        _name = name;
        _des = des;
        _type = type;
        _damage = damage;
    }

    public virtual void DisplayItem()
    {
        Animations.Type($"Item: {_name}");
        Animations.Type($"Description: {_des}");
    }

    public virtual void UseItem(Room r, Character player)
    {
        Animations.Type("This is not a useable item.");
    }

    public string GetItemType()
    {
        return _type;
    }
    public int GetDamage()
    {
        return _damage;
    }
}