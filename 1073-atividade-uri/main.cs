using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
            int numerador = 2;
            
            while (N >= numerador)
            {
                Console.WriteLine(numerador + "^2 = " + Math.Pow(numerador, 2));
                numerador += 2;
            }

    }

}