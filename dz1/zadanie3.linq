<Query Kind="Statements" />

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
if ((a+b)%2==0 && (c+d)%2==0)
{
	Console.WriteLine("ДА");
}
else if ((a+b)%2==1 && (c+d)%2==1)
{
	Console.WriteLine("ДА");
}
else
{
	Console.WriteLine("НЕТ");
}