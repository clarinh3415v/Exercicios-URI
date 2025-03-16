using System; 

class URI {

    static void Main(string[] args) { 

        
            int N = int.Parse(Console.ReadLine());
            long fatorial;
            int cont;

            fatorial = N;
            cont = N;
            for (int i = 1; i < cont; i++)
            {
                N--;
                fatorial *= N;
            }

            Console.WriteLine(fatorial);
        }
    }
