// Найти кубы чисел от 1 до N

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int a = 1;

while (a <= n)
{
    // int res = a * a * a;
    int res = Convert.ToInt32(Math.Pow(a, 3));
    a++;
    Console.WriteLine(res++);
}
