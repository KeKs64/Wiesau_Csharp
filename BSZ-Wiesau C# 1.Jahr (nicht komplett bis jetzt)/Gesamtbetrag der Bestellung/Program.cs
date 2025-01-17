Console.Write("Wie viel ist Ihr Bestellwert: ");
double Bestellwert = Convert.ToDouble(Console.ReadLine());
double Ergebnis;

if (Bestellwert < 100)
{
    Console.WriteLine($"Ihr Gesamtbetrag ist: {Ergebnis = Bestellwert + 6.5} Euro");
}
else if (Bestellwert >= 100)
{
    Console.WriteLine($"Ihr Gesamtbetrag ist: {Bestellwert} Euro");
}