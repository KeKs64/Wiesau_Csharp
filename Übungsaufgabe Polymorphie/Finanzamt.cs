    namespace Übungsaufgabe_Polymorphie;

    public static class Finanzamt
    {
        public static double berechneGesamteSteuerEinnahmen(Person[] personen)
        {
            double gesamteSteuer = 0;
            foreach (Person person in personen)
            {
                double zuVersteuerndesEinkommen = person.BerechneZuVersteuerndesEinkommen();
                double steuer = person.BerechneSteuer(zuVersteuerndesEinkommen);
                gesamteSteuer += steuer; 
            }
            
            return gesamteSteuer;
        }
    }