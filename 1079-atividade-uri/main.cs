using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
            float v1, v2, v3;

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                v1 = float.Parse(vet[0]);
                v2 = float.Parse(vet[1]);
                v3 = float.Parse(vet[2]);

                float m1 = (v1 * 2) / 10;
                float m2 = (v2 * 3) / 10;
                float m3 = (v3 * 5) / 10;

                float mediaFinal = m1 + m2 + m3;

                Console.WriteLine(mediaFinal.ToString("F1"));
            }
    }

} 