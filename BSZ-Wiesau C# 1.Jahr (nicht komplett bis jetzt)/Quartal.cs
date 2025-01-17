Console.Write("Welcher Monat?: ");
string monat =  Console.ReadLine();
monat = monat.ToLower();
int quartel = 0;
switch (monat)
{
    case "januar":
    case "februar":
    case "märz":
        quartel = 1;
        break;
    case "april":
    case "mai":
    case "juni":
        quartel = 2;
        break;
    case "juli":
    case "august":
    case "september":
        quartel = 3;
        break;
    case "oktober":
    case "november":
    case "dezember":
        quartel = 4;
        break;
}
Console.WriteLine($"Ihr Monat {monat} befindet sich im {quartel}. Quartel");