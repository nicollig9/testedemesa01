using System;

class Tabela2
{
    static void Main()
    {
        int a = 2;
        int[] v = new int[7];

        while (a < 6)
        {
            v[a] = 10 * a;
            a++;
        }

        for (int i = 2; i < 6; i++)
        {
            Console.WriteLine($"v[{i}] = {v[i]}");
        }

        Console.ReadKey();
    }
}