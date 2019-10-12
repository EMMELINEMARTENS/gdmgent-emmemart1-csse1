using System;

namespace oefening5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een lengte weer van de fibonnaci reeks");

            long valuelength = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(fibonnaciFun(valuelength));
           /*De volgende waarde is de som van de 2 vorige waardes -> fibonnaci
           Starten van 0 en zo naar oneindig
           n defineren als een lengte
           */
        }
        static public long fibonnaciFun(long valuelength)
        {   Console.WriteLine("...............................");
            int value1 = 0;
            int value2 = 1;
        
            Console.WriteLine(value1);
            for(int i = 0; i <= valuelength; i++ )
            {
                int number1 = value1;
                int result = value1 + value2;
                Console.WriteLine(result);
                value1 = value2;
                value2 += number1;
            }
            Console.WriteLine("...............................");
        
        }
        
    }
}  
