using System;
using System.IO.Compression;

namespace BSWiesau1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensch[] people = new Mensch[5];
            
            Schüler Testschüler = new Schüler("Testschülervorname", "Testschülernachname", RandomDay(), "sechsA");
            Lehrer Testlehrer = new Lehrer("Testlehrervorname", "Testlehrernachname", RandomDay());
            Personal Testpersonal = new Personal("Testpersonalvorname", "Testpersonalnachname", RandomDay(), "Unbekannt");
            
            
            
            people[0] = Testschüler;
            people[1] = Testlehrer;
            people[2] = Testpersonal;
            
            foreach (Mensch person in people)
            {
                if (person is null) continue;
                Console.WriteLine(person.Vorname);
                Console.WriteLine(person.Nachname);
                Console.WriteLine(person.Geburtsdatum.ToShortDateString());
                person.Sprechen();
                person.Arbeiten();
            }
        }

        private static Random gen = new Random();

        static DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}