Console.Write("Ist Ihre Zahl gerade oder ungerade (1-10): ");
double Zahl = Convert.ToInt32(Console.ReadLine());


if (Zahl <= 10 && Zahl >= 1)
{
Zahl = Zahl % 2;
    switch (Zahl)
    {
        case 0:
            Console.WriteLine("Die Zahl ist gerade");
            break;
        case 1:
            Console.WriteLine("Die Zahl ist ungerade");
            break;
    }
}
else
    Console.WriteLine("Zahl ist nicht zwischen 1 und 10");