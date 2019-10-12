using System;

namespace oefening2
{
    class Program
    {
        static void Main(string[] args)
        {
        // DEEL A: Tafel van 5 -> loopen van 1 tot 10 
        int tafel = 5;
        // int i =5 _> code gaat niet werken omdat we twee kkeer dezelfde variabel gaan declareren 
        for(int i = 0;i <= 10; i++){
            Console.WriteLine("" + i + "x" + "" + tafel + " = " + i*tafel);
        }
        // DEEL B: Alle tafels van vermenigvuldigen
        for(int i = 0; i <= 10; i++){
        for(int j = 0;j < i; j++){
            Console.WriteLine("" + j + "x" + "" + i + " = " + j*i);
        }
}
// DEEL C: Zelf waarde ophalen
Console.WriteLine("Geef een getal in van 1 tot 10");
int specifieketafel= Convert.ToInt32(Console.ReadLine());

               for(int i = 0; i <= 10; i++){
        
            Console.WriteLine("" + i + "x" + "" + specifieketafel+ " = " + specifieketafel*i);
        }
}
}
};
