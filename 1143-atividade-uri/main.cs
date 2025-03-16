using System; 

class URI {

    static void Main(string[] args) { 

       int m1, m2;
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                m1 = (int)Math.Pow(i, 2);
                m2 = m1 * i;
                Console.Write(i + " ");
                Console.Write(m1 + " ");
                Console.WriteLine(m2);
                
            }

    }

} 