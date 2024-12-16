<Query Kind="Statements" />

int a = int.Parse(Console.ReadLine());
string sign = Console.ReadLine();
int b = int.Parse(Console.ReadLine());
if (sign == "+")
{
	Console.WriteLine(a + b);
}
else if ( sign == "-")
{
	Console.WriteLine(a - b);
}
else if ( sign == "*")
{
	Console.WriteLine(a * b);
}
else if ( sign == "/")
{
	if (b == 0)
    {
		Console.WriteLine("Делить на 0 нельзя");
    }
	else
	{
		Console.WriteLine(a / b);
	}
}
else
{
	Console.WriteLine("Введен неподдерживаемый оператор");
}

	