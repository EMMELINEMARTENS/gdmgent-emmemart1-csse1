using System;    
namespace opdracht_7
{
public class User : Person1 {
        // Velden
        protected string username;
        protected string password;
        protected string login;

        // Properties
        public string Username
        {
            get
            {
                return username;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
        }

        public string Login
        {
            get
            {
                return login;
            }
        }



        // Constructors
        public User(string firstname, string name, char gender, string test)
        {   
            this.firstname = firstname;
            Name = name;
            Gender = gender;
        }

        public   User(string firstname, string name, char gender) : base(firstname, name, gender){
            // Genereer Wachtwoord
            this.password = Generatepassword();
            this.username = GenerateUsername();
            this.login = GenerateLogin();
            LogOutput();
        }

        


        // Methoden
        private string Generatepassword()
        {
            string output = "";
            for (int i = 0; i < 10; i++)
            {
                Random number = new Random();
                output += (char)number.Next(40, 122);
            }
            return output;
        }

        private string GenerateUsername()
        {
        
        // empty string needed
        string Account = "";

            Account += firstname.ToLower().Substring(0,2);
        
        // achternaam afkorten docent
        Account += name.ToLower().Substring(0,3);

        return Account;
        }

        virtual public string GenerateLogin()
        {
            string Account = " ";
            Account = GenerateUsername();
            return Account += "@arteveldehs.be";
        }

        public override void LogOutput()
        {
            Console.WriteLine(String.Format("Output : firstname: {0}, Name: {1}, Gender: {2}, gender: {3}, Username: {4}, Login: {5}, Password: {6}", this.firstname, Name, Gender, this.Gender, Username, Login, Password));
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
    