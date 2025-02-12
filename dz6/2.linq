<Query Kind="Statements" />

/*2 На вход число N, Вернуть List букв английского алфавита от a до N включительно.
input
3
output
экземпляр объекта List<string> заполненный a, b, c*/

using System.Threading.Channels;

int n = int.Parse(Console.ReadLine());
List<char> result = new ();
char ch = 'a';
int ascii = Convert.ToInt32(ch);
for (int i = 0; i < n; i++)
{
    result.Add((char)ascii);
    ++ascii;
}

foreach (var let in result)
{
    Console.WriteLine(let);
}