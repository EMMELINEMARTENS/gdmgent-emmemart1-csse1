using System;

namespace Rekenmachine
{
    class Program
    {
     
        static void Main(string[] args)
        {
            int getal1 = 8;
            int getal2 = 3;
        
            Console.WriteLine (getal1);
            Console.WriteLine(getal2);
            Plus(getal1, getal2);
            Distract(getal1, getal2);
            Multiply(getal1, getal2);
            Divided(getal1, getal2);
            
        }
        // plus function
        private static void Plus(int getal1, int getal2)
        {
            int plusresult = getal1 + getal2;
            Console.WriteLine( "" + getal1 + " + " + getal2 + " = " + plusresult);
        }
        private static void Distract(int getal1, int getal2)
        {
            int distractresult = getal1 - getal2;
            Console.WriteLine( "" + getal1 + " - " + getal2 + " = " + distractresult);

        }
        private static void Multiply(int getal1,int getal2)
        {
            int multiplyresult = getal1 * getal2;
            Console.WriteLine( "" + getal1 + " * " + getal2 + " = " + multiplyresult);
        }
        private static void Divided(float getal1, float getal2)
        {
            float dividedresult = getal1 / getal2;
            Console.WriteLine( "" + getal1 + " / " + getal2 + " = " + dividedresult);
        }
      
    }
}
