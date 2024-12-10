namespace Übungsaufgabe_Polymorphie;

public class Person
{
    protected string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name darf nicht leer sein.");
            }
            _name = value;
        }
    }

    protected double Einkommen
    {
        get
        {
            return _einkommen;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Einkommen darf nicht negativ sein.");
            }
            _einkommen = value;
        }
    }
    
    protected double ZuVersteuerndesEinkommen { get; set; }
    
    protected double Steuer { get; set; }

    public string _name;
    
    public double _einkommen;
    
    public virtual double BerechneZuVersteuerndesEinkommen()
    {
        ZuVersteuerndesEinkommen = Einkommen;
        return ZuVersteuerndesEinkommen;
    }

    public virtual double BerechneSteuer(double zuVersteuerndesEinkommen, double steuerSatz = 0.25)
    {
        Steuer = zuVersteuerndesEinkommen*steuerSatz;
        return Steuer;
    }
}

