using System;

namespace oefening1
{
    class Program
    {
     
        static void Main(string[] args)
        {
            int getal1 = 8;
            int getal2 = 3;
        
            Schrijflog(getal1);
            Schrijflog(getal2);
            Schrijflog(Plus(getal1, getal2));
            Schrijflog(Distract(getal1, getal2));
            Schrijflog(Multiply(getal1, getal2));
            Schrijflog(Divided(getal1, getal2));

            // willekeurige getallen oproepen
            Schrijflog(GenereerWillekeurigGetal());
            Schrijflog(GenereerWillekeurigGetal(1,45));
            
        }
        // plus function
        private static string Plus(int getal1, int getal2)
        {
            int plusresult = getal1 + getal2;
           
            return "" + getal1 + " + " + getal2 + " = " + plusresult;
        }
        private static string Distract(int getal1, int getal2)
        {
            int distractresult = getal1 - getal2;
            return "" + getal1 + " - " + getal2 + " = " + distractresult;

        }
        private static string Multiply(int getal1,int getal2)
        {
            int multiplyresult = getal1 * getal2;
            return "" + getal1 + " * " + getal2 + " = " + multiplyresult;
        }
        private static string Divided(float getal1, float getal2)
        {
            float dividedresult = getal1 / getal2;
           return "" + getal1 + " / " + getal2 + " = " + dividedresult;
        }
        // functie maken van console .
        static void Schrijflog(string output) => Console.WriteLine(output);
        static void Schrijflog(int output) => Console.WriteLine(output.ToString());

        // verhogen + verlagen (er nog in steken )
        
    // defineren random getal
    static void GenereerWillekeurigGetal(int min, int max){

            Random r = new Random();
            return r.Next(min,max);
           
        }
      static int verhogen (int getal){
          Schrijflog("verhogen");
          getal++;
         return getal;
      }
      /*
      1. modulo
      2. verhogen 
      3.verlagen
      */
    }
}
