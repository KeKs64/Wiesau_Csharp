using Typumwandlung_von_Objektvariablen;

// Objekt vom Typ Zeppelin wird erstellt und der Referenz zpln zugewiesen:

Zeppelin zpln = new Zeppelin(); 

// Klassenbezogene Referenz = neues Objekt
// Im Objekt werden die Daten hinterlegt, die Referenz "zeigt" auf das Objekt

// Dem Objekt werden Daten zugewiesen:
zpln.Baujahr = 2015;
zpln.Hersteller = "DZR";
zpln.Gasvolumen = 345;

// Hier wird KEIN neues Objekt angelegt, sondern nur eine neue Referenz.
// Dieser wird dann die obige Referenz zugewiesen.
// lfzg "zeigt" nun auf dasselbe Objekt wie zpln.
Luftfahrzeug lfzg = zpln; 

// Überprüfung: Beide Referenzen greifen auf dasselbe Objekt zu.
Console.WriteLine(zpln.Baujahr); // Ausgabe: 2015
Console.WriteLine(lfzg.Baujahr); // Ausgabe: 2015

// Wir ändern nur über eine Referenz das Baujahr
lfzg.Baujahr = 2016;
Console.WriteLine(zpln.Baujahr); // Ausgabe: 2016

// geht nicht:
// lfzg.Gasvolumen = 200; 
// dazu müssen wir erst den Objekttyp umwandeln mit einem Cast!
// Die Referenz lfzg ist vom Typ Luftfahrzeug und kennt die Eigenschaft Gasvolumen nicht.

// Möglichkeit 1: Expliziter Cast

// Allgemeines Beispiel:
Luftfahrzeug lufa;
Flugzeug flgz = new Flugzeug();
lufa = flgz; // Implizite Konvertierung, da Flugzeug von Luftfahrzeug erbt

Flugzeug f = (Flugzeug)lufa; // Expliziter Cast zurück zu Flugzeug

// Für unser Zeppelin-Beispiel:
Zeppelin zpln2 = (Zeppelin)lfzg; // Expliziter Cast von Luftfahrzeug zu Zeppelin

// Jetzt geht es!
zpln2.Gasvolumen = 200; 

Console.WriteLine(zpln.Gasvolumen); // Ausgabe: 200

// Möglichkeit 2: Mittels as-Operator

Zeppelin zpln3 = lfzg as Zeppelin; 

if (zpln3 != null)
{
    zpln3.Gasvolumen = 200;
}
else
{
    Console.WriteLine("Die Umwandlung war nicht erfolgreich.");
}