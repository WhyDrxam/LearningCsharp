<Query Kind="Statements" />

/*8-На вход программе подаётся одна строка Фамилия Имя. Напиши программу которая проверяет что Фамилия Имя  написано с большой буквы.
input
chris madworth
output
НЕТ
input
Александр Иванов
output
ДА*/
string[] fio = Console.ReadLine().Split();
if(char.IsUpper(fio[0][0]) && char.IsUpper(fio[1][0]))
{
	Console.WriteLine("ДА");
}
else
Console.WriteLine("НЕТ");
