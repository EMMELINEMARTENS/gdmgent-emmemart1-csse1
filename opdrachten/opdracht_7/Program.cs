using System;

namespace opdracht_7
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                 // plusfunction
            Schrijflog(Functions.Plus(5, 6));

            // distractfunction
            Schrijflog(Functions.Distract(8,5));

            // multiplfucntion
            Schrijflog(Functions.Multiply(5, 3));

            // dividefunction
            Schrijflog(Functions.Divided(8, 4));

            // modulo function
            Schrijflog(Functions.modulo(9, 2));

            // getal++
            Schrijflog(Functions.verhogen(7));

            // getal--
            Schrijflog(Functions.verlagen(8));

            // willekeurige getallen oproepen
            Functions.GenereerWillekeurigGetal();
            Schrijflog(Functions.GenereerWillekeurigGetal(0,80));

            // lotto getallen genereren
            Schrijflog(Functions.Lottogetallen());
            Functions.lottoTrekking();
            Schrijflog(Functions.Euromillionsrooster());
            Functions.Euromillionstrekking();

            // faculteit 
            Schrijflog("Geef een getal in");
            int fac = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Functions.factorial(fac));
            /* factorial : n! 
            n! = n * (n-1) * (n-2) * (n-3) * ...
            bv. 5! =  5 * 4 * 3 * 2 * 1 ( vanaf 1 bereikt returnen) -> long is de beste keuze
            1 argument 
             */
            
            Console.WriteLine("Geef een lengte weer van de fibonnaci reeks");
            // ask for a value 
            int valuelength = Convert.ToInt16(Console.ReadLine());

            Functions.fibonnaciFun(valuelength);
        /*De volgende waarde is de som van de 2 vorige waardes -> fibonnaci
        Starten van 0 en zo naar oneindig
        n defineren als een lengte
           */ 

            Person1 p1 = new Person1();
            p1.firstname = "Emmeline";
            p1.Gender = 'V';
            p1.Name = "Martens";
            p1.LogOutput();
            Person1 p2 = new Person1("Parent", "Oliver", 'M');
            p2.LogOutput();
            User user1 = new User("Eva", "Martens", 'V');
            Student s1 = new Student("Emmeline", "Martens", 'V', "koekje");
            Docent docent1 = new Docent("Evelien", "Rutsaert", 'V');

             // Ibanchecker
            bool Validate = Functions.IbanChecker("BE07 7390 1412 0066");
            Console.WriteLine(Validate);
        
            }  catch (System.IndexOutOfRangeException)
            {
                Schrijflog("De collectie is ledig");
            } catch (System.Exception) {
                Schrijflog("Er is een probleem.");
            }   
            

        }
        // functie maken van console .
        static void Schrijflog(string output) => Console.WriteLine(output);
        static void Schrijflog(int output) => Console.WriteLine(output.ToString());
    }
    
}