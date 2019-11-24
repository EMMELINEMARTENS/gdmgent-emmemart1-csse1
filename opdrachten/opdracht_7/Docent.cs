using System;
namespace opdracht_7
{
    public class Docent : User
    {
		
         // Constructors
        public Docent (string firstname, string name, char gender) : base(firstname, name, gender){
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
        Account += name.ToLower().Substring(0,2);

        return Account;
        }

        public  override string GenerateLogin()
        {
            string Account = " ";
            Account = Generateusername();
            return Account += "@arteveldehs.be";
        }
		
        
    }
}