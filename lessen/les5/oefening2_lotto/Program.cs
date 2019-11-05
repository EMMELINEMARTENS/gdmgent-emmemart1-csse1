using System;
using System.Threading;

namespace oefening2_lotto
{
    class Program
    {
        static void Main(string[] args)
        {
        Lottogetallen();
        lottoTrekking();
        Euromillionstrekking();
            
        }
        static void Schrijflog(string output) => Console.WriteLine(output);
        static void Schrijflog(int output) => Console.WriteLine(output.ToString());
        static int genereerwillekeurigGetal(int min, int max){
            Random r = new Random();
            return r.Next(min, max);
        }
         
            static void lottoTrekking(){
                Schrijflog("lottotrekking");
                for(int i = 0; i < 6; i++){
                Schrijflog(genereerwillekeurigGetal(1,45));
            };
        }

        // sleep Threadd -> per sessie ff slapen
        public static void Lottogetallen()
        {
            Thread.Sleep(3000);
        }
        // euromillion

        static void Euromillionstrekking(){
                Schrijflog("Euromillionstrekking");
                for(int j = 0; j < 5 ; j++){
                Schrijflog(genereerwillekeurigGetal(1,50));
            }
            for(int i = 0;i < 2;i ++ ){
               Schrijflog(genereerwillekeurigGetal(1,12)); 
            };
        }
    }
}
