<Query Kind="Statements" />

int a = int.Parse(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
	int b = a * i;
	Console.WriteLine($"{a} x {i} = {b}");
}