<Query Kind="Statements" />

int a = int.Parse(Console.ReadLine());
int b = a % 10;
a /= 10;
while (a >= 1)
{
	b *= 10;
	b += a % 10;
	a /= 10;
}
Console.WriteLine(b);