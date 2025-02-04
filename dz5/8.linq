<Query Kind="Statements" />

/*8

На вход 4 строки каждая с новой строчки
Напиши программу которая определяет самое ценное слово, под ценностью слова нужно считать их сумму порядковых номеров букв в таблице unicode

input

```
az
by
cx
122
```

output

az*/
int n = int.Parse(Console.ReadLine());
int currentLineSum = 0;
int result = 0;
string strResult = "";
for (int i = 0; i < n; i++)
{
	var currentLine = Console.ReadLine();
	currentLineSum = 0;
	foreach (char c in currentLine)
	{
		currentLineSum += c;
	}
	if(currentLineSum > result)
	{
		result = currentLineSum;
		strResult = currentLine;
	}
}
Console.WriteLine(strResult);