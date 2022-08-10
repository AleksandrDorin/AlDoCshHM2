// Определить количество цифр в числе.

Console.WriteLine("Введите число: ");
string a = Console.ReadLine();
int i = 0;

while(i < a.Length)
{
    i += 1;
}

Console.WriteLine("Число "+ a +" содержит в себе " + i + " цифр");


