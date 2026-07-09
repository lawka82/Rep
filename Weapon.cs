class Weapon
{
    private string _name = "Unknown";
    private string _caliber = "Unknown";
    private int _damage = 0;
    private static int _weaponCount = 0;
    public Weapon(string name, string caliber, int damage)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            name = "Unknown";
            Console.WriteLine("Неверный ввод");
        }
        else
        {
            _name = name;
        }
        if (string.IsNullOrWhiteSpace(caliber))
        {
            caliber = "Unknown";
            Console.WriteLine("Неверный ввод");

        }
        else
        {
            _caliber = caliber;
        }
        if ( damage < 0)
        {
            damage = 0;
            Console.WriteLine("Урон меньше нуля");
        }
        else
        {
            _damage = damage;
        }
        _weaponCount++;
    }
    public void PrintWeaponInfo()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Caliber: {_caliber}");
        Console.WriteLine($"Damage: {_damage}");
        Console.WriteLine($"Weapon count: {_weaponCount}");
    }
}