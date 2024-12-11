//bisher haben wir die Möglichkeit von fehlerhaften Usereingaben ignoriert.

//Beispiel: Eingabe einer Zahl

Console.WriteLine("Bitte geben Sie eine Zahl ein:");

//Hier ist die potenzielle Fehlerquelle die Methode Convert.ToInt32(). Wird ein Wert eingegeben,
//der nicht in einen Int umgewandelt werden kann, wird eine sog. Exception geworfen.
try
{
    int zahl = Convert.ToInt32(Console.ReadLine());
    
    //Sobald eine Exception auftritt, wird der try-Block verlassen. Code der nach der Exception im try-Block
    //kommen würde, wird nicht mehr ausgeführt.
    Console.WriteLine(zahl);
}
//Sollte eine FormatException auftreten, wird dieser Codeblock ausgeführt.
catch (FormatException)
{
    Console.WriteLine("Ihre Eingabe war keine Zahl!");
}
