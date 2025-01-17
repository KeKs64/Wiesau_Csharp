double ergebnis;

Console.Write("Gib Zahl 1 ein: ");
double Zahl1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Gib Zahl 2 ein: ");
double Zahl2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Wo mit wollen sie rechnen? + - * / % ('a' für alle rechnungen): ");
char Rechenzeichenn = Convert.ToChar(Console.ReadLine());

switch (Rechenzeichenn)
{
    case '+':
        ergebnis = Zahl1 + Zahl2;
        Console.WriteLine(ergebnis);
        break;
    case '-':
        ergebnis = Zahl1 - Zahl2;
        Console.WriteLine(ergebnis);
        break;
    case '*':
        ergebnis = Zahl1 * Zahl2;
        Console.WriteLine(ergebnis);
        break;
    case '/':
        ergebnis = Zahl1 / Zahl2;
        Console.WriteLine(ergebnis);
        break;
    case '%':
        ergebnis = Zahl1 % Zahl2;
        Console.WriteLine(ergebnis);
        break;
    case 'a':
        ergebnis = Zahl1 + Zahl2;
        Console.WriteLine(ergebnis);
        ergebnis = Zahl1 * Zahl2;
        Console.WriteLine(ergebnis);
        ergebnis = Zahl1 - Zahl2;
        Console.WriteLine(ergebnis);
        ergebnis = Zahl1 % Zahl2;
        Console.WriteLine(ergebnis);
        break;
    default:
        ergebnis = 0;
        break;
}