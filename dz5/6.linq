<Query Kind="Statements" />

/*6

На вход строка, напиши программу которая определит самый часто встречающийся символ

input

фффиыыыерццццц

output

ц*/
string input = Console.ReadLine();
char c = '\0';
int current = 0;
int max = 0;
for (int i = 0; i < input.Length - 1; i++)
{
    if (input[i] == input[i + 1])
    {
        current++;
    }

    if (current > max)
    {
        max = current;
        c = input[i];
    }
    
    if (input[i] != input[i + 1])
    {
        current = 0;
    }

    
}
Console.WriteLine(c);