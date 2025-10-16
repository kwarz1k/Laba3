//Операторы цикла с предусловием и постусловием 10 вариант Средний уровень
Console.Write("Введите число m: ");
double m = double.Parse(Console.ReadLine());
int x = 100;
do
{
    if (x / 100 % 2 == 1)
    {
        double result = Math.Pow(x, 3) * m;
        Console.WriteLine("x = " + x + " " + result);
    }
    x += 100;
}
while (x <= 1000);