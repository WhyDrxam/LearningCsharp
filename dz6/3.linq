<Query Kind="Statements" />

/*3
На вход строка чисел разделенных пробелом.
Нужно вернуть список четных чисел
input
"1 2 3 4 5 6 7 7”
output
экземпляр объекта List<int> заполненный 2 4 6*/
List<int> str = new ();
string[] input = Console.ReadLine().Split();
for (int i = 0; i < input.Length; i++)
{
    int num = int.Parse(input[i]);
    if (num % 2 == 0)
    {
        str.Add(num);
    }
}

foreach (var n in str)
{
    Console.Write($"{n} ");
}