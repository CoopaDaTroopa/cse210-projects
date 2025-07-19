public class Weapon : Item
{
    private int _damage;
    public Weapon(string type, string name, string des, int damage) : base(type, name, des, damage)
    {
        _damage = damage;
    }

    public override void DisplayItem()
    {
        base.DisplayItem();
        Animations.Type($"Damage: {_damage}");
    }



}