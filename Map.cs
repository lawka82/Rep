public class Map : GameEntity
{
    private string _difficulty = "Unknown";
    private string _tip = "Unknown";
    private static int _mapCount = 0;
    public static int MapCount => _mapCount;
    
    public string Difficulty
    {
        get => _difficulty;
        set
        {
            if (string.IsNullOrWhiteSpace (value))
            {  _difficulty = "Unknown"; }
            else
            {
                _difficulty = value;
            }
        }
    }
    public string Tip
    {
        get => _tip;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                _tip = "Unknown";
            }
            else
            {
                _tip = value;
            }
        }
    }
    public Map(string name, string difficulty, string tip) : base(name)
    {
        Difficulty = difficulty;
        Tip = tip;
        _mapCount++;
    }
    public void PrintMapInfo()
    {
        Console.WriteLine($"Map name: {Name}");
        Console.WriteLine($"Map difficulty: {_difficulty}");
        Console.WriteLine($"Map tip: {_tip}");
        Console.WriteLine($"Map count: {_mapCount}");
    }
}