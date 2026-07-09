public class GameEntity
{
    private string _name = "Unknown";
    private static int _entityCount = 0;
    public static int EntityCount => _entityCount;
        public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) 
            {
                _name = "Unknown";
                    }
            else { _name = value; }
        }

    }
    public GameEntity (string name)
    {
        Name = name;
        _entityCount++;
    }
}