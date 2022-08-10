// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int a = 1;

while (a <= n)
{
    
    int res = Convert.ToInt32(Math.Pow(a, 3));
    
    if (res % 2 == 0)
    {
        Console.WriteLine(res++);
    }

    a++;
}
