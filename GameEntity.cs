public class GameEntity
{
    public string _name = "Unknown";
    private static int _entityCount = 0;
    public static int EntityCount => _entityCount;
        public string GeName
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
    public string UnqName(string name)
    {
        GeName = name;
    }
}