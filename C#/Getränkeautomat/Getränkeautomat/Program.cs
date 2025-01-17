Console.WriteLine("Wählen Sie Ihr Getränk mit der entsprechenden Nummer aus: " +
    "\n 1) Wasser (0,50 Euro) " +
    "\n 2) Limonade (1,00 Euro) " +
    "\n 3) Bier (2,00 Euro)");
int Getränk = Convert.ToInt32(Console.ReadLine());
double Geld;

switch (Getränk)
{
    case 1:
        Console.Write("Bitte werfen Sie 0,50 Euro ein: ");
        Geld = Convert.ToDouble(Console.ReadLine());
        if (Geld > 0.5)
            Console.WriteLine($"Hier ist ihr Rückgeld {Geld - 0.5}");
        break;
    case 2:
        Console.Write("Bitte werfen Sie 1,00 Euro ein: ");
        Geld = Convert.ToDouble(Console.ReadLine());
        if (Geld > 1)
            Console.WriteLine($"Hier ist ihr Rückgeld {Geld - 1}");
        break;
    case 3:
        Console.Write("Bist du denn überhaupt schon 16? Bitte geben sie ihr Alter ein:");
        int Alter = Convert.ToInt32(Console.ReadLine());
        if (Alter >= 16)
        {
            Console.Write("Bitte werfen Sie 2,00 Euro ein: ");
            Geld = Convert.ToDouble(Console.ReadLine());
            if (Geld > 2)
                Console.WriteLine($"Hier ist ihr Rückgeld {Geld - 2}");
        }
        else
            Console.WriteLine("Du bist nicht Alt genug!");
        break;
}
Console.WriteLine("Danke für Ihren Einkauf! Bitte nehmen Sie Ihr Getränk");