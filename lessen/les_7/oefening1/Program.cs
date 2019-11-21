using System;

namespace oefening_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person1 p1 = new Person1();
            p1.firstname = "Emmeline";
            p1.Gender = 'V';
            p1.Name = "Martens";
            p1.LogOutPut();
            Person1 p2 = new Person1("Parent", "Oliver", 'M');
            p2.LogOutPut();
            User user1 = new User("Eva", "Martens", 'V');
            Student s1 = new Student("Emmeline", "Martens", 'V');
            Docent docent1 = new Docent("Evelien", "Rutsaert", 'V');
            

        }
    }
}