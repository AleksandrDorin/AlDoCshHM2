// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Write("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());

if ( day == 6 )
{
    Console.WriteLine("День недели является выходным!");
}
else if (day == 7)
{
    Console.WriteLine("День недели является выходным!");
}
else if (day > 7)
{
    Console.WriteLine("Несуществует такого номера дня недели!");
}
else
{
    Console.WriteLine("День недели является будним!");   
}
