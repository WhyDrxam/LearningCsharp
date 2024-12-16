<Query Kind="Statements" />

int a = int.Parse(Console.ReadLine());
if ((a % 17 == 0 || a % 7 == 0) && (a > 999 && a < 9999))
{
	Console.WriteLine("Красивое число");
}
else
{
	Console.WriteLine("Некрасивое число");
}