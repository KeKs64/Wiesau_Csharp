namespace Übungsaufgabe_Polymorphie;

public class Banker : Person
{
    public override double BerechneZuVersteuerndesEinkommen()
    {
        return Einkommen;
    }

    public override double BerechneSteuer(double zuVersteuerendesEinkommen, double steuersatz) 
        => Steuer = ((zuVersteuerendesEinkommen * steuersatz)+1000);
}