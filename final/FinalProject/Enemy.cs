public class Enemy
{
    private int _health;
    private int _attackDamage;
    private string _descriptionChange;
    private Item _item;
    private string _name;


    public Enemy(string name, int attack, int health, string dChange)
    {
        _name = name;
        _attackDamage = attack;
        _health = health;
        _descriptionChange = dChange;
        _item = null;
    }
    public Enemy(string name, int attack, int health, string dChange, Item item)
    {
        _attackDamage = attack;
        _health = health;
        _descriptionChange = dChange;
        _name = name;
        _item = item;
    }
    public int GetDamage()
    {
        return _attackDamage;
    }
    public void TakeDamage(int damage)
    {
        _health -= damage;
    }

    public Item Death()
    {

        return _item;
    }
    public int GetHealth()
    {
        return _health;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _descriptionChange;
    }

}