using System;
namespace opdracht_7
{
    public abstract class Logging
    {
		public  abstract void LogOutput();
	}
    
    public class Person1 : Logging
    {
        // fields (eigenschappen)
        public string firstname;
        public string name;
        private char gender;

        // properties (instantie van de klasse)
        public char Gender {
            get 
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
		public string Name {
            get 
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
		
        
        // constructor (this toevoegen aan instantie)

        // empty function Person1
        public Person1()
        {
            
        }

        // function firstname + name
		public Person1(string firstname, string name)
		{
			Name = name;
			this.firstname = firstname;
		}

        // function firstname, name, gender
		public Person1(string firstname, string name , char gender)
		{
			Name = name;
			this.firstname = firstname;
			Gender = gender;
		}

        // methodes
        
    public  override void LogOutput(){
        Console.WriteLine(string.Format("Output: firstname:{0}, Name: {1}, Gender:{2}, gender : {3}", this.firstname, Name, Gender, this.gender)); 
        }
        
    }
}