public class Armor : GameEntity
{
    private string _brand = "Unknown";
    private int _levelProt = 0;
    private int _durability = 0;
    private string _type = "Unknown";
    private static int _armorCount = 0;
    public static int ArmorCount => _armorCount;
    public string Brand
    {
        get => _brand;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                _brand = "Unknown";
            }
            else
            {
                _brand = value;
            }
        }
    }
    public int LevelProt
    {
        get => _levelProt;
        set
        {
            if (value <= 0 || value > 7)
            {
                _levelProt = 0;
                Console.WriteLine("Невозможный класс брони");
            }
            else
            {
                _levelProt = value;
            }
        }
    }
    public int Durability
    {
        get => _durability;
        set
        {
            if (value < 0)
            {
                _durability = 0;
                Console.WriteLine("Прочность не может быть меньше нуля");
            }
            else
            {
                _durability = value;
            }
        }
    }
    public string Type
    {
        get => _type;
        set
        {
            if (value == "Helmet" || value == "Vest")
            {
                _type = value;
            }
            else
            {
                _type = "Unknown";
            }
        }
    }
    public Armor(string name, int levelProt, int durability, string type, string brand) : base(name)
    {
        LevelProt = levelProt;
        Durability = durability;
        Type = type;
        _armorCount++;
        Brand = brand;
    }
}