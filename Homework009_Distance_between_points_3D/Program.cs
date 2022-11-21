// ** Задача 21

//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты X, Y и Z точки А:");
Console.Write("х1 = ");
double x1 = double.Parse(Console.ReadLine()!);
Console.Write("y1 = ");
double y1 = double.Parse(Console.ReadLine()!);
Console.Write("z1 = ");
double z1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты X, Y и Z точки B:");
Console.Write("х2 = ");
double x2 = double.Parse(Console.ReadLine()!);
Console.Write("y2 = ");
double y2 = double.Parse(Console.ReadLine()!);
Console.Write("z2 = ");
double z2 = double.Parse(Console.ReadLine()!);

double AB = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

Console.WriteLine($"Расстояние AB = {AB:f3}");