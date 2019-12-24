using System;
using System.Collections.Generic;

namespace opdracht8
{
    // The Builder interface specifies methods for creating the different parts
    // of the Product objects.

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
    public class INewspaper_Metro : IBuilder
    {
        private Metro _product = new Metro();
        
        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        public INewspaper_Metro()
        {
            this.Reset();
        }
        
        public void Reset()
        {
            this._product = new Metro();
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
		public class Metro
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
    public class INewspaper_HLN : IBuilder
    {
        private HLN _product = new HLN();
        
        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        public INewspaper_HLN()
        {
            this.Reset();
        }
        
        public void Reset()
        {
            this._product = new HLN();
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
		public class HLN
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
        
        public void NewsPaperMetro()
        {
            this._builder.CAT();
            this._builder.Frontpage();
            this._builder.Articles();
			this._builder.Reclame();
			this._builder.Date();
			

        }
          public void NewsPaperHLN()
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
