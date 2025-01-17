Console.Write("Im wie vielten Beschäftigungs Jahr befinden Sie sich?: ");
int Beschäftigugnsjahr = Convert.ToInt32(Console.ReadLine());

if (Beschäftigugnsjahr == 1)
{
    Console.WriteLine("4000 Euro im Monat");
}
else if (Beschäftigugnsjahr == 2)
{
    Console.WriteLine("4300 Euro im Monat");
}
else if (Beschäftigugnsjahr >= 3)
{
    int Monatsgeld = (Beschäftigugnsjahr -3) * 100;
    Monatsgeld = Monatsgeld + 4300;
    Console.WriteLine($"{Monatsgeld} Euro im Monat");
}