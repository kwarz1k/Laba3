try
{
    Console.WriteLine("Введите значение n: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение x: ");
    double x =int.Parse(Console.ReadLine());
    Console.WriteLine("Введите факториал с:");
    double c =int.Parse(Console.ReadLine());
    double s = 0;
    for (int i = 0; i <= n; i++)
    {
        с=(с-1);
        double F = c;
        s += Math.Cos(i * x) / F;
    }
    Console.WriteLine($"S={s:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
