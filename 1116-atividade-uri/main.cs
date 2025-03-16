using System; 

class URI {

    static void Main(string[] args) { 

       int N = int.Parse(Console.ReadLine());
            
            int cont = 0;

            double soma;

            while (cont < N)
            {
                string[] valores = Console.ReadLine().Split();

                int X = int.Parse(valores[0]);
                int Y = int.Parse(valores[1]);

                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    soma = 0;
                    soma = (double)X / Y;
                    Console.WriteLine(soma.ToString("F1"));
                }
                cont++;
            }
    }

}