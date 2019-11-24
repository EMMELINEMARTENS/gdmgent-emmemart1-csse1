	using System;
using System.Threading;

namespace opdracht_7
{

    public abstract class Functions
    {
		// methodes
        // plus function
        public static string Plus(int getal1, int getal2)
        {
            int plusresult = getal1 + getal2;
        
            return "" + getal1 + " + " + getal2 + " = " + plusresult;
        }
    public static string Distract(int getal1, int getal2)
        {
            int distractresult = getal1 - getal2;
            return "" + getal1 + " - " + getal2 + " = " + distractresult;

        }
        public static string Multiply(int getal1,int getal2)
        {
            int multiplyresult = getal1 * getal2;
            return "" + getal1 + " * " + getal2 + " = " + multiplyresult;
        }
        public static string Divided(float getal1, float getal2)
        {
            float dividedresult = getal1 / getal2;
        return "" + getal1 + " / " + getal2 + " = " + dividedresult;
        }
        public static string modulo (int getal1, int getal2){
            int moduloresult = getal1 % getal2;
            return "" + getal1 + " % " + getal2 + " = " + moduloresult;
    } 
    // defineren random getal
    public static void GenereerWillekeurigGetal(){

            Random r = new Random();
            Schrijflog(r.Next());
        
        }
    public static int GenereerWillekeurigGetal(int min, int max){

            Random r = new Random();
            return r.Next(min,max);
        
        }
    public static int verhogen (int getal){
        getal++;
        return getal;
    }
        public static int verlagen (int getal){
        getal--;
        return getal;
    }
    /*
    1. modulo
    2. verhogen 
    3.verlagen
    */
    // loto oefening
        
        public static int genereerwillekeurigGetal(int min, int max){
            Random r = new Random();
            return r.Next(min, max);
        }
        
        public static void lottoTrekking(){
            Schrijflog("lottotrekking");
            for(int i = 0; i < 6; i++){
            Schrijflog(genereerwillekeurigGetal(1,45));
            }
            Thread.Sleep(5000);  
        }

        // sleep Thread -> per sessie ff slapen
        public static string Lottogetallen()
        {
            string output = " ";
            Schrijflog("lottogetallen");
            for(int i = 0; i < 6; i++)
                {
                output += genereerwillekeurigGetal(1,45) + " ";
            }
            return output;  
        }
        // euromillion
        public static string Euromillionsrooster()           
        {
            string output = "";
            Schrijflog("Euromillionstrekking");
            for(int j = 0; j < 5 ; j++){
            output += genereerwillekeurigGetal(1,50) + " ";
        }
            for(int i = 0;i < 2;i ++ ){
            Schrijflog(genereerwillekeurigGetal(1,12)); 
            
        };
        return output;
        }

        public static void Euromillionstrekking()           
        {
            Schrijflog("Euromillionstrekking");
            for(int j = 0; j < 5 ; j++){
            Schrijflog(genereerwillekeurigGetal(1,50));
            
        }
            for(int i = 0;i < 2;i ++ ){
            Schrijflog(genereerwillekeurigGetal(1,12)); 
            
        };
        }
        // generate accounts docent and student -> use .Substring
        public static void GenerateAccount(string functie, string voornaam, string achternaam )
        {
            if(functie.ToLower() == "docent" ){
            Schrijflog(GenereerDocentAcc(voornaam,achternaam));
            } else if(functie.ToLower() == "student"){
                Schrijflog(GenereerStudentAcc(voornaam, achternaam));
            }
        }

        static string GenereerDocentAcc(string voornaam, string achternaam){
        // empty string needed
        string Account = "";
        // checken of het een voornaam is van 4 letters
        if(voornaam.Length <= 4){
            Account += voornaam.ToLower();
        } else {
            Account += voornaam.ToLower().Substring(0,4);
        }
        // achternaam afkorten docent
        Account += achternaam.ToLower().Substring(0,2);

        return Account += "@arteveldehs.be";
        }
        static string GenereerStudentAcc(string voornaam, string achternaam){
        // empty string needed
        string Account = "";
        // checken of het een voornaam is van 4 letters
        if(voornaam.Length <= 4){
            Account += voornaam.ToLower();
        } else {
            Account += voornaam.ToLower().Substring(0,4);
        }
        // achternaam afkorten student
        if(voornaam.Length <= 4){
            Account += achternaam.ToLower();
        } else {
            Account += achternaam.ToLower().Substring(0,4);
        }
        return Account += "@student.arteveldehs.be";
        }
        public static bool IbanChecker(string IbanNum){
            string IbanNUMB = IbanNum.Replace(" ", "");
            int IBAN = Convert.ToInt32(IbanNUMB.Substring(4,15));
        if(IbanNUMB.Substring(0,2) == "BE" && IbanNUMB.Length == 16 ){
            int IbanCheck2 = Convert.ToInt32(IbanNum.Substring(0,3));
            
            if (IbanCheck2 >= 2 && IbanCheck2 <= 98)
            {
            string IbanReplace = IbanNUMB.Substring(0,3);
            string RemoveFront = IbanNUMB.Remove(0,3);
            string newIBAN = RemoveFront.Insert(RemoveFront.Length,IbanReplace);
            int Unicode = 35;

                    foreach (char BE in newIBAN)
                    {
                        if (Char.IsLetter(BE))
                        {
                            string NewIndex = Convert.ToString(BE - Unicode);
                            newIBAN = newIBAN.Replace(Convert.ToString(BE), NewIndex);
                        }
                    }
                    long ValidatedIBAN = Convert.ToInt64(newIBAN);
                    if (ValidatedIBAN % 97 == 1) return true;
                }
            }
            return false;
        }
    public static long factorial(int n)
        {
            long result = 1;
            for(int i = n; i > 0; i--) 
            {
                result *=i;
                Console.WriteLine(i);
            
            }
            return result;
        }
         // fibonnaci
        public static void fibonnaciFun(int valuelength)
        {
            // make a static function that is empty
            //declared the values
            int value1 = 0;
            int value2 = 1;
        

            for(int i = 1; i <= valuelength; i++ )
            {
                int number1 = value1;
                int result = value1 + value2;
                Console.WriteLine(result);
                value1 = value2;
                value2 += number1;
            }
        }
		// methods
	    // functie maken van console .
        static void Schrijflog(string output) => Console.WriteLine(output);
        static void Schrijflog(int output) => Console.WriteLine(output.ToString());
    
        }    
}
;