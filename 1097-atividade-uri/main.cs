using System; 

class URI {

    static void Main(string[] args) { 

        int I, J;
            I = 1;
            J = 7;

            do
            {
                for (int e = 0; e < 3; e++)
                {
                    Console.WriteLine("I=" + I.ToString() + " J=" + J.ToString());
                    J--;
                }
                I += 2;
                J += 5;
            } while (J <= 15);
        }
    }