public class Room
{
    private bool _south{ get; set; } // this is used like Room._south
    private bool _north{ get; set; }
    private bool _west{ get; set; }
    private bool _east{ get; set; }
    private Item _item1{ get; set; }
    private Item _item2{ get; set; }
    private string _description{ get; set; }

    public Room(bool south, bool north, bool west, bool east, string description)
    {
        _south = south;
        _north = north;
        _west = west;
        _east = east;
        _description = description;
        //_item1 = null;
        //_item2 = null;
    }
    public Room(bool south, bool north, bool west, bool east, string description, Item item1)
    {
        _south = south;
        _north = north;
        _west = west;
        _east = east;
        _description = description;
        _item1 = item1;
        _item2 = null;
    }
    public Room(bool south, bool north, bool west, bool east, string description, Item item1, Item item2)
    {
        _south = south;
        _north = north;
        _west = west;
        _east = east;
        _description = description;
        _item1 = item1;
        _item2 = item2;
    }

    public bool MoveRoom(string direction)
    {
        direction = direction.ToLower();
        if (direction == "north" && _north == true)
        {
            return true;
        }
        else if (direction == "south" && _south == true)
        {
            return true;
        }
        else if (direction == "west" && _west == true)
        {
            return true;
        }
        else if (direction == "east" && _east == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}