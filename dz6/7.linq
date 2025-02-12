<Query Kind="Statements" />

/*7
На вход программе подаётся  число N  и N строк, а затем число k
Напиши программу которая возвращает список k-тых букв каждого слова.
input
5
abcdef
bcdefg
cdefgh
defghi
efghij
2
output
экземпляр объекта List<string> заполненный b c d e f*/
int n = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());
List<string> input = new ();
List<string> result = new ();
for (int i = 0; i < n; i++)
{
    input.Add(Console.ReadLine());
}
foreach (var word in input)
{
    result.Add(char.ToString(word[k - 1]));
}

foreach (var l in result)
{
    Console.Write($"{l} ");
}