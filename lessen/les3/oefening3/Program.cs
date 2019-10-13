using System;

namespace oefening3 {
    class Program {
        static void Main(string[] args) {
            // while -loop deel A
            int T5=5;
            int t=0;

            while (t <=10) {
                Console.WriteLine(""+ t + "x"+ ""+ T5+ " = "+ T5*t);
                t++;
            }

            // while -loop deel B
            int r=1;
            int q=0;

            while (r <=10) {
                while (q < r) {

                    Console.WriteLine(""+ q + "x"+ ""+ r + " = "+ q*r);

                    q++;
                }

                r++;
            }

            ;

            // deel C : 
            Console.WriteLine("Geef een waarde in waar je de tafel van wil weten");
            int randomTafel=Convert.ToInt32(Console.ReadLine());
            int a=0;

            while (a <=10) {
                Console.WriteLine(""+ a + "x"+ ""+ randomTafel + " = "+ a*randomTafel);
                a++;
            }
        }
    }
}

;