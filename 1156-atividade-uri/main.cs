using System; 

class URI {

    static void Main(string[] args) { 

         double S = 0;
            double par = 1;
            double impar = 1;

            while (impar != 39)
            {
                S += impar / par;
                impar += 2;
                par += par;
            }

            Console.WriteLine(S.ToString("F2"));
        }
}