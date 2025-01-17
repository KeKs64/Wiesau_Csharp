namespace Fitnessstudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Language (De,En): ");
            string sprache = Console.ReadLine();
            sprache = sprache.ToUpper();

            if (sprache == "DE")
            {
                Console.Write("Bitte Vornamen eingeben: ");
                string Vorname = Console.ReadLine();
                Console.Write("Bitte Namen eingeben: ");
                string Nachname = Console.ReadLine();
                Console.Write("Bitte Alter eingeben: ");
                int Alter = Convert.ToInt32(Console.ReadLine());
                Console.Write("Bitte ID eingeben: ");
                int ID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Bitte Adresse eingeben: ");
                string Adresse = Console.ReadLine();



                Console.Clear();

                Console.WriteLine($"Name: {Nachname} {Vorname}");
                Console.WriteLine($"Alter: {Alter}");
                Console.WriteLine("ID: " + ID);
                Console.WriteLine("Adresse: " + Adresse);
            }
            else if (sprache == "EN")
            {
                Console.Write("Please enter first name: ");
                string Firstname = Console.ReadLine();
                Console.Write("Please enter last name: ");
                string Lastname = Console.ReadLine();
                Console.Write("Please enter age: ");
                int Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter ID: ");
                int ID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter adress: ");
                string Adress = Console.ReadLine();



                Console.Clear();

                Console.WriteLine($"name: {Lastname} {Firstname}");
                Console.WriteLine($"age: {Age}");
                Console.WriteLine("ID: " + ID);
                Console.WriteLine("adress: " + Adress);
            }
            else
                Console.WriteLine("This wasn't a valid language");




        }
    }
}