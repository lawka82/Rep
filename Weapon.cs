public class Weapon : GameEntity
{
    private string _caliber = "Unknown";
    private int _damage = 0;
    private static int _weaponCount = 0;
    public static int WeaponCount => _weaponCount;

    public string Caliber
    {
        get => _caliber;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                _caliber = "Unknown";
            else
                _caliber = value;
        }
    }

    public int Damage
    {
        get => _damage;
        set
        {
            if (value >= 0)
                _damage = value;
            else
                _damage = 0;
        }
    }

    public Weapon(string name, string caliber, int damage) : base(name)
    {
        Caliber = caliber;
        Damage = damage;
        _weaponCount++;
    }

    public void PrintWeaponInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Caliber: {_caliber}");
        Console.WriteLine($"Damage: {_damage}");
        Console.WriteLine($"Weapon count: {_weaponCount}");
    }
}