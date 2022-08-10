// Найти кубы чисел от 1 до N.

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int a = 1;

while (a <= n)
{
    double res = Convert.ToInt32(Math.Pow(a, 3)); // double res = a * a * a;
    a++;
    Console.WriteLine(res++);
}
