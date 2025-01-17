Console.Write("Wie viel Grad hat es?: ");
int Grad = Convert.ToInt32(Console.ReadLine());

if  (Grad < 10)
{
    Console.WriteLine("Jacke anziehen");
}
else if (Grad >= 10 && Grad <= 20)
{
    Console.WriteLine("Pullover anziehen");
}
else if (Grad > 20)
{
    Console.WriteLine("T-Shirt reicht");
}