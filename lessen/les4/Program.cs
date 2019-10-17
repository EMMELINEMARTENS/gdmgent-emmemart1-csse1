using System;

namespace les4
{
    class Program
    {

        // voorbeeld_7: globaal aanroepen
        int Teller = 0;
        static void GenereerFib(int lengte)
        {
        Console.WriteLine("Start methode...." + " " + lengte);
        }
          static void GenereerFib(int lengte1, int lengte2)
        {
        Console.WriteLine("Start methode...." + " " + lengte1 + lengte2);
        }
        // teller

        static void Main(string[] args)
        {
            int getal1 = 8;
         // int i = 0;
        // Console.WriteLine("7+3-2*3+4 =" + " " + i );
        // Fahrheit uitrekenen : voorbeeld_1
        /* int fahr = 100;
        double cels = (fahr-32) * (5.0/9.0);*/
        double fahr = 100;
        double cels = (fahr-32) * (5.0/9.0);
        Console.WriteLine(cels);

        // voorbeeldd_2:test boolean
        Boolean test;
        test = true;
        Console.WriteLine(test.ToString());
        // voorbeeld_3: Boolean -> bits runnen 
        Console.WriteLine(sizeof(System.Boolean).ToString());
        Console.WriteLine(sizeof(System.Int32).ToString());
        Console.WriteLine(sizeof(System.Int64).ToString());
        Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(new System.Boolean()));


        // voorbeeld_4: char 
        // char a = 'c';
        // a = 'b';
        string mijnString = "Dit is mijn eerste regel tekst ...";
        Console.WriteLine(mijnString);
         string mijnString2 = "Dit is mijn tweede regel tekst ...";
        Console.WriteLine(mijnString2);
         string mijnString3 = "Hello";
    
         string mijnString4 = "iedereen";
        
        string mijnString5 = mijnString3 + " " + mijnString4;
        Console.WriteLine(mijnString5);

        // voorbeeld_5:interest
        // const double Interest = 0.80;
        
        int x = 14;
        int y = 8;
        int result1 = x + y;
        int result2 = --x;
        int result3 = -x;
        int result4 = ++x;
        int result5 = x - y;
        int result6 = x * y;
        int result7 = x / y;
        int result8 = x % y;
        Console.WriteLine("x + y =" + " " + result1); // output: 22

        // voorbeeld_6:char letter
        char letter1 ='C';
        // verhogen van unicode (67 + 1 = 68)-> output: D;
        char letter2 = ++letter1;
        Console.WriteLine("letter2 = " + letter2);

        // voorbeeld_7:
        GenereerFib(getal1);
        GenereerFib(getal1, getal1);
        }
        
        
    }
}