<Query Kind="Statements" />

/*4

На вход  строка. Напиши программу которая посчитает кол-во слов которые начинаются с гласных (союзы предлоги считать за слова)

input

Оле Лукойе ест апельсин

output

4

input

Пиноккио врун обманщик и оболдуй

output

3*/
string[] input = Console.ReadLine().Split();
int count = 0;
char[] arr = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я', 'А', 'Е', 'Ё', 'И', 'О', 'У', 'Ы', 'Э', 'Ю', 'Я' };
/*foreach (var word in input)
{
	if (word.StartsWith(a))
	{
		count++;
	}
}
Console.WriteLine(count);*/
for (int i = 0; i < arr.Length; i++)
{
	foreach (var word in input)
{
	if (word.StartsWith(arr[i]))
	{
		count++;
	}
}
}
Console.WriteLine(count);