// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine("Число " + a + " является квадратом числа " + b);
}

else if (b == a * a)
{
    Console.WriteLine("Число " + b + " является квадратом числа " + a);
}

Console.WriteLine("Введенные числа не являются квадратами друг друга");