using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int X = 0;
        int contIn = 0, contOut = 0;

        for (int i = 0; i < N; i++)
        {
            X = int.Parse(Console.ReadLine());
            if (X >= 10 && X <= 20)
            {
                contIn++;
            }
            else
            {
                contOut++;
            }
        }

        Console.WriteLine(contIn + " in");
        Console.WriteLine(contOut + " out");
    }
}