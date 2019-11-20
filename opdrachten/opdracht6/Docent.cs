using System;
namespace oefening_1
{
    public class Docent : User
    {
		
         // Constructors
        public Docent (string voornaam, string familienaam, char geslacht) : base(voornaam, familienaam, geslacht){
            LogOutput();
            // Genereer Wachtwoord
            this.password = Generatepassword();
            this.username = GenerateUsername();
            this.login = GenerateLogin();
        }

        // methodes
		private string Generatepassword()
        {
            return Password;
        }

        private string GenerateUsername()
        {
        
        // empty string needed
        string Account = "";

            Account += firstname.ToLower().Substring(0,4);
        
        // achternaam afkorten docent
        Account += name.ToLower().Substring(0,4);

        return Account;
        }

        private string GenerateLogin()
        {
            string Account = " ";
            Account = GenerateUsername();
            return Account += "@arteveldehs.be";
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