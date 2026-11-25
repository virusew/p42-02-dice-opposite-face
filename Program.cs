using System;

class Program
{
    // Верните число на грани, противоположной грани n
    static int OppositeFace(int n)
    {
        // TODO: напишите решение здесь
        return 7 - n;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Check(2, 5);
        Check(6, 1);
        Check(1, 6);
        Check(3, 4);
        Check(4, 3);
        Check(5, 2);
    }

    static void Check(int n, int expected)
    {
        int result = OppositeFace(n);
        string status = result == expected ? "OK" : "ОШИБКА";
        Console.WriteLine($"n = {n}: получено {result}, ожидалось {expected} - {status}");
    }
}
