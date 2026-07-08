Weapon[] weapons = new Weapon[]
{
    new Weapon { Name = "M4A1", Caliber = "5.56x45", Damage = 54 },
    new Weapon { Name = "AK74", Caliber = "5.45x39", Damage = 48 },
    new Weapon { Name = "AXMC", Caliber = ".338 Lapua", Damage = 112 },
    new Weapon { Name = "SIG SPEAR", Caliber = "6.8x51", Damage = 60 }
};

// Создаём объекты карт
Map[] maps = new Map[]
{
    new Map { Name = "Резерв", Difficult = "Средняя", Tip = "Бегом в меченки" },
    new Map { Name = "Таможня", Difficult = "Высокая", Tip = "Пвп в общагах это топ" },
    new Map { Name = "Развязка", Difficult = "Низкая", Tip = "Хороша для новичков" },
    new Map { Name = "Берег", Difficult = "Средняя", Tip = "Курорты полны лута" }
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
        Map? foundMap = FindMap(maps, location);
        if (foundMap != null)
            PrintMapInfo(foundMap);
        else { Console.WriteLine($"локация {location} не найдена"); }
    }
    else if (choice == "2")
    {
        Console.WriteLine("Выберете оружие");
        string? weaponName = Console.ReadLine();
        Weapon? foundWeapon = FindWeapon(weapons, weaponName);
        if (foundWeapon != null)
            PrintWeaponInfo(foundWeapon);
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
    Console.WriteLine($"Сложность: {m.Difficult}");
    Console.WriteLine($"Совет: {m.Tip}");
}
Console.ReadKey();