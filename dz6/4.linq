<Query Kind="Statements" />

/*На вход строки, каждая строка на новой строке, нужно вернуть список всех строк в которых больше 5 букв и строка начинается с заглавной.
input
Хрен
Морковка
помидор
дыня
Ананас
output
экземпляр объекта List<string> заполненный Хрен, Морковка, Ананас*/
List<string> result = new ();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    char[] arr = input.ToCharArray();
    if (input.Length > 5)
    {
        if (char.IsUpper(arr[0]))
        {
            result.Add(input);
        }
        else
        {
            continue;
        }
    }
    else
    {
        continue;
    }
}

foreach (var r in result)
{
    Console.Write($"{r} ");
}