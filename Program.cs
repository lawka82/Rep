Console.WriteLine("Анкета по EFT");
Console.Write("Какая твоя Любимая локация:");
string? location = Console.ReadLine();
Console.Write("А любимое оружие какое?:");
string? FavWeapon = Console.ReadLine();
Console.Write("А калибр какой нравиться?:");
string? calibr = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine($"Локация: {location}");
Console.WriteLine($"Оружие: {FavWeapon}");
Console.WriteLine($"Калибр: {calibr}");

if (calibr == "5.56")
{
    Console.WriteLine("Натовская пятёрка - классика");
}
else
{
    Console.WriteLine("Неплохой вкус");
}

if (FavWeapon == "M4A1")
{
    Console.WriteLine("Не стареющаяя классика");
}
else
{ 
    Console.WriteLine("Отличный выбор");
}
if (location == "Резерв")
{
    Console.WriteLine("Карта где больше всего меченок, самое то для пвп и фарма");
}
else if (location == "Лаборатория")
{
    Console.WriteLine("да ты у нас киберспортсмен");
}
else
{
    Console.WriteLine("Хорошая локация");
}
Console.ReadKey();