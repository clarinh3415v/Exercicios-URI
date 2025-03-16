using System; 

class URI {

    static void Main(string[] args) { 

        double S = 1;

            for (int i = 2; i <= 100; i++)
            {
                S += (double) 1 / i;
            }

            Console.WriteLine(S.ToString("F2"));
        }
    }