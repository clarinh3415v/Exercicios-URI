using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());

            int anterior = 0;
            int atual = 0;
            int proximo = 1;

            for (int i = 0; i < N; i++)
            {

                if (N == 1) //Evitando troll, valido se o N é igual a 1 para só imprimir o zero
                {
                    Console.Write(atual);
                }
                else if (i < 1) //Imprimo o número zero e o primeiro número 1!
                {
                    atual = i;
                    Console.Write(atual + " ");
                    atual = proximo;
                    Console.Write(atual);
                    anterior = atual;
                    i++;
                }
                else //imprimo todo o restante de fibonacci
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