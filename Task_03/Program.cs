// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine());


if (num == 1)
{
    Console.WriteLine("Диапозон координат первой четверти будет равен" );
    Console.WriteLine("x ( 0 ; + бесконечность )" );
    Console.WriteLine("y ( 0 ; + бесконечность )" );
}

else if (num == 2)
{
    Console.WriteLine("Диапозон координат второй четверти будет равен" );
    Console.WriteLine("x ( - бесконечность ; 0 )" );
    Console.WriteLine("y ( 0 ; + бесконечность ) " );
}

else if (num == 3)
{
    Console.WriteLine("Диапозон координат первой четверти будет равен" );
    Console.WriteLine("x ( - бесконечность ; 0 )" );
    Console.WriteLine("y ( - бесконечность ; 0 )" );
}

else if (num == 4)
{
    Console.WriteLine("Диапозон координат первой четверти будет равен" );
    Console.WriteLine("x ( 0 ; + бесконечность )" );
    Console.WriteLine("y ( - бесконечность ; 0 )" );
}

else if ( num < 1)
{
    Console.WriteLine("Такой четверти координат не существует" );
}

else if ( num > 4)
{
    Console.WriteLine("Такой четверти координат не существует" );
}