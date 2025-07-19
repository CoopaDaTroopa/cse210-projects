public class Character
{
    private int _health = 10;
    private int _attackDamage = 1;



    public void Display()
    {
        Animations.Type($"Health: {_health}");
        Animations.Type($"Attack Damage: {_attackDamage}");
        Console.WriteLine();
        Animations.Type("Inventory: ");
    }

    public int GetDamage()
    {
        return _attackDamage;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
    }
    public int GetHealth()
    {
        return _health;
    }

    public void AddDamage(int damage)
    {
        _attackDamage = damage;
    }

    public void UsePotion()
    {
        _health = 10;
    }
}