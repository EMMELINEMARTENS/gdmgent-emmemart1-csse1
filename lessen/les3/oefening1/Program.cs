using System;

namespace les3
{
    class Program
    {
        private const int V = 7;
        private const int V1 = 7;

        static void Main(string[] args)
        {
            int getal;
            // initialisatie van het getal met de waarde 5
            getal = 5; 
            Console.WriteLine("Geef een getal in tussen 0 en 10");
            // zelf een waarde opvragen ToInt32 -> datatype die we willen || ReadLine() -> waarde opvragen 
            getal = Convert.ToInt32(Console.ReadLine());
        
        /* Onze code gaat kijken aan wellke conditie hij doet en voert de code in het code blok uit */

       /*  if (getal < 8)
            {
                getal++;
                Console.WriteLine("De waarde van het getal is:" + getal);
                Console.WriteLine("Test");
            }
                

        else if(getal > 6)
        {
                getal++;
                // every string double quoting marks
                Console.WriteLine("De waarde van het getal is:" + getal);
        }       
        else
        {
            getal++;
            Console.WriteLine("De waarde van het getal is:" + getal);
        }        
        }*/
    // switch cases in C# 
    switch (getal)
    {
        case 7: 
        Console.WriteLine("Het getal is in dit geval (case7):" + getal);
        break;
        default: 
        Console.WriteLine("Het getal is in dit geval (case7):" + getal);
        break;
    }
    // for-loop C# 
    int teller = 5;
    for (int i = 0; i < teller; i++){
        Console.WriteLine(i);
    }
    Console.WriteLine("Test");

    }
}
};
