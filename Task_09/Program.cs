// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine());
int i = 1;
double pow = 1;

for(i = 1; i <= a ; i += 1)
{
    pow *= i;
    Console.WriteLine(i);
  
}

Console.WriteLine("Произведение чисел будет равно " + pow );
