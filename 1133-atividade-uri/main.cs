using System; 

class URI {

    static void Main(string[] args) { 
            int X, Y;
            int maior, menor, total;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            if (X > Y)
            {
                maior = X;
                menor = Y;
            } else
            {
                maior = Y;
                menor = X;
            }

            total = maior - menor - 1;

            for (int i = 0; i < total; i++)
            {
                menor++;
                if (menor % 5 == 2 || menor % 5 == 3)
                {
                    Console.WriteLine(menor);
                }
            }

    }

}