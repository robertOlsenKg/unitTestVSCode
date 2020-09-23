using System;

class Program
{
    static void Main(string[] args)
    {

        int summa = Add(4, 5);
        Console.WriteLine(summa);
        Console.WriteLine(Udda(5));
    }
    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static bool Udda(int value)
    {
        return value % 2 == 1;
    }
}

