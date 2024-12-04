namespace Übungsaufgabe_Polymorphie;

public class Königin : Person
{
    public override double BerechneZuVersteuerndesEinkommen()
    {
        return 0;
    }

    public override double BerechneSteuer(double zuVersteuerndesEinkommen, double steuerSatz)
    {
        return 0;
    }
}