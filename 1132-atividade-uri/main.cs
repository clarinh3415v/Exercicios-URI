using System; 

class URI {

    static void Main(string[] args) { 
        
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int soma = 0;
            int maior, menor;

            if (X >= Y)
            {
                maior = X;
                menor = Y;
            } else
            {
                maior = Y;
                menor = X;
            }

            for (int i = menor; i <= maior; i++)
            {
                if (i % 13 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);
        }
    } 