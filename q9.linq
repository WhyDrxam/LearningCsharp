<Query Kind="Statements" />

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int first = Math.Min(Math.Min(a,b),c);
int third = Math.Max(Math.Max(a,b),c);
int second = (a+b+c)-first-third;
Console.Write(first);
Console.Write(second);
Console.Write(third);
