<Query Kind="Statements" />

int a = 8;
int b = 2;
int c = -5;
Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a / b);
Console.WriteLine(a * b);
Console.WriteLine(++a);
Console.WriteLine(++b);
Console.WriteLine(a++);
Console.WriteLine(b++);
Console.WriteLine(--a);
Console.WriteLine(--b);
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(Math.Max(a,b));
Console.WriteLine(Math.Min(a,b));
Console.WriteLine(Math.Abs(c));
if (int.TryParse("4",out int result))
{
	Console.WriteLine(result);
}
if (int.TryParse("a",out int result2))
{
	Console.WriteLine(result2);
}
else 
{
	Console.WriteLine("idfug");
}