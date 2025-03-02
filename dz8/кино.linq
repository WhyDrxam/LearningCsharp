<Query Kind="Statements" />

class Guest
{
    private string Fio;
    private string PayCard;
    private int Age;

    public Guest(string fio, string payCard, int age)
    {
        Fio = Console.ReadLine();
        PayCard = Console.ReadLine();
        Age = int.Parse(Console.ReadLine());
    }
}

class Movie
{
    protected string MovieName;
    protected string Duration;
    protected string Genre;
}

class Ticket
{
    protected int Cost;
    protected int Sit;
}

class Schedule
{
    public string Morning;
    public string Evening;
}

class Theater
{
    protected string Adress;
    protected string WorkTime;
}