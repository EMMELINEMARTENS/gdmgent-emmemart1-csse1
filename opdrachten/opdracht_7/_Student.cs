using System;
namespace opdracht_7
{
    public class Student : User
    {
		
         // Constructors
        public Student (string firstname, string name, char gender, string password) : base(firstname, name, gender){
            // Genereer Wachtwoord
            this.password = Generatepassword();
            this.username = Generateusername();
            this.login = GenerateLogin();
        }

        // methodes
		private string Generatepassword()
        {
            this.password = Password;
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

        public  override string GenerateLogin()
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