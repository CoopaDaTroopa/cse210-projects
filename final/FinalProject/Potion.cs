public class Potion : Item
{
    public Potion(string type, string name, string des) : base(type, name, des)
    {

    }


    public override void UseItem(Room r, Character player)
    {
        player.UsePotion();
        Animations.Type("Your health has been restored!");
    }
}