public class Vest : Armor
{
    private int _numberOfPlates = 0;
    private static int _vestCount = 0;
    public static int VestCount => _vestCount;
    public int NumberOfPlates
    {
        get => _numberOfPlates;
        set
        {
            if (value < 0 || value > 5)
            {
                _numberOfPlates = 0;
            }
            else
            {
                _numberOfPlates = value;
            }
        }
    }
    public Vest(string name, int levelProt, int durability, string type, string brand, int numberOfPlates) : base(name, levelProt, durability, type, brand)
    {
        Brand = brand;
        NumberOfPlates = numberOfPlates;
        _vestCount++;
    }
}