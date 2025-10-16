Console.WriteLine("------------------------------");
Console.WriteLine("|       x       |       y     |");
Console.WriteLine("------------------------------");
for (double x = -0.5; x <= 5; x += 0.2)
{
    double y;
    if (x > 4.5)
        y = 2 * x;
    else if (x >= 0 && x <= 4.5)
        y = 1 - Math.Log(Math.Abs(1 + Math.Pow(x, 2)));
    else 
        y=Math.Exp(x);
    Console.WriteLine($"| {x,8:F2}   | {y,14:F2} |");
}
Console.WriteLine("------------------------------");
