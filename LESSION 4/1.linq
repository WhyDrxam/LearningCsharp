<Query Kind="Statements" />

/*
Создайте программу, которая принимает строку от пользователя и:
Убирает все пробелы в начале и конце.
Меняет регистр на заглавный.
Проверяет, содержит ли строка подстроку "C#".
Если содержит, заменяет "C#" на "CSharp".*/
string input = Console.ReadLine();
string trimmed = input.Trim();
string reg = trimmed.ToUpper();
bool contains = reg.Contains("C#");
if (contains)
{
	reg = reg.Replace("C#" , "CSharp").ToUpper();
}
Console.WriteLine(reg);