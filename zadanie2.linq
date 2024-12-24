<Query Kind="Statements" />

int a1 = int.Parse(Console.ReadLine());
int b1 = int.Parse(Console.ReadLine());
int a2 = int.Parse(Console.ReadLine());
int b2 = int.Parse(Console.ReadLine());
if (b1 == a2)
{
	Console.WriteLine(b1);
}
else if (a1<a2 && a2<b1)
{
	Console.WriteLine($"{a2} {b1}");
}
else if ((a1<b1) && (b1<a2) && (a2<b2))
{
	Console.WriteLine("пустое множество");
}