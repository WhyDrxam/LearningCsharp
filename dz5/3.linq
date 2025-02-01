<Query Kind="Statements" />

/*3

На вход  строка.
Посчитай символы в нижнем регистре и в верхнем

input

Вася победил Дракона

output
нижний регистр - 16

верхний регистр - 2*/
string input = Console.ReadLine();
int up = 0;
int low = 0;
char[] arr = input.ToCharArray();
foreach (var letter in arr)
{
	if(char.IsUpper(letter))
	{
		up++;
	}
	else if (char.IsLower(letter))
	{
		low++;
	}
	
}
Console.WriteLine($"нижний регистр -" + low);
	Console.WriteLine($"верхний регистр -" + up);
