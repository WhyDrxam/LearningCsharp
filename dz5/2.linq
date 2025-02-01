<Query Kind="Statements" />

/*2

На вход  строка. Нужно написать программу которая меняет регистр букв.

input
Csharp

output

cSHARP

input

WaSp

output

wAsP*/
string input = Console.ReadLine();
char[] arr = input.ToCharArray(); 
string result = "";
foreach (char letter in arr)
{
	if(char.IsLower(letter))
	{
		result += char.ToUpper(letter);
	}
	else if(char.IsUpper(letter))
	{
		result  += char.ToLower(letter);
	}
	
}
Console.WriteLine(result);