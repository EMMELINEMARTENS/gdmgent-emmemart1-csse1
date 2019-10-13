using System;

namespace oefening5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een lengte weer van de fibonnaci reeks");
            // ask for a value 
            int valuelength = Convert.ToInt16(Console.ReadLine());

            fibonnaciFun(valuelength);
           /*De volgende waarde is de som van de 2 vorige waardes -> fibonnaci
           Starten van 0 en zo naar oneindig
           n defineren als een lengte
           */
        }
            static public void fibonnaciFun(int valuelength)
        {
            // make a static function that is empty
            //declared the values
            int value1 = 0;
            int value2 = 1;
        

            for(int i = 1; i <= valuelength; i++ )
            {
                int number1 = value1;
                int result = value1 + value2;
                Console.WriteLine(result);
                value1 = value2;
                value2 += number1;
            }
            
        
        }
        
    }
}  
