using System.Threading.Channels;

Console.WriteLine("În welche einheit wollen Sie umrechnen: " +
    "\n 1: inch, " +
    "\n 2: foot, " +
    "\n 3: yard, " +
    "\n 4: mile");
int einheit = Convert.ToInt32(Console.ReadLine());
double imp;
double met = 0;
Console.WriteLine("Wie viel davon möchten Sie umrechnen: ");
imp = Convert.ToDouble(Console.ReadLine());
switch (einheit)
{
    case 1:
        met = imp * 0.0254;
        break;
    case 2:
        met = imp * 0.3048;
        break;
    case 3:
        met = imp * 0.9144;
        break;
    case 4:
        met = imp * 1609.34;
        break;
}
Console.WriteLine($"In Meter: {met}");
