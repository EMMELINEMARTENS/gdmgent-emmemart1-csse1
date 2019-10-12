using System;

namespace oefening4
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Geef een getal in");
            int fac = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factorial(fac));
            /* factorial : n! 
            n! = n * (n-1) * (n-2) * (n-3) * ...
            bv. 5! =  5 * 4 * 3 * 2 * 1 ( vanaf 1 bereikt returnen) -> long is de beste keuze

            1 argument 
             */
        
        }
        //public -> aanspreken van functie buiten de classe
        // private -> aanspreken van functie binnen de classe
        static public long factorial(int n)
        {
            long result = 1;
            for(int i = n; i > 0; i--) 
            {
                result *=i;
                Console.WriteLine(i);
            
            }
            return result;
        }
    }
}
