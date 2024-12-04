namespace Übungsaufgabe_Polymorphie;

public class Arbeiter : Person
{

    public override double BerechneZuVersteuerndesEinkommen()
        => ZuVersteuerndesEinkommen = Einkommen - 2400;

    public override double BerechneSteuer(double zuVersteuerndesEinkommen, double steuerSatz)
        => Steuer = zuVersteuerndesEinkommen * steuerSatz;
}