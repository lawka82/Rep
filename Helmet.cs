public class Helmet : Armor
{
    private string _nvgPlacement = "Unknown";
    private string _headphones = "Unknown";
    private static int _helmetCount = 0;
    public static int HelmetCount => _helmetCount;
    public string NvgPlacement
    {
        get => _nvgPlacement;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                _nvgPlacement = "Unknown";
            }
            else if (value == "Yes" || value == "No")
            {
                _nvgPlacement = value;
            }
        }
    }
        public string Headphones
    {
        get => _headphones;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) {  _headphones = "Unknown";}
            else
            {
                _headphones = value;
            }
        }
    }
    public Helmet(string name, int levelProt, int durability, string type, string brand, string nvgPlacement, string headphones) : base(name, levelProt, durability, type, brand)
    {
        NvgPlacement = nvgPlacement;
        Headphones = headphones;
        _helmetCount++;
    }
}