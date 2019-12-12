using System;
using System.Collections.Generic;

namespace les11
{
    // The Builder interface specifies methods for creating the different parts
    // of the Product objects.
class Newspaper {
	public interface IBuilder
    {
		void CAT();
        void Frontpage();
        
        void Articles();
        
        void Reclame();

		void Date();

		void GetPaper();
    }
	 // The Concrete Builder classes follow the Builder interface and provide
    // specific implementations of the building steps. Your program may have
    // several variations of Builders, implemented differently.
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();
        
        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        public ConcreteBuilder()
        {
            this.Reset();
        }
        
        public void Reset()
        {
            this._product = new Product();
        }
        public void CAT()
        {
            this._product.Add("PartA1");
        }
        
        public void Frontpage()
        {
            this._product.Add("PartB1");
        }
        
        public void Articles()
        {
            this._product.Add("PartC1");
        }
		public void Reclame(){
			this._product.Add("PartC1");
		}

		public void Date(){
			this._product.Add("PartC1");
		}
		
		public void GetPaper(){
			this._product.Add("PartC1");
		}
		public class Product
    	{
        private List<object> _parts = new List<object>();
        
        public void Add(string part)
        {
            this._parts.Add(part);
        }
        
        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Product parts: " + str + "\n";
        }
    }
	public class Director
    {
        private  IBuilder _builder;
        
        public  IBuilder Builder
        {
            set { _builder = value; } 
        }
        
        // The Director can construct several product variations using the same
        // building steps.
        public void buildMinimalViablePaper()
        {
            this._builder.CAT();
        }
        
        public void Paper()
        {
            this._builder.CAT();
            this._builder.Frontpage();
            this._builder.Articles();
			this._builder.Reclame();
			this._builder.Date();
			

        }
    }

}
}
}