// Найти сумму чисел от 1 до А

Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine());
int i = 1;
int sum = 0;

for(i = 1; i <= a ; i += 1)
{
    sum += i;
    Console.WriteLine(i);
}

Console.WriteLine("Сумма чисел от 1 до " + a + " = " + sum );


