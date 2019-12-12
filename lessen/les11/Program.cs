using System;

namespace les11
{
    class Program
    {
        static void Main(string[] args)
        {
            var Newspaper = new Newspaper();
            var director = new Director();
            var builder = new ConcreteBuilder();
            
            director.Builder = builder;
            Console.WriteLine("Newspaper:");

            Newspaper.Date();
            Newspaper.CAT();
            Newspaper.Frontpage();
            Newspaper.Articles();
            Newspaper.Reclame();

            Console.Write(Newspaper.Paper().ListParts());
        }
    }
}
