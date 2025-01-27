<Query Kind="Statements" />

string a = Console.ReadLine();
string b = Console.ReadLine();


if (a == b || b == a)
{
	Console.WriteLine(a);
}
if ((a == "красный" && b == "желтый") || (b == "красный" && a == "желтый") )
{
	Console.WriteLine("оранжевый");
}
if (( a == "красный" && b == "синий") || ( b == "красный" && a == "синий"))
{
	Console.WriteLine("фиолетовый");
}
if (( a == "синий" && b == "желтый") || ( b == "синий" && a == "желтый"))
{
	Console.WriteLine("зеленый");
}
else if ( a == "зеленый" || a == "фиолетовый" || a == "оранжевый")
{
	Console.WriteLine($"мы не поддерживаем {a}");
}
else if ( b == "зеленый" || b == "фиолетовый" || b == "оранжевый")
{
	Console.WriteLine($"мы не поддерживаем {b}");
}	