using System.Reflection.Metadata.Ecma335;

string[] Listweapons = new string[] { "M4A1", "AK74", "AXMC", "SIG SPEAR" };
string[] Listmaps = { "Резерв", "Таможня", "Развязка", "Берег" };
const int maxtry = 4;
for (int s = 0; s < maxtry; s++)
{
    Console.WriteLine("\nВыбери тип запроса:");
    Console.WriteLine("1 - Инфо о локации");
    Console.WriteLine("2 - Инфо об оружии");
    Console.WriteLine("0 - выход");
    Console.Write("Твой выбор");
    string? choice = Console.ReadLine();

    if (choice == "0")
    {
        Console.WriteLine("Выход из программы. Удачи в рейде!");
        break;
    }
    else if (choice == "1")
    {
        Console.Write("Введи название локации:");
        string? location = Console.ReadLine();
        if (location != null && Contains(Listmaps, location))
        {
            Printlocation(location);
        }
        else
        {
            Console.WriteLine($"Локация '{location}' не найдена в списке");
        }

    }
    else if (choice == "2")
    {
        Console.Write("Введи название оружия: ");
        string? weapon = Console.ReadLine();
        if (weapon != null && Contains(Listweapons, weapon))
        {
            PrintWeaponinfo(weapon);
        }
        else
        {
            Console.WriteLine($"Оружие '{weapon}' отсутствует в базе.");
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод. Попробуйте снова.");
    }
}
static bool Contains(string[] array, string item)
{
    foreach (string element in array)
    {
        if (element == item) return true;
    }
    return false;
}
static void PrintWeaponinfo(string weapon)
{
    if (weapon == "M4A1")
        Console.WriteLine("M4A1 — стабильная классика НАТО.");
    else if (weapon == "AK74")
        Console.WriteLine("AK74 — надёжный друг советского разлива.");
    else
        Console.WriteLine($"{weapon} — достойный выбор.");
}
static void Printlocation(string location)
{
    if (location == "Таможня")
        Console.WriteLine("Пвп в общагах это топ");
    else if (location == "Резерв")
        Console.WriteLine("Бегом в меченки");
    else
        Console.WriteLine($"{location} - Хорошая карта");
}