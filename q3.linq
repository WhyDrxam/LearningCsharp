<Query Kind="Statements" />

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
if (a == b && a == c && b == c)
{
	Console.WriteLine("Равносторонний треугольник");
}
else if (a == b || b == a || a == c)
{
	Console.WriteLine("Равнобедренный треугольник");
}
else if (a != b && b != c && a != c)
{
	Console.WriteLine("Разносторонний треугольник");
}