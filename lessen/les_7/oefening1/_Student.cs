using System;
namespace oefening_1
{
    public class Student : User
    {
		
         // Constructors
        public Student (string voornaam, string familienaam, char geslacht) : base(voornaam, familienaam, geslacht){
            LogOutput();
            // Genereer Wachtwoord
            this.password = Generatepassword();
            this.username = Generateusername();
            this.login = GenerateLogin();
        }

        // methodes
		private string Generatepassword()
        {
            return Password;
        }

        private string Generateusername()
        {
        
        // empty string needed
        string Account = "";

            Account += firstname.ToLower().Substring(0,4);
        
        // achternaam afkorten docent
        Account += name.ToLower().Substring(0,4);

        return Account;
        }

        override public string GenerateLogin()
        {
            string Account = " ";
            Account = Generateusername();
            return Account += "@student.arteveldehs.be";
        }
		public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        
    }
}