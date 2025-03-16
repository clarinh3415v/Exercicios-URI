using System; 

class URI {

    static void Main(string[] args) { 

       int N = int.Parse(Console.ReadLine());
            int cont = 0;
            int linhas = N * 4;

            for (int i = 1; i <= linhas; i++)
            {
                cont++;
                if (cont % 4 != 0)
                {
                    Console.Write(cont + " ");
                } else
                {
                    Console.WriteLine("PUM");
                }

        }

    }
} 