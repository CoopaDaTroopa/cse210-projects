using System.Runtime.Serialization;

public class Key : Item
{
    private string _name;
    private string _opens;
    public Key(string type, string name, string des, string opens) : base(type, name, des)
    {
        _name = name;
        _opens = opens;
    }


    public override void UseItem(Room r, Character player)
    {
        if (r.getKey() == _name)
        {
            if (_opens == "n")
            {
                r.setNorth();
                r.ResetKey();
            }
            else if (_opens == "s")
            {
                r.setSouth();
                r.ResetKey();
            }
            else if (_opens == "w")
            {
                r.setWest();
                r.ResetKey();
            }
            else if (_opens == "e")
            {
                r.setEast();
                r.ResetKey();
            }
        }
        else if (r.getKey() != "" && r.getKey() != _name)
        {
            Animations.Type("The key doesnt fit.");
        }
        else
        {
            Animations.Type("There is no where to use that key in this room.");
        }
    }
}