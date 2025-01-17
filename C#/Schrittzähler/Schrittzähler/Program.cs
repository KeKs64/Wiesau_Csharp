    int AllSchritte = 0;
int Durchschnitt;
for (int i = 1; i <= 7; i++)
{
Console.Write($"Geben Sie die Schritte für Tag {i} ein: ");
    int Schritte = Convert.ToInt32(Console.ReadLine());
    AllSchritte = Schritte + AllSchritte;
}
Console.WriteLine($"Gesamtschritte in der Woche: {AllSchritte}");
Durchschnitt = AllSchritte / 7;
Console.WriteLine($"Durchschnitt Schritte pro Tag: {Durchschnitt}");