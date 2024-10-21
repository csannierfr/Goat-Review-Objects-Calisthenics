namespace LordOfTheRings;

public record Weapon
{
    public string Name { get; init; }
    public int Damage { get; init; }
    
    private Weapon(string name, int damage)
    {
        
        Name = name;
        Damage = damage;
    }
    
    public static Weapon Create(string name, int damage)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("A weapon must have a name.");
        }
        if (damage <= 0)
        {
            throw new ArgumentException("A weapon must have a damage level.");
        }
        return new(name, damage);
    }
    
}