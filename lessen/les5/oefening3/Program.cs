using System;

namespace oefening3_account
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Schrijflog(args.Length);
                Schrijflog(args[0]);
            } catch (System.IndexOutOfRangeException)
            {
                Schrijflog("De collectie is ledig");
            } catch (System.Exception) {
                Schrijflog("Er is een probleem.");
            } 
        }
        /* Account generator 
        Docenten: 4 letters van de voornaam 2 letters van de achternaam
        studneten :4 letters van de voornaam 4 letters van de achternaam
        return van een string maar we stellen deze samen aan de hand van een template 
        
        1. Zit er iets in de collectie ?
        2. Geef het eerste argument (student / docent)
        3. 
        */ 
        static string Genereeraccount(string voornaam,string familienaam){
            return String.Format("De account van {0} {1} is: {2}",
            voornaam, familienaam,
            GenereerString(voornaam.ToLower(),4) + 
            GenereerString(familienaam.ToLower(),4));
        }
        static string GenereerString(string input, int lengte)
        {
        
        }
        
    }
}
