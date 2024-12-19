using Buchhaltungssoftware;

List<Konto> kontenliste = new List<Konto>();

while (true)
{
    Console.WriteLine("\nBuchhaltungssoftware");
    Console.WriteLine("1. Konto erstellen");
    Console.WriteLine("2. Einzahlung tätigen");
    Console.WriteLine("3. Abhebung tätigen");
    Console.WriteLine("4. Kontoauszug anzeigen");
    Console.WriteLine("5. Programm beenden");

    Console.Write("Wähle eine Option: ");
    string eingabe = Console.ReadLine();
    Konto konto;
    decimal betrag;
    string beschreibung;
    switch (eingabe)
    {
        case "1":
            // Konto erstellen
            Console.WriteLine("\nKonto erstellen:");
            Console.WriteLine("1. Girokonto");
            Console.WriteLine("2. Sparkonto");
            Console.Write("Wähle den Kontotyp: ");
            string kontoTyp = Console.ReadLine();

            Console.Write("Gib die Kontonummer ein: ");
            string kontonummer = Console.ReadLine();

            switch (kontoTyp)
            {
                case "1":
                    Console.Write("Gib das Überziehungslimit ein: ");
                    decimal überziehungslimit = Convert.ToDecimal(Console.ReadLine());
                    Girokonto girokonto = new Girokonto(kontonummer, überziehungslimit);
                    kontenliste.Add(girokonto);
                    Console.WriteLine("Girokonto erfolgreich erstellt.");
                    break;
                case "2":
                    Console.Write("Gib den Zinssatz ein: ");
                    decimal zinssatz = Convert.ToDecimal(Console.ReadLine());
                    Sparkonto sparkonto = new Sparkonto(kontonummer, zinssatz);
                    kontenliste.Add(sparkonto);
                    Console.WriteLine("Sparkonto erfolgreich erstellt.");
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe.");
                    break;
            }
            break;
        case "2":
            // Einzahlung tätigen
            Console.WriteLine("\nEinzahlung tätigen:");
            Console.Write("Gib die Kontonummer ein: ");
            string kontonummerEinzahlung = Console.ReadLine();

            // Konto in Liste finden
             konto = kontenliste.Find(k => k.Kontonummer == kontonummerEinzahlung);

            // Fehlerbehandlung, falls Konto nicht gefunden wird
            if (konto == null)
            {
                Console.WriteLine("Konto nicht gefunden.");
                break;
            }

            Console.Write("Gib den Betrag ein: ");
            betrag = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Gib die Beschreibung ein: ");
            beschreibung = Console.ReadLine();

            // Einzahlung auf Konto buchen
            konto.Einzahlen(betrag, beschreibung);

            Console.WriteLine("Einzahlung erfolgreich.");
            break;
        case "3":
            //Abhebung tätigen
            Console.WriteLine("\nAbhebung tätigen:");
            Console.Write("Gib die Kontonummer ein: ");
            string kontonummerAbhebung = Console.ReadLine();

            // Konto in Liste findenkonto = kontenliste.Find(k => k.Kontonummer == kontonummerAbhebung);
            konto = kontenliste.Find(k => k.Kontonummer == kontonummerAbhebung);
            // Fehlerbehandlung, falls Konto nicht gefunden wird
            if (konto == null)
            {
                Console.WriteLine("Konto nicht gefunden.");
                break;
            }

            Console.Write("Gib den Betrag ein: ");
            betrag = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Gib die Beschreibung ein: ");
            beschreibung = Console.ReadLine();

            // Abhebung auf Konto buchen
            konto.Abheben(betrag, beschreibung);
            break;
        case "4":
            // Kontoauszug anzeigen
            Console.WriteLine("\nKontoauszug anzeigen");
            Console.WriteLine("Gib die Kontonummer ein: ");
            string kontonummerAnzeigen = Console.ReadLine();
            konto = kontenliste.Find(k => k.Kontonummer == kontonummerAnzeigen);
            if (konto == null)
            {
                Console.WriteLine("Konto nicht gefunden.");
                break;
            }
            konto.TransaktionenAnzeigen();
            break;
        case "5":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Ungültige Eingabe.");
            break;
    }
}