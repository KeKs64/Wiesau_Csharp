int MitgliedsID = 0;
string Vorname = "";
bool Premium = false;
string Email = "";
int GebuchtenTrainingstunden = 0;
int BesuchteKurse = 0;
string TrainingsZiel = "";
string Telefonnummer = "";
string Webseite = "WorldGym.com/service";

int Aufgabe = 0;

Console.WriteLine("Welche Aufgabe möchten Sie? (1/2):");
Aufgabe = Convert.ToInt32(Console.ReadLine());
Console.Clear();

switch (Aufgabe)
{
    case 1:

        Console.WriteLine("Wie lautet Ihre MitgliedsID?");
        MitgliedsID = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Wie lautet Ihr Name");
        Vorname = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Besitzen Sie eine Premium Mitgliedschaft");
        Premium = Convert.ToBoolean(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Wie lautet Ihre E-Mail");
        Email = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Wie viele gebuchten Trainingsstunden haben sie noch?");
        GebuchtenTrainingstunden = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Wie viele Kurse haben sie bereits besucht?");
        BesuchteKurse = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Wie lautet Ihr Trainings Ziel?");
        TrainingsZiel = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Wie lautet Ihre Telefonnummer?");
        Telefonnummer = Console.ReadLine();
        Console.Clear();

        Console.WriteLine($"Hallo {Vorname}, Sie haben {GebuchtenTrainingstunden} Trainingsstunden gebucht und Ihr Trainingsziel lautet: {TrainingsZiel}.");
        break;

    case 2:
        Console.WriteLine("Wie lautet Ihr Name");
        Vorname = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Wie viele gebuchten Trainingsstunden haben sie noch?");
        GebuchtenTrainingstunden = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Wie lautet Ihr Trainings Ziel?");
        TrainingsZiel = Console.ReadLine();
        Console.Clear();

        string Wochentag;
        Console.WriteLine("Wann möchten sie ihre nächste Trainingsstunde? (Wochentag)");
        Wochentag = Console.ReadLine();
        Console.Clear();

        string Uhrzeit;
        Console.WriteLine("Wann möchten sie ihre nächste Trainingsstunde? (Uhrzeit)");
        Uhrzeit = Console.ReadLine();
        Console.Clear();

        Console.WriteLine($"Hallo {Vorname},\r\nleider haben wir festgestellt, dass Sie Ihr geplantes Training heute versäumt haben.\r\nDamit Sie Ihre {GebuchtenTrainingstunden}. Trainingsstunden komplett ausschöpfen können und Ihr Trainingsziel: „{TrainingsZiel}“\r\nerreichen, findet Ihr nächstes Training am {Wochentag} um {Uhrzeit} Uhr statt.\r\nWenn Sie Fragen haben oder Ihr Training umplanen möchten, besuchen Sie bitte:\r\n{Webseite}");
        break;
}
        Console.ReadKey();