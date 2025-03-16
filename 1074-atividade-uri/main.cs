using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
            int X;

            for (int e = 0; e < N; e++)
            {
                X = int.Parse(Console.ReadLine());
                if (X == 0)
                {
                    Console.WriteLine("NULL");
                } else if (X < 0)
                {
                    if (X % 2 == 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                } else
                {
                    if (X % 2 == 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                }
            }
    }

}