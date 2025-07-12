public class Inventory
{
    private List<Item> _inventory = new List<Item>();
    public Inventory(List<Item> inventory)
    {
        _inventory = inventory;
    }

    public void AddItem(Item item)
    {
        _inventory.Add(item);
    }
    public void Display()
    {
        foreach (Item item in _inventory)
        {
            //item display method to be made
        }
    }
}