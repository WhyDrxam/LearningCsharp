<Query Kind="Statements" />

/*5

На вход строка. Напиши программу, которая проверяет, что строка заканчивается подстрокой `.com` или `.ru`.
Если заканчивает верни ДА, если нет то верни НЕТ

input

www.google.com

output

ДА*/
string input = Console.ReadLine();
if (input.EndsWith(".com") || input.EndsWith(".ru"))
{
	Console.WriteLine("ДА");
}
else
Console.WriteLine("НЕТ");