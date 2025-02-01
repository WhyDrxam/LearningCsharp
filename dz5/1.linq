<Query Kind="Statements" />

/*1

На вход строка, имя и фамилия, разделённых одним пробелом. Напиши программу, которая проверяет, что имя и фамилия начинаются с заглавной буквы.

INPUT
Иван Алкон

OUTPUT
ДА

INPUT
иван Алкон

OUTPUT
НЕТ*/
string[] fio = Console.ReadLine().Split();
if(char.IsUpper(fio[0][0]) && char.IsUpper(fio[1][0]))
{
	Console.WriteLine("ДА");
}
else
	Console.WriteLine("НЕТ");