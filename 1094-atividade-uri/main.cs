using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int rato = 0, sapo = 0, coelho = 0, total = 0;

        for (int i = 0; i < N; i++)
        {
            string[] entrada = Console.ReadLine().Split();
            int quantia = int.Parse(entrada[0]);
            char tipo = char.Parse(entrada[1]);

            total += quantia;
            if (tipo == 'R') rato += quantia;
            else if (tipo == 'S') sapo += quantia;
            else coelho += quantia;
        }

        Console.WriteLine($"Total: {total} cobaias");
        Console.WriteLine($"Total de coelhos: {coelho}");
        Console.WriteLine($"Total de ratos: {rato}");
        Console.WriteLine($"Total de sapos: {sapo}");
        Console.WriteLine($"Percentual de coelhos: {(coelho * 100.0 / total):F2} %");
        Console.WriteLine($"Percentual de ratos: {(rato * 100.0 / total):F2} %");
        Console.WriteLine($"Percentual de sapos: {(sapo * 100.0 / total):F2} %");
    }
}