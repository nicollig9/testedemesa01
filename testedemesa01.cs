using System;

class Tabela1
{
    static void Main()
    {
        const int a = 10;
        const int b = 20;
        int c;

        c = (a + b) / 2;
        c = c - 40;

        int[] v = new int[4];
        v[3] = a + b + c;

        Console.WriteLine(v[3]);
    }
} 






