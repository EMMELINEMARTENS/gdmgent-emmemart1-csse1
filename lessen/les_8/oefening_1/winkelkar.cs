using System;

namespace oefening_1
{
	public abstract class Winkelkar
	{
		public abstract void Ontgrendelen();

		public abstract void Rijden();
	}
	public class Grotekar : Winkelkar
	{
		public Grotekar()
		{
		}

		public override void Ontgrendelen()
		{
			throw new NotImplementedException();
		}

		public override void Rijden()
		{
			throw new NotImplementedException();
		}

		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string ToString()
		{
			return base.ToString();
		}

	
	}


}