<Query Kind="Statements" />

/*6- На вход число n, напиши таблицу размером n X 5 где в i-ой строке указано число i
INPUT
4
OUTPUT
1  1  1  1 1
2 2 2 2 2
3 3 3 3 3
4 4 4 4 4*/
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= 5; j++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
        
}