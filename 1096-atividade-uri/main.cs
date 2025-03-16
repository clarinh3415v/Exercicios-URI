using System; 

class URI {

    static void Main(string[] args) { 
        
            int I, J;
            I = 1;

            while (I <= 9)
            {
                J = 7;
                for (int e = 0; e < 3; e++)
                {
                    Console.WriteLine("I=" + I + " J=" + J);
                    J--;
                }
                I += 2;
            }

    }

} 