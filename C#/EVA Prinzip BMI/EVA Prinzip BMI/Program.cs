

Console.Write("Geben Sie Ihr Gewicht ein (kg): ");
double gewicht = Convert.ToDouble(Console.ReadLine());

Console.Write("Und nun Ihre Größe (m): ");
double größe = Convert.ToDouble(Console.ReadLine());

double bmi = gewicht / (größe * größe);

Console.WriteLine($"Ihre BMI: {bmi}");