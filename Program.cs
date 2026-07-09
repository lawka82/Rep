using System.Linq;
{
    List<Weapon> weapons = new List<Weapon>
{
    new Weapon("M4A1", "5.56x45", 54),
    new Weapon("AK74", "5.45x39", 48),
    new Weapon("AXMC", ".338LM", 114)
};
    List<Map> maps = new List<Map>
    {
        new Map("Резерв", "Сложно", "Лутай меченки"),
        new Map("Берег", "Средняя", "Возьми оптику"),
        new Map("Таможня", "Средняя", "Внимательно осматривайся")
    };

    const int maxAttempts = 4;
    for (int s = 0; s < maxAttempts; s++)
    {
        Console.WriteLine("\nВыбери тип запроса:");
        Console.WriteLine("1 - Инфо о локации");
        Console.WriteLine("2 - Инфо об оружии");
        Console.WriteLine("0 - выход");
        Console.Write("Твой выбор: ");
        string? choice = Console.ReadLine();

        if (choice == "0")
        {
            Console.WriteLine("Выход из программы. Удачи в рейде!");
            break;
        }
        else if (choice == "1")
        {
            Console.Write("Ввидите название локации");
            string? location = Console.ReadLine();
            Map? found = maps.FirstOrDefault(m => m.Name == location);
            if (found != null)
                found.PrintMapInfo();
            else { Console.WriteLine($"локация {location} не найдена"); }
        }
        else if (choice == "2")
        {
            Console.WriteLine("Выберете оружие");
            string? weaponName = Console.ReadLine();
            Weapon? found = weapons.FirstOrDefault(w => w.Name == weaponName);
            if (found != null)
                found.PrintWeaponInfo();
            else { Console.WriteLine($"оружие {weaponName} не найдено"); }
        }
        else { Console.WriteLine("Неверный ввод"); }
    }
    static Weapon? FindWeapon(Weapon[] weapons, string name)
    {
        foreach (Weapon w in weapons)
        {
            if (w.Name == name) return w;
        }
        return null;
    }
    static Map? FindMap(Map[] maps, string name)
    {
        foreach (Map m in maps)
        {
            if (m.Name.Equals(name)) return m;
        }
        return null;
    }
    static void PrintWeaponInfo(Weapon w)
    {
        Console.WriteLine($"Оружие: {w.Name}");
        Console.WriteLine($"Калибр: {w.Caliber}");
        Console.WriteLine($"Урон: {w.Damage}");
        if (w.Name == "M4A1")
            Console.WriteLine("Базовая база");
        else if (w.Name == "AK74")
            Console.WriteLine("Советское качество");
    }
    static void PrintMapInfo(Map m)
    {
        Console.WriteLine($"Локация: {m.Name}");
        Console.WriteLine($"Сложность: {m.Difficulty}");
        Console.WriteLine($"Совет: {m.Tip}");
    }
}
Console.ReadKey();