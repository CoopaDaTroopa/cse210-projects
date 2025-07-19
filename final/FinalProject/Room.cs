using System;
using System.Diagnostics.Contracts;
public class Room
{
    private bool _south; // this is used like Room._south
    private bool _north;
    private bool _west;
    private bool _east;
    private Item _item;
    private string _description { get; set; }
    private POI _poi;
    private string _key;
    private Enemy _enemy = null;
    private string _locked;

    public Room(bool south, bool north, bool west, bool east, string description, string key, string locked)
    {
        _south = south;
        _north = north;
        _west = west;
        _east = east;
        _description = description;
        _key = key;
        _locked = locked;
        _item = null;
        _poi = null;
    }
    public Room(bool south, bool north, bool west, bool east, string description, string key, string locked, Enemy enemy)
    {
        _south = south;
        _north = north;
        _west = west;
        _east = east;
        _description = description;
        _key = key;
        _enemy = enemy;
        _locked = locked;
        _item = null;
        _poi = null;
    }
    public Room(bool south, bool north, bool west, bool east, string description, string key, string locked, Item item)
    {
        _south = south;
        _north = north;
        _west = west;
        _east = east;
        _description = description;
        _key = key;
        _locked = locked;
        _item = item;
        _poi = null;
    }
    public Room(bool south, bool north, bool west, bool east, string description, string key, string locked, POI poi)
    {
        _south = south;
        _north = north;
        _west = west;
        _east = east;
        _description = description;
        _key = key;
        _locked = locked;
        _poi = poi;
        _item = null;
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

    public Item Search(string search) //dont put an item and POI in the same room
    {
        if (_poi == null)
        {
            Animations.Type(_description);
            return null;
        }
        string poi = "";
        if (search.Length > 6)
        {
            poi = search.Substring(search.IndexOf(" ") + 1);
        }
        else
        {
            Animations.Type(_description);
        }
        if (_poi != null && search.Length > 6)
        {
            if (_poi.GetName() != poi)
            {
                Animations.Type("Sorry, that is not a proper action.");
                return null;
            }
        }
        if (_item != null)
        {
            return _item;
        }
        if (_poi != null && search.Length > 6)
        {
            if (_poi.GetName() == poi)
            {
                return _poi.Search();
            }
            else
            {
                Animations.Type("You find nothing");
                return null;
            }
        }
        else
        {
            return null;
        }
    }



    public void setNorth()
    {
        _north = true;
    }
    public void setSouth()
    {
        _south = true;
    }
    public void setWest()
    {
        _west = true;
    }
    public void setEast()
    {
        _east = true;
    }

    public string getKey()
    {
        return _key;
    }

    public void ChangeDes(string des)
    {
        _description = des;
    }
    public bool GetEnemy()
    {
        if (_enemy == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public Enemy GiveEnemy()
    {
        return _enemy;
    }
    public void KillEnemy()
    {
        _enemy = null;
    }
    public void ResetKey()
    {
        _key = "";
    }
    public void Inspect()
    {
        if (_locked == "n")
        {
            Animations.Type("The north door is locked.");
            Thread.Sleep(35);
        }
        else if (_locked == "s")
        {
            Animations.Type("The south door is locked.");
            Thread.Sleep(35);
        }
        else if (_locked == "e")
        {
            Animations.Type("The east door is locked.");
            Thread.Sleep(35);
        }
        else if (_locked == "w")
        {
            Animations.Type("The west door is locked.");
            Thread.Sleep(35);
        }
        Animations.Type("You may go:");
        if (_south)
        {
            Console.WriteLine("South");
            Thread.Sleep(35);
        }
        if (_north)
        {
            Console.WriteLine("North");
            Thread.Sleep(35);
        }
        if (_west)
        {
            Console.WriteLine("West");
            Thread.Sleep(35);
        }
        if (_east)
        {
            Console.WriteLine("East");
            Thread.Sleep(35);
        }
    }
    public POI GivePOI()
    {
        return _poi;
    }
    public string GetDescription()
    {
        return _description;
    }
}

