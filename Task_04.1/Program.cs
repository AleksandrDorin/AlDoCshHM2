// Найти расстояние между точками в пространстве 3D

Console.WriteLine("Введите три координаты в 3D пространстве");

Console.WriteLine("Введите первую координату точки A");
int cx = int.Parse(Console.ReadLine());

Console.WriteLine("Введите вторую координату точки A");
int cy = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третью координату точки A");
int cz = int.Parse(Console.ReadLine());

Console.WriteLine("Введите первую координату точки B");
int dx = int.Parse(Console.ReadLine());

Console.WriteLine("Введите вторую координату точки B");
int dy = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третью координату точки A");
int dz = int.Parse(Console.ReadLine());

int x = dx - cx;
int y = dy - cy;
int z = dz - cz;

double res1 = x * x + y * y + z * z;
double result1 = Math.Sqrt(res1);

Console.WriteLine("Расстояние между точками А и В в 3D плоскости = " + result1);