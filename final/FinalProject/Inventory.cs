public class Inventory
{
    private List<Item> _inventory = new List<Item>();
    public Inventory(List<Item> inventory)
    {
        _inventory = inventory;
    }

    public void AddItem(Item item, Character player)
    {
        _inventory.Add(item);
        if (item.GetItemType() == "weapon")
        {
            player.AddDamage(item.GetDamage());
        }
    }
    public void Display()
    {
        foreach (Item item in _inventory)
        {
            item.DisplayItem();
        }
    }
    public Item UseWhat(string name)
    {
        Item i = null;
        foreach (Item item in _inventory)
        {
            if (item.GetName() == name)
            {
                i = item;
            }

        }
        if (i == null)
        {
            Animations.Type("You do not carry an item by that name.");
        }
        return i;
    }


    public void RemoveItem(Item item)
    {
        _inventory.Remove(item);
    }
}