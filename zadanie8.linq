<Query Kind="Statements" />

double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());
double D;
double x1 = 0;
double x2 = 0;
D = b*b - (4*a*c);
if (D > 0)
{ 
	x1 = (-b + Math.Sqrt(b-4*a*c))/(2*a);
	x2 = (-b - Math.Sqrt(b-4*a*c))/(2*a);
	Console.WriteLine($"{x1} {x2}");
}
else if (D < 0)
{
	Console.WriteLine("Корней нет");
}
else if (D == 0)
{
	x2 = -(b/(a*2));
	Console.WriteLine($"{x2}");
}