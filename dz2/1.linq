<Query Kind="Statements" />

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
for (int i = a; i > b; i--)
{
	if (i % 1 == 0)
	{
		Console.WriteLine(i);
	}
}