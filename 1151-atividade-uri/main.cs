using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());

            int anterior = 0;
            int atual = 0;
            int proximo = 1;

            for (int i = 0; i < N; i++)
            {

                if (N == 1) 
                {
                    Console.Write(atual);
                }
                else if (i < 1) 
                {
                    atual = i;
                    Console.Write(atual + " ");
                    atual = proximo;
                    Console.Write(atual);
                    anterior = atual;
                    i++;
                }
                else 
                {
                    atual = proximo;
                    Console.Write(" " + atual);

                    proximo = atual + anterior;
                    anterior = atual;

                }
            }
            Console.WriteLine();
        }
    } 