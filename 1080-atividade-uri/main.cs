using System; 

class URI {

    static void Main(string[] args) { 

       int numero, maior, posicao;

            maior = 0;
            posicao = 0;
            for (int i = 1; i <= 100; i++)
            {
                numero = int.Parse(Console.ReadLine());
                if (numero > maior)
                {
                    maior = numero;
                    posicao = i;
                }
            }

            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }

    }