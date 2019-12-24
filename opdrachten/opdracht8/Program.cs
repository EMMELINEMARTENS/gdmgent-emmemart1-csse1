using System;

namespace opdracht8
{
    class Program
    {
        static void Main(string[] args)
        {
            // var Newspaper = new Newspaper();
            // var director = new Director();
            // var builder = new INewspaper_Metro();
            
            // director.Builder = builder;
            // Console.WriteLine("Newspaper:");

            // Newspaper.Date();
            // Newspaper.CAT();
            // Newspaper.Frontpage();
            // Newspaper.Articles();
            // Newspaper.Reclame();

            // Console.Write(Newspaper.Paper().ListParts());
            var director = new Director();
            var builder = new INewspaper_HLN();
            var builder2 = new INewspaper_Metro();
            director.Builder = builder;
            director.Builder = builder2;
            
            Console.WriteLine("Newspaper Metro:");
            director.buildMinimalViableProduct();
            Console.WriteLine(builder2.GetPaper().ListParts());

            Console.WriteLine("Newspaper HLN:");
            director.buildFullFeaturedProduct();
            Console.WriteLine(builder.GetPaper().ListParts());

            // Remember, the Builder pattern can be used without a Director
            // class.
            Console.WriteLine("Custom product:");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.Write(builder.GetPaper().ListParts());
        }
    }
}
