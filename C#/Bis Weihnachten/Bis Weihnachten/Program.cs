using System.ComponentModel.Design;

Console.Write("Noch wie viele Tage bist Weihnachten: ");

for (int Tage = Convert.ToInt32(Console.ReadLine()); Tage >= 0; Tage--)
{
    if (Tage == 10)
        Console.WriteLine($"Noch {Tage} Tage bis Weihnachten - Fast da!");
    else if (Tage == 5)
        Console.WriteLine($"Noch {Tage} Tage bis Weihnachten - Bereitmachen!");
    else if (Tage == 1)
        Console.WriteLine($"Noch {Tage} Tage bis Weihnachten - Morgen ist es soweit!");
    else if (Tage == 0)
        Console.WriteLine("Es ist Weihnachten");
    else
        Console.WriteLine($"Noch {Tage} Tage bis Weihnachten");
}