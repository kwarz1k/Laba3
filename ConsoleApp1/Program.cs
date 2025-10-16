//Оператор цикла for 10 вариант Базовый уровень
Console.WriteLine("Введите число N (>0): ");
int N = int.Parse(Console.ReadLine());
double result = 2;
for (int i = 2; i <= N; i++)
{
    result = result * (1.0 / i);
}
Console.WriteLine("Результат =" + result);