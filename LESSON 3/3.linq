<Query Kind="Statements" />

//вывести первую минуту  с секундами формат: 1 : 1 потом 1 : 2 и тд и так до 2:00
for (int i = 1; i < 3; i++)
{
	for (int j = 1; j < 61; j++)
	{
		if (i == 2)
		{
			Console.WriteLine($"{i} : {0}{0}");
			break;
		}
		Console.WriteLine($"{i} : {j}");
	}
}