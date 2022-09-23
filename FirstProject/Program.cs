using System;

class Program
{

    public static void Main(string[] args)
    {
        //You can read what are Methods :)
        Console.WriteLine(SayHi("Plamen and Svetlyo"));
    }

    public static string SayHi(string name)
    {
        return $"Hello {name}";
    }
}