
Console.Write("Wie schnell fahren Sie (km/h): ");
double geschwindigkeit = Convert.ToDouble(Console.ReadLine());

double mindestabstand;

mindestabstand = geschwindigkeit / 2;

Console.WriteLine(mindestabstand + " m");

double Reaktionsweg;
double Bremsweg;

Reaktionsweg = geschwindigkeit * 3 / 10;
Bremsweg = (geschwindigkeit / 10) * (geschwindigkeit / 10);

Console.WriteLine(Reaktionsweg + Bremsweg);