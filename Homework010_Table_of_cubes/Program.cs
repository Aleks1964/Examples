// ** Задача 23

// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Получаем таблицу умножения от 1 до N:");
for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"{i}**3 = {Math.Pow(i, 3)}");
}